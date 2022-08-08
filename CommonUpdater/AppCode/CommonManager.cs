using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Common;
namespace CommonUpdater
{
  public struct CommonFileInfo : IComparable<CommonFileInfo>, IEquatable<CommonFileInfo>
  {
    public string MainFolderPath;
    public string MainFolderName { get { return MainFolderPath.Split( '\\' ).Last( ); } }
    public List<string> CommonFilePath;

    public int CompareTo ( CommonFileInfo other )
    {
      if ( MainFolderPath is "" ) return 1;

      return string.Compare( this.MainFolderName, other.MainFolderName );
    }
  }
  public class CommonManager : BasicSingleton<CommonManager>
  {
    static string [ ] Extension = { ".cs", ".c", ".cpp", ".h", ".py" };
    static string [ ] ExcludeFolder = { ".vs", ".git", "bin", "obj", "Properties" };
    public string MainCommonFolderPath;
    public List<CommonFileInfo> TargetFolderList = new List<CommonFileInfo>( );

    public bool InCheck ( string Path )
    {
      foreach ( var item in TargetFolderList )
        if ( item.MainFolderPath == Path ) return true;
      return false;
    }
    public void ListSort ( ) => TargetFolderList.Sort( );

    public void TargetCheck ( )
    {
      foreach ( var Target in TargetFolderList )
      {
        if ( Directory.Exists( Target.MainFolderPath ) is false )
          TargetFolderList.Remove( Target );

      }
    }

    // 메인폼에서 Copy가 들어오면 Path 를 넣어서 common 폴더 내부에있는 파일 path 들을 따옴
    public CommonFileInfo AddTarget ( string FolderPath )
    {
      CommonFileInfo CommonInfo = new CommonFileInfo( );
      CommonInfo.MainFolderPath = FolderPath;
      CommonInfo.CommonFilePath = new List<string>( );
      CircuitousFloder( ref CommonInfo.CommonFilePath, CommonInfo.MainFolderPath );
      TargetFolderList.Add( CommonInfo );
      return TargetFolderList.Last( );
    }

    // 전부 다 뒤지는 재귀함수
    private bool CircuitousFloder ( ref List<string> Paths, string TargetFolder, bool Active = false )
    {
      var Info = new DirectoryInfo( TargetFolder );

      if ( ExcludeFolder.Any( data => Info.Name.Contains( data ) ) ) return false;

      if ( Info.Name == "Common" )
      {
        foreach ( var item in Info.GetFiles( ) )
          if ( Extension.Any( data => Path.GetExtension( item.FullName ).Contains( data ) ) ) // 문자열배열에서 문자열에 맞는 것이 있는지 비교해봄 (여기서는 확장자)
            Paths.Add( item.FullName );
        foreach ( var item in Info.GetDirectories( ) )
          CircuitousFloder( ref Paths, item.FullName, true );
      }
      else
        foreach ( var item in Info.GetDirectories( ) )
          CircuitousFloder( ref Paths, item.FullName );

      return true;
    }
  }
}
