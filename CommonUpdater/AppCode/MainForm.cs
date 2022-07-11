using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUpdater
{
  public partial class MainForm : Form
  {
    public MainForm ( )
    {
      InitializeComponent( );
    }


    string DragPath;
    // AllowDrop = true 상태가 되야 드롭이 활성화됨
    // 드롭을 하면
    private void TB_MainComminFolder_DragDrop ( object sender, DragEventArgs e )
    {
      TB_MainComminFolder.Text = DragPath;

    }

    //드래그 상태에서 들어오면
    private void TB_MainComminFolder_DragEnter ( object sender, DragEventArgs e )
    {
      if ( e.Data.GetDataPresent( DataFormats.FileDrop ) )
      {
        e.Effect = DragDropEffects.Copy;
        var DirectoryName = ( string [ ] ) e.Data.GetData( DataFormats.FileDrop );
        DragPath = DirectoryName [ 0 ];
      }
      else e.Effect = DragDropEffects.None;
    }

    private void BT_AddList_Click ( object sender, EventArgs e )
    {

    }
  }
}
