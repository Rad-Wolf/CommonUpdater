using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CommonUpdater.AppCode;

namespace CommonUpdater.AppCode.Forms
{
  public partial class OptionForm : Form
  {
    public OptionForm ( )
    {
      InitializeComponent( );
    }

    public string MessageMonitor { get { return MessageLabel.Text; } set { MessageLabel.Text = value; } }

    private void OptionForm_Load ( object sender, EventArgs e )
    {
      MessageMonitor = "";

      if ( CommonManager.Instant.MainFolder.MainFolder != null )
        TB_MainFolderPath.Text = CommonManager.Instant.MainFolder.MainFolder.Name;
    }

    private void OptionForm_Click ( object sender, EventArgs e ) => this.ActiveControl = null;

    // 버튼들
    private void BT_Closing_Click ( object sender, EventArgs e ) => this.Close( );

    private void BT_Delete_Click ( object sender, EventArgs e )
    {
      if ( LV_CommonList.SelectedItems.Count is 0 ) return;
      CommonManager.Instant.CommonFolders.RemoveAt( LV_CommonList.SelectedItems [ 0 ].Index );

      LV_Refresh( );
    }

    private void BT_MainFolderCheck_Click ( object sender, EventArgs e ) => new DetailForm( CommonManager.Instant.MainFolder ).ShowDialog( );

    // 참고용
    private void DragDropFunction ( ref object sender, ref DragEventArgs e )
    {
      string [ ] Item = ( string [ ] ) e.Data.GetData( DataFormats.FileDrop );
    }

    private void DragEnterFunction ( ref object sender, ref DragEventArgs e )
      => e.Effect = ( !e.Data.GetDataPresent( DataFormats.FileDrop ) ) ? DragDropEffects.None : DragDropEffects.Copy;

    #region 메인 텍스트박스

    private void TB_MainFolderPath_Enter ( object sender, EventArgs e )
      => TB_MainFolderPath.Text = ( CommonManager.Instant.MainFolder.MainFolder == null ) ? "" : CommonManager.Instant.MainFolder.MainFolder.FullName;

    private void TB_MainFolderPath_Leave ( object sender, EventArgs e )
      => TB_MainFolderPath.Text = ( CommonManager.Instant.MainFolder.MainFolder == null ) ? "" : CommonManager.Instant.MainFolder.MainFolder.Name;

    private void TB_MainFolderPath_DragDrop ( object sender, DragEventArgs e )
    {
      string path = ( ( string [ ] ) e.Data.GetData( DataFormats.FileDrop ) ) [ 0 ];
      TB_MainFolderPath.Text = path;
      CommonManager.Instant.InitMainFolder( path );
    }

    private void TB_MainFolderPath_DragEnter ( object sender, DragEventArgs e )
      => e.Effect = ( !e.Data.GetDataPresent( DataFormats.FileDrop ) ? DragDropEffects.None : DragDropEffects.Copy );

    #endregion 메인 텍스트박스

    #region 리스트박스

    private void LV_Refresh ( )
    {
      LV_CommonList.Items.Clear( );
      CommonManager.Instant.CommonFolders.Sort( );

      foreach ( var item in CommonManager.Instant.CommonFolders )
        LV_CommonList.Items.Add( new ListViewItem( new String [ ] { item.MainFolder.Name, item.MainFolder.FullName, item.CommonFiles.Count.ToString( ) } ) );

      ContentLabel.Text = $"File : {LV_CommonList.Items.Count.ToString( "000" )}";
    }

    private void LV_CommonList_DragDrop ( object sender, DragEventArgs e )
    {
      string [ ] DropItem = ( string [ ] ) e.Data.GetData( DataFormats.FileDrop );

      foreach ( var item in DropItem ) CommonManager.Instant.AddFolder( item );

      LV_Refresh( );
    }

    private void LV_CommonList_DragEnter ( object sender, DragEventArgs e )
      => e.Effect = ( !e.Data.GetDataPresent( DataFormats.FileDrop ) ) ? DragDropEffects.None : DragDropEffects.Copy;

    private void LV_CommonList_DoubleClick ( object sender, EventArgs e )
    {
      if ( LV_CommonList.SelectedItems.Count != 1 ) return;

      var item = LV_CommonList.SelectedItems [ 0 ];

      //subitems 는 0번째에 메인이 아니라 첫번째 컬럼의 정보가 들어감
      //MessageBox.Show( $"{item.SubItems [ 0 ].Text} : {item.SubItems [ 1 ].Text} \nCount : {item.SubItems [ 2 ].Text}" );
      // form show 는 부모 폼을 자유로이 할 수 있으며 show dialog 는 자식form 을 닫기 전까지는 부모를 컨트롤할 수 없다.
      new DetailForm( CommonManager.Instant.CommonFolders.Find( data => data.Equals( item.SubItems [ 1 ].Text ) ) ).ShowDialog( );
    }

    #endregion 리스트박스
  }
}