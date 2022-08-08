namespace CommonUpdater.AppCode.Forms
{
  partial class OptionForm
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
      this.BT_Closing = new System.Windows.Forms.Button();
      this.TB_MainFolderPath = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.LV_CommonList = new System.Windows.Forms.ListView();
      this.CH_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CH_FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CH_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label2 = new System.Windows.Forms.Label();
      this.BT_MainFolderCheck = new System.Windows.Forms.Button();
      this.ContentLabel = new System.Windows.Forms.Label();
      this.MessageLabel = new System.Windows.Forms.Label();
      this.BT_Delete = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BT_Closing
      // 
      this.BT_Closing.Location = new System.Drawing.Point(436, 363);
      this.BT_Closing.Name = "BT_Closing";
      this.BT_Closing.Size = new System.Drawing.Size(75, 23);
      this.BT_Closing.TabIndex = 0;
      this.BT_Closing.Text = "Close";
      this.BT_Closing.UseVisualStyleBackColor = true;
      this.BT_Closing.Click += new System.EventHandler(this.BT_Closing_Click);
      // 
      // TB_MainFolderPath
      // 
      this.TB_MainFolderPath.AllowDrop = true;
      this.TB_MainFolderPath.Location = new System.Drawing.Point(174, 9);
      this.TB_MainFolderPath.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.TB_MainFolderPath.Name = "TB_MainFolderPath";
      this.TB_MainFolderPath.Size = new System.Drawing.Size(337, 21);
      this.TB_MainFolderPath.TabIndex = 1;
      this.TB_MainFolderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_MainFolderPath_DragDrop);
      this.TB_MainFolderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_MainFolderPath_DragEnter);
      this.TB_MainFolderPath.Enter += new System.EventHandler(this.TB_MainFolderPath_Enter);
      this.TB_MainFolderPath.Leave += new System.EventHandler(this.TB_MainFolderPath_Leave);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(11, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(157, 12);
      this.label1.TabIndex = 2;
      this.label1.Text = "Main Common Folder Path";
      // 
      // LV_CommonList
      // 
      this.LV_CommonList.AllowDrop = true;
      this.LV_CommonList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Name,
            this.CH_FullName,
            this.CH_Count});
      this.LV_CommonList.HideSelection = false;
      this.LV_CommonList.Location = new System.Drawing.Point(11, 71);
      this.LV_CommonList.Name = "LV_CommonList";
      this.LV_CommonList.Size = new System.Drawing.Size(500, 286);
      this.LV_CommonList.TabIndex = 3;
      this.LV_CommonList.UseCompatibleStateImageBehavior = false;
      this.LV_CommonList.View = System.Windows.Forms.View.Details;
      this.LV_CommonList.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_CommonList_DragDrop);
      this.LV_CommonList.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_CommonList_DragEnter);
      this.LV_CommonList.DoubleClick += new System.EventHandler(this.LV_CommonList_DoubleClick);
      // 
      // CH_Name
      // 
      this.CH_Name.Text = "Name";
      this.CH_Name.Width = 100;
      // 
      // CH_FullName
      // 
      this.CH_FullName.Text = "FullName";
      this.CH_FullName.Width = 335;
      // 
      // CH_Count
      // 
      this.CH_Count.Text = "Count";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(103, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = "Common Folders";
      // 
      // BT_MainFolderCheck
      // 
      this.BT_MainFolderCheck.Location = new System.Drawing.Point(436, 33);
      this.BT_MainFolderCheck.Name = "BT_MainFolderCheck";
      this.BT_MainFolderCheck.Size = new System.Drawing.Size(75, 23);
      this.BT_MainFolderCheck.TabIndex = 5;
      this.BT_MainFolderCheck.Text = "Check";
      this.BT_MainFolderCheck.UseVisualStyleBackColor = true;
      this.BT_MainFolderCheck.Click += new System.EventHandler(this.BT_MainFolderCheck_Click);
      // 
      // ContentLabel
      // 
      this.ContentLabel.Location = new System.Drawing.Point(303, 33);
      this.ContentLabel.Name = "ContentLabel";
      this.ContentLabel.Size = new System.Drawing.Size(127, 23);
      this.ContentLabel.TabIndex = 6;
      this.ContentLabel.Text = "File : 000";
      this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // MessageLabel
      // 
      this.MessageLabel.Location = new System.Drawing.Point(11, 33);
      this.MessageLabel.Name = "MessageLabel";
      this.MessageLabel.Size = new System.Drawing.Size(286, 23);
      this.MessageLabel.TabIndex = 6;
      this.MessageLabel.Text = "Message Monitor";
      this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // BT_Delete
      // 
      this.BT_Delete.Location = new System.Drawing.Point(355, 363);
      this.BT_Delete.Name = "BT_Delete";
      this.BT_Delete.Size = new System.Drawing.Size(75, 23);
      this.BT_Delete.TabIndex = 7;
      this.BT_Delete.Text = "Delete";
      this.BT_Delete.UseVisualStyleBackColor = true;
      this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
      // 
      // OptionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
      this.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.ClientSize = new System.Drawing.Size(522, 395);
      this.Controls.Add(this.BT_Delete);
      this.Controls.Add(this.MessageLabel);
      this.Controls.Add(this.ContentLabel);
      this.Controls.Add(this.BT_MainFolderCheck);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.LV_CommonList);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TB_MainFolderPath);
      this.Controls.Add(this.BT_Closing);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "OptionForm";
      this.Text = "OptionForm";
      this.Load += new System.EventHandler(this.OptionForm_Load);
      this.Click += new System.EventHandler(this.OptionForm_Click);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BT_Closing;
    private System.Windows.Forms.TextBox TB_MainFolderPath;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListView LV_CommonList;
    private System.Windows.Forms.ColumnHeader CH_Name;
    private System.Windows.Forms.ColumnHeader CH_FullName;
    private System.Windows.Forms.ColumnHeader CH_Count;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BT_MainFolderCheck;
    private System.Windows.Forms.Label ContentLabel;
    private System.Windows.Forms.Label MessageLabel;
    private System.Windows.Forms.Button BT_Delete;
  }
}