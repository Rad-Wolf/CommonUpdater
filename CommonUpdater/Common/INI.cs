using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Common.IO_INI
{
  public class INI
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
    /// <param name="FilePath">파일위치</param>
    public static void Write ( string SectionName, Dictionary<string, string> Keys, string FilePath )
    {
      foreach ( var item in Keys )
        WritePrivateProfileString( SectionName, item.Key, item.Value, FilePath );
    }

    /// <summary>
    /// INI 파일에 저장할 모든 설정 값들을 씁니다.
    /// </summary>
    /// <param name="writeObjcet">모든 값들</param>
    /// <param name="FilePath">파일 위치</param>
    public static void WriteAll ( Dictionary<string, Dictionary<string, string>> writeObjcet, string FilePath )
    {
      foreach ( var section in writeObjcet )
        foreach ( var key in section.Value )
          WritePrivateProfileString( section.Key, key.Key, key.Value, FilePath );
    }

    #endregion 쓰기

    #region 읽기

    public static Dictionary<string, string> Read ( string SectionName, string FilePath )
    {
      Dictionary<string, string> Keys = new Dictionary<string, string>( );

      if ( File.Exists( FilePath ) is true )
      {
        string [ ] line = File.ReadAllLines( FilePath );
        bool read = false;
        foreach ( var item in line )
        {
          if ( item [ 0 ] is ';' ) continue;
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

    public static Dictionary<string, Dictionary<string, string>> ReadAll ( string FilePath )
    {
      Dictionary<string, Dictionary<string, string>> inifile = new Dictionary<string, Dictionary<string, string>>( );

      Dictionary<string, string> subSection = new Dictionary<string, string>( );
      char [ ] defaultSplitSectionChar = { '[', ']' };
      char [ ] defalutSplitValueChar = { '=' };

      string [ ] line = File.ReadAllLines( FilePath );

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
}