namespace CommonUpdater.AppCode.Forms
{
  partial class DetailForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose ( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ( )
    {
      this.FileListView = new System.Windows.Forms.ListView();
      this.CH_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CH_LastWrite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CH_FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CH_FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ClosingButton = new System.Windows.Forms.Button();
      this.FolderLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // FileListView
      // 
      this.FileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Name,
            this.CH_LastWrite,
            this.CH_FullName,
            this.CH_FileSize});
      this.FileListView.HideSelection = false;
      this.FileListView.Location = new System.Drawing.Point(12, 28);
      this.FileListView.Name = "FileListView";
      this.FileListView.Size = new System.Drawing.Size(776, 385);
      this.FileListView.TabIndex = 0;
      this.FileListView.UseCompatibleStateImageBehavior = false;
      this.FileListView.View = System.Windows.Forms.View.Details;
      // 
      // CH_Name
      // 
      this.CH_Name.Text = "Name";
      // 
      // CH_LastWrite
      // 
      this.CH_LastWrite.Text = "LastWrite";
      // 
      // CH_FullName
      // 
      this.CH_FullName.Text = "FullName";
      // 
      // CH_FileSize
      // 
      this.CH_FileSize.Text = "FileSize";
      // 
      // ClosingButton
      // 
      this.ClosingButton.Location = new System.Drawing.Point(713, 417);
      this.ClosingButton.Margin = new System.Windows.Forms.Padding(1);
      this.ClosingButton.Name = "ClosingButton";
      this.ClosingButton.Size = new System.Drawing.Size(75, 23);
      this.ClosingButton.TabIndex = 1;
      this.ClosingButton.Text = "Close";
      this.ClosingButton.UseVisualStyleBackColor = true;
      this.ClosingButton.Click += new System.EventHandler(this.ClosingButton_Click);
      // 
      // FolderLabel
      // 
      this.FolderLabel.AutoSize = true;
      this.FolderLabel.Location = new System.Drawing.Point(13, 13);
      this.FolderLabel.Name = "FolderLabel";
      this.FolderLabel.Size = new System.Drawing.Size(74, 12);
      this.FolderLabel.TabIndex = 2;
      this.FolderLabel.Text = "FolderName";
      // 
      // DetailForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.ControlBox = false;
      this.Controls.Add(this.FolderLabel);
      this.Controls.Add(this.ClosingButton);
      this.Controls.Add(this.FileListView);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DetailForm";
      this.Text = "DetailForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailForm_FormClosing);
      this.Load += new System.EventHandler(this.DetailForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView FileListView;
    private System.Windows.Forms.Button ClosingButton;
    private System.Windows.Forms.ColumnHeader CH_Name;
    private System.Windows.Forms.ColumnHeader CH_LastWrite;
    private System.Windows.Forms.ColumnHeader CH_FullName;
    private System.Windows.Forms.ColumnHeader CH_FileSize;
    private System.Windows.Forms.Label FolderLabel;
  }
}