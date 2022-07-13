using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Common;

namespace CommonUpdater0._2.AppCode
{
  public struct CommonFolder
  {
    public FileSystemInfo MainFolder;
    public List<FileSystemInfo> CommonFiles;
  }

  public class CommonManager : BasicSingleton<CommonManager>
  {
    private static string [ ] Extension = { ".cs", ".c", ".cpp", ".h", ".py" };
    private static string [ ] ExcludeFolder = { ".vs", ".git", "bin", "obj", "Properties" };

    public CommonFolder MainFolder;
    public List<CommonFolder> CommonFolders;

    // Any 를 쓰면 리스트 내부에서 같은 것이 있는지 모두 검색이 가능하다. 람다식으로 처리해서 얻으면 됨
    public bool InCheck ( string FolderPath ) => CommonFolders.Any( data => data.MainFolder.FullName == FolderPath ); //람다식 리턴이 가능하다?!

    private CommonFolder Cir
  }
}