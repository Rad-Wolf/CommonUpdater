namespace CommonUpdater.AppCode
{
  partial class TrayForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayForm));
      this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
      this.CMS_MenuBox = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.실행중ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CMS_MenuBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // Notify
      // 
      this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
      this.Notify.Text = "WApp";
      this.Notify.Visible = true;
      // 
      // CMS_MenuBox
      // 
      this.CMS_MenuBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.옵션ToolStripMenuItem,
            this.실행중ToolStripMenuItem,
            this.종료ToolStripMenuItem});
      this.CMS_MenuBox.Name = "CMS_MenuBox";
      this.CMS_MenuBox.Size = new System.Drawing.Size(111, 70);
      // 
      // 옵션ToolStripMenuItem
      // 
      this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
      this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.옵션ToolStripMenuItem.Text = "옵션";
      this.옵션ToolStripMenuItem.Click += new System.EventHandler(this.CMS_OptionButton_Click);
      // 
      // 실행중ToolStripMenuItem
      // 
      this.실행중ToolStripMenuItem.Name = "실행중ToolStripMenuItem";
      this.실행중ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.실행중ToolStripMenuItem.Text = "실행중";
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.종료ToolStripMenuItem.Text = "종료";
      // 
      // TrayForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "TrayForm";
      this.Text = "TrayForm";
      this.CMS_MenuBox.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NotifyIcon Notify;
    private System.Windows.Forms.ContextMenuStrip CMS_MenuBox;
    private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 실행중ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
  }
}