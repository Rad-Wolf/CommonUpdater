namespace CommonUpdater
{
  partial class MainForm
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose ( bool disposing )
    {
      if ( disposing && ( components != null ) )
      {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent ( )
    {
      this.TB_AddCommonFolder = new System.Windows.Forms.TextBox();
      this.BT_AddList = new System.Windows.Forms.Button();
      this.LBox_MainName = new System.Windows.Forms.ListBox();
      this.LBox_Objectname = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.BT_Removelist = new System.Windows.Forms.Button();
      this.BT_View = new System.Windows.Forms.Button();
      this.BT_Refresh = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.TB_MainCommonFolder = new System.Windows.Forms.TextBox();
      this.BT_Check = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // TB_AddCommonFolder
      // 
      this.TB_AddCommonFolder.AllowDrop = true;
      this.TB_AddCommonFolder.Location = new System.Drawing.Point(12, 63);
      this.TB_AddCommonFolder.Name = "TB_AddCommonFolder";
      this.TB_AddCommonFolder.Size = new System.Drawing.Size(579, 21);
      this.TB_AddCommonFolder.TabIndex = 0;
      this.TB_AddCommonFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_AddCommonFolder_DragDrop);
      this.TB_AddCommonFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_AddCommonFolder_DragEnter);
      // 
      // BT_AddList
      // 
      this.BT_AddList.Location = new System.Drawing.Point(597, 61);
      this.BT_AddList.Name = "BT_AddList";
      this.BT_AddList.Size = new System.Drawing.Size(75, 23);
      this.BT_AddList.TabIndex = 1;
      this.BT_AddList.Text = "등록";
      this.BT_AddList.UseVisualStyleBackColor = true;
      this.BT_AddList.Click += new System.EventHandler(this.BT_AddList_Click);
      // 
      // LBox_MainName
      // 
      this.LBox_MainName.FormattingEnabled = true;
      this.LBox_MainName.ItemHeight = 12;
      this.LBox_MainName.Location = new System.Drawing.Point(12, 106);
      this.LBox_MainName.Name = "LBox_MainName";
      this.LBox_MainName.ScrollAlwaysVisible = true;
      this.LBox_MainName.Size = new System.Drawing.Size(286, 172);
      this.LBox_MainName.TabIndex = 2;
      this.LBox_MainName.SelectedIndexChanged += new System.EventHandler(this.LBox_MainName_SelectedIndexChanged);
      // 
      // LBox_Objectname
      // 
      this.LBox_Objectname.FormattingEnabled = true;
      this.LBox_Objectname.ItemHeight = 12;
      this.LBox_Objectname.Location = new System.Drawing.Point(305, 106);
      this.LBox_Objectname.Name = "LBox_Objectname";
      this.LBox_Objectname.ScrollAlwaysVisible = true;
      this.LBox_Objectname.SelectionMode = System.Windows.Forms.SelectionMode.None;
      this.LBox_Objectname.Size = new System.Drawing.Size(286, 172);
      this.LBox_Objectname.TabIndex = 3;
      this.LBox_Objectname.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 48);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 12);
      this.label1.TabIndex = 4;
      this.label1.Text = "등록 Common 위치";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 91);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 5;
      this.label2.Text = "목록";
      // 
      // BT_Removelist
      // 
      this.BT_Removelist.Location = new System.Drawing.Point(597, 106);
      this.BT_Removelist.Name = "BT_Removelist";
      this.BT_Removelist.Size = new System.Drawing.Size(75, 23);
      this.BT_Removelist.TabIndex = 1;
      this.BT_Removelist.Text = "제거";
      this.BT_Removelist.UseVisualStyleBackColor = true;
      this.BT_Removelist.Click += new System.EventHandler(this.BT_Removelist_Click);
      // 
      // BT_View
      // 
      this.BT_View.Location = new System.Drawing.Point(597, 226);
      this.BT_View.Name = "BT_View";
      this.BT_View.Size = new System.Drawing.Size(75, 23);
      this.BT_View.TabIndex = 1;
      this.BT_View.Text = "보기";
      this.BT_View.UseVisualStyleBackColor = true;
      this.BT_View.Click += new System.EventHandler(this.BT_View_Click);
      // 
      // BT_Refresh
      // 
      this.BT_Refresh.Location = new System.Drawing.Point(597, 255);
      this.BT_Refresh.Name = "BT_Refresh";
      this.BT_Refresh.Size = new System.Drawing.Size(75, 23);
      this.BT_Refresh.TabIndex = 1;
      this.BT_Refresh.Text = "새로고침";
      this.BT_Refresh.UseVisualStyleBackColor = true;
      this.BT_Refresh.Click += new System.EventHandler(this.BT_Refresh_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 12);
      this.label3.TabIndex = 4;
      this.label3.Text = "MainCommon 위치";
      // 
      // TB_MainCommonFolder
      // 
      this.TB_MainCommonFolder.AllowDrop = true;
      this.TB_MainCommonFolder.Location = new System.Drawing.Point(14, 24);
      this.TB_MainCommonFolder.Name = "TB_MainCommonFolder";
      this.TB_MainCommonFolder.Size = new System.Drawing.Size(579, 21);
      this.TB_MainCommonFolder.TabIndex = 0;
      this.TB_MainCommonFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_MainCommonFolder_DragDrop);
      this.TB_MainCommonFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_MainCommonFolder_DragEnter);
      // 
      // BT_Check
      // 
      this.BT_Check.Location = new System.Drawing.Point(597, 24);
      this.BT_Check.Name = "BT_Check";
      this.BT_Check.Size = new System.Drawing.Size(75, 23);
      this.BT_Check.TabIndex = 1;
      this.BT_Check.Text = "확인";
      this.BT_Check.UseVisualStyleBackColor = true;
      this.BT_Check.Click += new System.EventHandler(this.BT_Check_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 332);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.LBox_Objectname);
      this.Controls.Add(this.LBox_MainName);
      this.Controls.Add(this.BT_Refresh);
      this.Controls.Add(this.BT_View);
      this.Controls.Add(this.BT_Check);
      this.Controls.Add(this.BT_Removelist);
      this.Controls.Add(this.BT_AddList);
      this.Controls.Add(this.TB_MainCommonFolder);
      this.Controls.Add(this.TB_AddCommonFolder);
      this.Name = "MainForm";
      this.Text = "CommonObserver";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TB_AddCommonFolder;
    private System.Windows.Forms.Button BT_AddList;
    private System.Windows.Forms.ListBox LBox_MainName;
    private System.Windows.Forms.ListBox LBox_Objectname;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BT_Removelist;
    private System.Windows.Forms.Button BT_View;
    private System.Windows.Forms.Button BT_Refresh;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TB_MainCommonFolder;
    private System.Windows.Forms.Button BT_Check;
  }
}

