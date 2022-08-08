using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Common;
using Common.IO_INI;

namespace CommonUpdater.AppCode
{
  public struct CommonFolder : IComparable<CommonFolder>, IEquatable<CommonFolder>
  {
    public DirectoryInfo MainFolder;
    public List<FileInfo> CommonFiles;

    public int CompareTo ( CommonFolder other )
    {
      if ( MainFolder == null ) return 1;
      return string.Compare( this.MainFolder.FullName, other.MainFolder.FullName );
    }

    public bool Equals ( CommonFolder other )
    {
      if ( MainFolder == null ) return false;
      return ( this.MainFolder.FullName == other.MainFolder.FullName );
    }

    public bool Equals ( string FullName )
    {
      if ( FullName == "" || MainFolder == null ) return false;
      return ( this.MainFolder.FullName == FullName );
    }
  }

  public class CommonManager : BasicSingleton<CommonManager>
  {
    private static string [ ] Extension = { ".cs", ".c", ".cpp", ".h", ".py" };
    private static string [ ] ExcludeFolder = { ".vs", ".git", "bin", "obj", "Properties" };

    public CommonFolder MainFolder;
    public List<CommonFolder> CommonFolders = new List<CommonFolder>( );

    // Any 를 쓰면 리스트 내부에서 같은 것이 있는지 모두 검색이 가능하다. 람다식으로 처리해서 얻으면 됨
    public bool InCheck ( string FolderPath ) => CommonFolders.Any( data => data.MainFolder.FullName == FolderPath ); //람다식 리턴이 가능하다?!

    private void CircuitousFloder ( ref List<FileInfo> AddItem, string TargetFolder, bool Active = false )
    {
      var folderInfo = new DirectoryInfo( TargetFolder );

      if ( ExcludeFolder.Any( data => folderInfo.Name.Contains( data ) ) ) return;

      if ( folderInfo.Name == "Common" || Active is true )
      {
        foreach ( var item in folderInfo.GetFiles( ) )
          if ( Extension.Any( data => item.Name.Contains( data ) ) ) AddItem.Add( item );
        foreach ( var item in folderInfo.GetDirectories( ) )
          CircuitousFloder( ref AddItem, item.FullName, true );
      }
      else
        foreach ( var item in folderInfo.GetDirectories( ) )
          CircuitousFloder( ref AddItem, item.FullName );
    }

    public void InitMainFolder ( string FolderPath )
    {
      if ( InCheck( FolderPath ) is true ) return;

      var folder = new CommonFolder( );
      folder.MainFolder = new DirectoryInfo( FolderPath );
      folder.CommonFiles = new List<FileInfo>( );

      CircuitousFloder( ref folder.CommonFiles, folder.MainFolder.FullName );
      MainFolder = folder;
    }

    public CommonFolder AddFolder ( string FolderPath )
    {
      if ( InCheck( FolderPath ) is true ) return new CommonFolder( );

      var folder = new CommonFolder( );
      folder.MainFolder = new DirectoryInfo( FolderPath );
      folder.CommonFiles = new List<FileInfo>( );

      CircuitousFloder( ref folder.CommonFiles, folder.MainFolder.FullName );
      CommonFolders.Add( folder );
      return folder;
    }
  }
}