using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Common.IO_INI;

namespace CommonUpdater.AppCode.Forms
{
  public partial class DetailForm : Form, ISection
  {
    public DetailForm ( )
    {
      InitializeComponent( );
    }

    public DetailForm ( CommonFolder Data )
    {
      InitializeComponent( );

      FolderLabel.Text = "";

      if ( Data.MainFolder == null ) return;

      FolderLabel.Text = Data.MainFolder.Name;
      foreach ( var item in Data.CommonFiles )
        FileListView.Items.Add( new ListViewItem( new String [ ] { item.Name, item.LastWriteTime.ToString( "f" ), item.FullName, item.Length.ToString( ) } ) );
    }

    private void ClosingButton_Click ( object sender, EventArgs e ) => this.Close( );

    private void DataSave ( )
    {
      SaveData += (CH_Name.Text, CH_Name.Width.ToString( ));
      SaveData += (CH_LastWrite.Text, CH_LastWrite.Width.ToString( ));
      SaveData += (CH_FullName.Text, CH_LastWrite.Width.ToString( ));
      SaveData += (CH_FileSize.Text, CH_FileSize.Width.ToString( ));
      InitializationFileManager.Instant.SaveData( );
    }

    private void DetailForm_Load ( object sender, EventArgs e )
    {
      SubscribeManager( );
      var data = InitializationFileManager.Instant [ SaveData.Name ];

      if ( data is null ) return;

      CH_Name.Width = ( data.ContainsKey( "Name" ) ? Convert.ToInt32( data [ "Name" ] ) : CH_Name.Width );
      CH_FileSize.Width = ( data.ContainsKey( "FileSize" ) ? Convert.ToInt32( data [ "FileSize" ] ) : CH_FileSize.Width );
      CH_LastWrite.Width = ( data.ContainsKey( "LastWrite" ) ? Convert.ToInt32( data [ "LastWrite" ] ) : CH_LastWrite.Width );
      CH_FullName.Width = ( data.ContainsKey( "FullName" ) ? Convert.ToInt32( data [ "FullName" ] ) : CH_FullName.Width );
    }

    private void DetailForm_FormClosing ( object sender, FormClosingEventArgs e ) => DataSave( );

    private Section SaveData = new Section( "DetailForm" );

    public void SubscribeManager ( ) => InitializationFileManager.Instant.Subscriber.Add( this );

    public void UnsubscribeManager ( ) => InitializationFileManager.Instant.Subscriber.Remove( this );

    public void AutoSaveData ( ) => InitializationFileManager.Instant [ SaveData.Name ] = SaveData.ToDictionary( );
  }
}