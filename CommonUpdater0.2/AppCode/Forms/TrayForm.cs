using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUpdater.AppCode.Forms
{
  public partial class TrayForm : Form
  {
    // 이렇게 하면 프로그램 목록에 보이지 않게 됨
    protected override CreateParams CreateParams { get { CreateParams CP = base.CreateParams; CP.ExStyle |= 0x80; return CP; } }

    // 속성에서 show in trackbar 를 fasle 로 두고
    // 도구에서 NotifyIcon 을 활성화 시키면 트레이에서만 활동을 하는 폼을 사용 할 수 있다.
    // NotifyIcon 에서 ContextMenuStrip 을 서로 연결 시켜야 오른쪽 클릭 했을 때 연동이 된다.
    public TrayForm ( )
    {
      InitializeComponent( );

      IntervalTimerInit( );

      OptionItem.Click += ( s, e ) => { ( new OptionForm( ) ).Show( ); };
      CloseItem.Click += ( s, e ) => { this.Close( ); };
    }

    private DateTime NextCheckTime;

    private void IntervalTimerInit ( )
    {
      Timer CheckTimer = new Timer( );
      CheckTimer.Interval = 1800000;
      CheckTimer.Tick += CheckTimer_F;
      CheckTimer_F( this, new EventArgs( ) );
      CheckTimer.Start( );

      Timer TimeChecker = new Timer( );
      TimeChecker.Interval = 100;
      TimeChecker.Tick += ( s, e ) => {
        TimeItem.Text = "Next : " + ( NextCheckTime - DateTime.Now ).ToString( @"mm\:ss\.ffff" );
      };
      TimeChecker.Start( );
    }

    private void CheckTimer_F ( object sender, EventArgs e )
    {
      NextCheckTime = DateTime.Now.AddMinutes( 30 );
      // 일단 이렇게만
    }
  }
}