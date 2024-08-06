using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Styler;
using Carriage_SMS_Project.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Carriage_SMS_Project.Views
{
    public partial class MainView : Form, IMainView

    {

        public event EventHandler CloseButtonClicked; //버튼 닫기 이벤트
        private MainUiPresenter _uipresenter;
        private MainPresenter _presenter;
        private Timer timer;
        ExitView exitView;


        //ViewEvent 
        public event EventHandler ShowMainView;
        public event EventHandler ShowMainContentView;
        public event EventHandler ShowMessageView;
        public event EventHandler ShowSettingView;
        public event EventHandler ShowOpcListView;
        public event EventHandler ShowServerView;
        public event EventHandler ShowCloseView;
        public event EventHandler ShowRealtimeView;


        public event EventHandler ExitApplication;

        public MainView()
        {
            InitializeComponent();
            _presenter = new MainPresenter(this);
            _uipresenter = new MainUiPresenter(this);
            MainViewStyler.Style(this);

            Time();// 뷰 이벤트 핸들러
            TransitionFormEventHandler(); //폼 이동 핸들러
            Ship(); //배 애니메이션 폼 

        }
        private void Time()
        {
            UpdateTime(); //메인폼 현재 년도 ,현재 시간
            Timer.Enabled = true; //타이머  
        }
    //*********************************************************************************************************************************************
    //UserControl 메뉴 이벤트 
    private void TransitionFormEventHandler()
        {

            // 화면 전환 버튼 클릭 이벤트 등록
            btnHome.Click += (sender, e) => ShowMainContentView?.Invoke(this, EventArgs.Empty);
            _btnHome.Click += (sender, e) => ShowMainContentView?.Invoke(this, EventArgs.Empty);

            btnMessage.Click += (sender, e) => ShowMessageView?.Invoke(this, EventArgs.Empty);
            _btnMessage.Click += (sender, e) => ShowMessageView?.Invoke(this, EventArgs.Empty);

            btnOpc.Click += (sender, e) => ShowOpcListView?.Invoke(this, EventArgs.Empty);
            _btnOpc.Click += (sender, e) => ShowOpcListView?.Invoke(this, EventArgs.Empty);


            btnServer.Click += (sender, e) => ShowServerView?.Invoke(this, EventArgs.Empty);
            _btnServer.Click += (sender, e) => ShowServerView?.Invoke(this, EventArgs.Empty);

            btnSetting.Click += (sender, e) => ShowSettingView?.Invoke(this, EventArgs.Empty);
            _btnSetting.Click += (sender, e) => ShowSettingView?.Invoke(this, EventArgs.Empty);


            btnRealtime.Click += (sender, e) => ShowRealtimeView?.Invoke(this, EventArgs.Empty);
            btnRealtime.Click += (sender, e) => ShowRealtimeView?.Invoke(this, EventArgs.Empty);

            btnClose.Cursor = Cursors.Hand;

            btnClose.Click += (sender, e) =>
            {
                if (exitView == null || exitView.IsDisposed)
                {
                    exitView = new ExitView();
                    exitView.StartPosition = FormStartPosition.CenterScreen;
                    exitView.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                }

                // exitView가 보이지 않는 경우 앞으로 가져오고 보이게 함
                if (!exitView.Visible)
                {
                    exitView.StartPosition = FormStartPosition.CenterScreen;
                    exitView.BringToFront();
                    exitView.Show();
                }
            };
            btnMinimize.Click += (sender, e) =>
            {
                this.WindowState = FormWindowState.Minimized;
            };

            //btnClose.Click += (sender, e) =>
            //{
            //    DialogResult result = MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        ExitApplication?.Invoke(this, EventArgs.Empty);
            //    }
            //};
            //btnClose.Click += delegate { this.Close(); };  //창 닫기.

        }
        private void ShowMainUserControl()
        {
            MainContentView mainContent = new MainContentView();
            mainContent.Dock = DockStyle.Fill;
            // 현재 패널에 표시된 컨트롤 제거
            pMain.Controls.Clear();
            // pMain 패널에 컨트롤 추가
            pMain.Controls.Add(mainContent);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowMainUserControl();
        }
        public void ShowView(Control control)
        {
            // pMain 패널의 크기를 화면에 맞게 조정
            control.Dock = DockStyle.Fill;
            // 현재 패널에 표시된 컨트롤 제거
            pMain.Controls.Clear();
            // pMain 패널에 컨트롤 추가
            pMain.Controls.Add(control);
        }
        //*********************************************************************************************************************************************

        //*********************************************************************************************************************************************

        // 현재 시간 
        [DebuggerStepThrough]
        private void Timer_Tick_1(object sender, EventArgs e)
        {
            UpdateTime();
        }

        [DebuggerStepThrough]
        private void UpdateTime()
        {
            lblYear.Text = DateTime.Now.ToString("yyyy.MM.dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //*********************************************************************************************************************************************


        //*********************************************************************************************************************************************

         //FormBorder Style  설정 및 Form 위치 이동 설정 코드
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        [DebuggerStepThrough]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HT_CAPTION)
                m.Result = (IntPtr)2;
        }

        [DebuggerStepThrough]
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        //*********************************************************************************************************************************************
        private PictureBox pictureBox;
        private Bitmap image;
        private int xPosition;
        private int xSpeed;
        private bool isFlipped;

        [DebuggerStepThrough]
        public void Ship()
        {
            image = new Bitmap(Properties.Resources.ship);

            // PictureBox 설정
            pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Location = new Point(xPosition, 695); // 초기 위치 설정
            this.Controls.Add(pictureBox);

            // 타이머 설정
            Timer2.Interval = 50;
            Timer2.Tick += new EventHandler(Timer2_Tick);
            Timer2.Start();

            // 초기 위치 설정
            xPosition = 1006;
            xSpeed = 5; // 속도.
            isFlipped = true; //  상태

        }
        [DebuggerStepThrough]
        private void Timer2_Tick(object sender, EventArgs e)
        {
            xPosition += xSpeed;

            // 경계 조건 확인 및 방향 전환 및 이미지 반전
            if (xPosition <= 0 || xPosition + pictureBox.Width >= this.ClientSize.Width)
            {
                xSpeed = -xSpeed;

                // 이미지 반전 방향을 xSpeed에 맞춰 조정
                if ((xSpeed < 0 && !isFlipped) || (xSpeed > 0 && isFlipped))
                {
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pictureBox.Image = image;
                    isFlipped = !isFlipped;
                }
            }

            // 이미지 위치 업데이트
            pictureBox.Location = new Point(xPosition, pictureBox.Location.Y);
        }

  
    }
}
//*********************************************************************************************************************************************





