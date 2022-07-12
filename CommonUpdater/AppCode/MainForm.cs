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
    private void TB_AddCommonFolder_DragDrop ( object sender, DragEventArgs e ) => TB_AddCommonFolder.Text = DragPath;
    private void TB_MainCommonFolder_DragDrop ( object sender, DragEventArgs e ) => TB_MainCommonFolder.Text = DragPath;
    //드래그 상태에서 들어오면
    private void TB_AddCommonFolder_DragEnter ( object sender, DragEventArgs e ) => DragEnterFuncion( ref sender, ref e );
    private void TB_MainCommonFolder_DragEnter ( object sender, DragEventArgs e ) => DragEnterFuncion( ref sender, ref e );
    #region DragEnterFuncion
    //중복된것을 하나로
    //1개
    private void DragEnterFuncion ( ref object sender, ref DragEventArgs e )
    {
      if ( e.Data.GetDataPresent( DataFormats.FileDrop ) )
      {
        e.Effect = DragDropEffects.Copy;
        string [ ] DirectoryName = ( string [ ] ) e.Data.GetData( DataFormats.FileDrop );
        DragPath = DirectoryName [ 0 ]; // 여기를 바꿔주면 여러개 드롭도 가능하다.
      }
      else e.Effect = DragDropEffects.None;
    }
    #endregion DragEnterFuncion

    private void BT_AddList_Click ( object sender, EventArgs e )
    {
      if ( !CommonManager.Instant.InCheck( TB_AddCommonFolder.Text ) )
      {
        CommonFileInfo item = CommonManager.Instant.AddTarget( TB_AddCommonFolder.Text );
        TB_AddCommonFolder.Text = "";
        BT_Refresh_Click( this, e );
      }
    }

    private void BT_Check_Click ( object sender, EventArgs e )
    {
    }

    private void BT_Removelist_Click ( object sender, EventArgs e )
    {
      CommonManager.Instant.TargetFolderList.RemoveAt( LBox_MainName.SelectedIndex );
      BT_Refresh_Click( this, e );
    }

    private void BT_View_Click ( object sender, EventArgs e ) => System.Diagnostics.Process.Start( CommonManager.Instant.TargetFolderList [ LBox_MainName.SelectedIndex ].MainFolderPath );


    private void BT_Refresh_Click ( object sender, EventArgs e )
    {
      CommonManager.Instant.ListSort( );
      LBox_MainName.Items.Clear( );
      foreach ( var item in CommonManager.Instant.TargetFolderList )
      {
        LBox_MainName.Items.Add( item.MainFolderPath.Split( '\\' ).Last( ) );
      }
    }


    private void LBox_MainName_SelectedIndexChanged ( object sender, EventArgs e )
    {
      LBox_Objectname.Items.Clear( );

      if ( CommonManager.Instant.TargetFolderList.Count is 0 ) return;

      CommonFileInfo item = CommonManager.Instant.TargetFolderList [ LBox_MainName.SelectedIndex ];
      foreach ( var obj in item.CommonFilePath )
        LBox_Objectname.Items.Add( obj.Split( '\\' ).Last( ) );
    }
  }
}
