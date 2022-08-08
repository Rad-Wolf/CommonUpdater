namespace CommonUpdater.AppCode.Forms
{
  partial class TrayForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayForm));
      this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.CMS_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.OptionItem = new System.Windows.Forms.ToolStripMenuItem();
      this.TimeItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
      this.CMS_Menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // NotifyIcon
      // 
      this.NotifyIcon.ContextMenuStrip = this.CMS_Menu;
      this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
      this.NotifyIcon.Text = "NotifyIcon";
      this.NotifyIcon.Visible = true;
      // 
      // CMS_Menu
      // 
      this.CMS_Menu.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.CMS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionItem,
            this.TimeItem,
            this.CloseItem});
      this.CMS_Menu.Name = "CMS_Menu";
      this.CMS_Menu.Size = new System.Drawing.Size(131, 70);
      // 
      // OptionItem
      // 
      this.OptionItem.Name = "OptionItem";
      this.OptionItem.Size = new System.Drawing.Size(130, 22);
      this.OptionItem.Text = "옵션";
      // 
      // TimeItem
      // 
      this.TimeItem.Name = "TimeItem";
      this.TimeItem.Size = new System.Drawing.Size(130, 22);
      this.TimeItem.Text = "다음 시간";
      // 
      // CloseItem
      // 
      this.CloseItem.Name = "CloseItem";
      this.CloseItem.Size = new System.Drawing.Size(130, 22);
      this.CloseItem.Text = "종료";
      // 
      // TrayForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CausesValidation = false;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TrayForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.CMS_Menu.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NotifyIcon NotifyIcon;
    private System.Windows.Forms.ContextMenuStrip CMS_Menu;
    private System.Windows.Forms.ToolStripMenuItem OptionItem;
    private System.Windows.Forms.ToolStripMenuItem TimeItem;
    private System.Windows.Forms.ToolStripMenuItem CloseItem;
  }
}

