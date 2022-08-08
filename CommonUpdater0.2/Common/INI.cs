using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Common.IO_INI
{
  public class InitializationFile
  {
    #region DLL

    [DllImport( "kernel32" )]
    private static extern long WritePrivateProfileString ( string section, string key, string val, string filePath );

    //읽기가 가능하나 전부 불러올 경우 필요가 없음
    //[DllImport( "kernel32" )]
    //private static extern int GetPrivateProfileString ( string section, string key, string def, StringBuilder retVal, int size, string filePath );

    #endregion DLL

    #region 쓰기

    /// <summary>
    /// 특정 섹션을 선택해서 원하는 값을 씁니다.
    /// </summary>
    /// <param name="SectionName">[섹션 이름]</param>
    /// <param name="Keys">딕션으로 넣어주시면 됩니다.</param>
    /// <param name="FullPath">파일위치</param>
    public static void Write ( string SectionName, Dictionary<string, string> Keys, string FullPath )
    {
      if ( File.Exists( FullPath ) ) File.Delete( FullPath );
      foreach ( var item in Keys )
        WritePrivateProfileString( SectionName, item.Key, item.Value, FullPath );
    }

    /// <summary>
    /// INI 파일에 저장할 모든 설정 값들을 씁니다.
    /// </summary>
    /// <param name="writeObjcet">모든 값들</param>
    /// <param name="FullPath">파일 위치</param>
    public static void WriteAll ( Dictionary<string, Dictionary<string, string>> writeObjcet, string FullPath )
    {
      if ( File.Exists( FullPath ) ) File.Delete( FullPath );
      foreach ( var section in writeObjcet )
        foreach ( var key in section.Value )
          WritePrivateProfileString( section.Key, key.Key, key.Value, FullPath );
    }

    #endregion 쓰기

    #region 읽기

    public static Dictionary<string, string> Read ( string SectionName, string FullPath )
    {
      Dictionary<string, string> Keys = new Dictionary<string, string>( );

      if ( File.Exists( FullPath ) is true )
      {
        string [ ] line = File.ReadAllLines( FullPath );
        bool read = false;
        foreach ( var item in line )
        {
          if ( item.Length == 0 ) continue;
          else if ( item [ 0 ] is ';' ) continue;
          else if ( item.IndexOf( '[' ) is 0 && item.IndexOf( SectionName ) is 1 )
            read = true;
          else if ( read is true )
          {
            if ( item [ 0 ] is '[' ) break;

            int location = item.IndexOf( '=' );

            Keys.Add( item.Substring( 0, location ), item.Substring( location + 1, item.Length - location - 1 ) );
          }
        }
      }

      return Keys;
    }

    public static Dictionary<string, Dictionary<string, string>> ReadAll ( string FullPath )
    {
      Dictionary<string, Dictionary<string, string>> inifile = new Dictionary<string, Dictionary<string, string>>( );

      Dictionary<string, string> subSection = new Dictionary<string, string>( );
      char [ ] defaultSplitSectionChar = { '[', ']' };
      char [ ] defalutSplitValueChar = { '=' };

      string [ ] line = File.ReadAllLines( FullPath );

      string sectionName = "", key = "", value = "";

      foreach ( var item in line )
      {
        if ( item [ 0 ] is ';' ) continue;
        else if ( item.IndexOf( '[' ) is 0 )
        {
          if ( !( sectionName is "" ) )
          {
            inifile.Add( sectionName, subSection );
            subSection = new Dictionary<string, string>( );
          }
          sectionName = string.Join( "", item.Split( defaultSplitSectionChar ) );
        }
        else
        {
          var temp = item.Split( defalutSplitValueChar );
          subSection.Add( temp [ 0 ], temp [ 1 ] );
        }
      }

      inifile.Add( sectionName, subSection );

      return inifile;
    }

    #endregion 읽기
  }

  public class Section : Dictionary<string, string>
  {
    public string Name { get; set; }

    public Section ( string name ) => Name = name;

    public static Section operator + ( Section sec, (string, string) other )
    {
      if ( sec.ContainsKey( other.Item1 ) )
        sec [ other.Item1 ] = other.Item2;
      else
        sec.Add( other.Item1, other.Item2 );
      return sec;
    }

    public static Section operator + ( Section sec, Dictionary<string, string> dic )
    {
      foreach ( var item in dic )
        if ( sec.ContainsKey( item.Key ) )
          sec [ item.Key ] = item.Value;
        else
          sec.Add( item.Key, item.Value );
      return sec;
    }

    public Dictionary<string, string> ToDictionary ( )
    {
      Dictionary<string, string> result = new Dictionary<string, string>( );

      foreach ( var item in this )
        result.Add( item.Key, item.Value );

      return result;
    }

    public void Sort ( )
    {
      var temp = this.ToList( );
      temp.Sort( ( x, y ) => x.Key.CompareTo( y.Key ) );

      this.Clear( );

      foreach ( var item in temp )
        this.Add( item.Key, item.Value );
    }
  }

  public interface ISection
  {
    void SubscribeManager ( );

    void UnsubscribeManager ( );

    void AutoSaveData ( );
  }

  public class InitializationFileManager
  {
    #region Singleton

    /// <summary>
    /// Common 에 있는 BasicSingleton 에서 가져오기에는 클래스만 사용할 때가 있을 것 같아 직접 심어둠
    /// </summary>

    private static InitializationFileManager SingleObject;
    private static object Locker = new object( );

    public static InitializationFileManager Instant {
      get {
        lock ( Locker )
        {
          if ( SingleObject is null )
            SingleObject = new InitializationFileManager( );
          return SingleObject;
        }
      }
    }

    #endregion Singleton

    private bool Saveing = false;
    private readonly string FullPath = Directory.GetCurrentDirectory( ) + "\\Data.ini";
    public List<ISection> Subscriber = new List<ISection>( );
    private Dictionary<string, Dictionary<string, string>> Data;

    public InitializationFileManager ( ) => Data = ( File.Exists( FullPath ) ) ? InitializationFile.ReadAll( FullPath ) : new Dictionary<string, Dictionary<string, string>>( );

    public Dictionary<string, string> this [ string SectionName ] {
      get {
        if ( Data.ContainsKey( SectionName ) is false ) return null;
        return Data [ SectionName ];
      }
      set {
        if ( Data.ContainsKey( SectionName ) is false )
          Data.Add( SectionName, null );

        Data [ SectionName ] = value;
      }
    }

    public void SaveData ( )
    {
      if ( Saveing is true ) return;
      Saveing = true;
      foreach ( var item in Subscriber )
        item.AutoSaveData( );
      InitializationFile.WriteAll( Data, Directory.GetCurrentDirectory( ) + "\\Data.ini" );
      Saveing = false;
    }

    public void LoadData ( ) => Data = InitializationFile.ReadAll( Directory.GetCurrentDirectory( ) );
  }
}