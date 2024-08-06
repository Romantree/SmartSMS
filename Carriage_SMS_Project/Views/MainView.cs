using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Styler;
using Carriage_SMS_Project.Views.IViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class MainView : Form, IMainView
    {

        public event EventHandler CloseButtonClicked; //버튼 닫기 이벤트
        private MainUiPresenter _uipresenter;
        private MainPresenter _presenter;
        private PictureBox[] pictureBoxes;

    
        public MainView()
        {

            InitializeComponent();
            _presenter = new MainPresenter(this);
            InitializeUI();//UI 관련 핸들러
            RaiseViewEventHandler();// 뷰 이벤트 핸들러
            TransitionFormEventHandler(); //폼 이동 핸들러
        }


        private void InitializeUI()
        {
            MainViewStyler.Style(this);
  
            _uipresenter = new MainUiPresenter(this);
            InitializePictureBoxArray();
        }

        private void RaiseViewEventHandler()
        {
            UpdateTime(); //메인폼 현재 년도 ,현재 시간
            Timer.Enabled = true; //타이머  
        }


        //ViewEvent 
        public event EventHandler ShowMainView;
        public event EventHandler ShowMainContentView;
        public event EventHandler ShowMessageView;
        public event EventHandler ShowSettingView;
        public event EventHandler ShowOpcView;
        public event EventHandler ShowTagListView;
        public event EventHandler ShowServerView;
        public event EventHandler ExitApplication;


        //*********************************************************************************************************************************************
        //UserControl 메뉴 이벤트 
        private void TransitionFormEventHandler()
        {

            // 화면 전환 버튼 클릭 이벤트 등록
            btnHome.Click += (sender, e) => ShowMainContentView?.Invoke(this, EventArgs.Empty);
            btnMessage.Click += (sender, e) => ShowMessageView?.Invoke(this, EventArgs.Empty);
            btnSetting.Click += (sender, e) => ShowSettingView?.Invoke(this, EventArgs.Empty);
            btnOpc.Click += (sender, e) => ShowOpcView?.Invoke(this, EventArgs.Empty);
            btnServer.Click += (sender, e) => ShowTagListView?.Invoke(this, EventArgs.Empty);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ExitApplication?.Invoke(this, EventArgs.Empty);
                }
            };
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            lblYear.Text = DateTime.Now.ToString("yyyy.MM.dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        //*********************************************************************************************************************************************


        //*********************************************************************************************************************************************
        // Main Picture Menu 버튼 관련 이벤트
        private void InitializePictureBoxArray()
        {
            pictureBoxes = new PictureBox[] { btnHome, btnOpc, btnMessage, btnServer, pictureBox5,
                               pictureBox6, pictureBox7, pictureBox8, pictureBox9, btnSetting, btnClose };

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                AddPictureBoxHandlers(pictureBox);
                pictureBox.Paint += PictureBox_Paint; // Add custom paint handler
            }
        }

        public void AddPictureBoxHandlers(PictureBox pictureBox)
        {
            //pictureBox.MouseEnter += (sender, e) => _uipresenter.PictureBoxMouseEnter(sender as PictureBox);
            //pictureBox.MouseLeave += (sender, e) => _uipresenter.PictureBoxMouseLeave(sender as PictureBox);
        }

        public void SetPictureBoxBorderStyle(PictureBox pictureBox, BorderStyle borderStyle)
        {
            //pictureBox.Tag = pictureBox.BorderStyle; // Save current border style
            //pictureBox.BorderStyle = borderStyle;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            //PictureBox pictureBox = sender as PictureBox;
            //if (pictureBox != null && pictureBox.BorderStyle == BorderStyle.None)
            //{
            //    int borderWidth = 4; // 원하는 테두리 두께 설정
            //    Color borderColor = Color.White; // 원하는 테두리 색상 설정

            //    using (Pen pen = new Pen(borderColor, borderWidth))
            //    {
            //        pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            //        e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, pictureBox.Width - 1, pictureBox.Height - 1));
            //    }
            //}

        }

 


        //*********************************************************************************************************************************************


        //RoundLabel 컨트롤에 대한 코드 
        //private void MainView_Load(object sender, EventArgs e)
        //{
        //   
        //    //Panel border
        //    //panel3.isBorders = false;
        //    //panel3.isFill = true;
        //    //panel3.radius = 30;
        //    //panel3.fillColor = Color.BlueViolet;

        //    //panel4.isBorder = false;
        //    //panel4.isFill = true;
        //    //panel4.radius = 30;
        //    //panel4.fillColor = Color.Black;


        //    //roundLabel2.borderWidth = 2;
        //    //roundLabel2.borderColor = Color.Red;
        //    //roundLabel2.backColor = Color.LightYellow;

        //    //roundLabel3.borderColor = Color.LightGreen;
        //    //roundLabel3.backColor = Color.LightGreen;

        //    //roundLabel4.isFillLeftTop = true;
        //    //roundLabel4.isFillRightTop = true;
        //    //roundLabel4.isFillLeftBtm = true;
        //    //roundLabel4.isFillRightBtm = true;
        //    //roundLabel4.borderColor = Color.DarkBlue;
        //    //roundLabel4.backColor = Color.LightBlue;

        //    //roundLabel5.cornerRadius = 30;
        //    //roundLabel5.isFillLeftBtm = true;
        //    //roundLabel5.isFillRightBtm = true;
        //    //roundLabel5.borderWidth = 2;
        //    //roundLabel5.borderColor = Color.DarkCyan;
        //    //roundLabel5.backColor = Color.AntiqueWhite;

        //    //roundLabel6.cornerRadius = 30;
        //    //roundLabel6.isFillRightTop = true;
        //    //roundLabel6.isFillRightBtm = true;
        //    //roundLabel6.borderColor = Color.DarkKhaki;
        //    //roundLabel6.backColor = Color.LightCoral;

        //    //roundLabel7.cornerRadius = 50;

        //    //roundLabel8.cornerRadius = 30;
        //    //roundLabel8.borderColor = Color.Black;
        //    //roundLabel8.backColor = Color.Transparent;

        //    //roundLabel9.cornerRadius = 30;
        //    //roundLabel9.borderColor = Color.Transparent;
        //    //roundLabel9.backColor = Color.Transparent;
        //}



        //델리게이트 프레임관련   일단 생략
        //private void AssociateAndRaiseViewEvents()
        //{

        //    btnServer.Click += (sender, e) =>
        //    {
        //        // ListView UserControl을 생성
        //        if (listViewControl == null)
        //        {
        //            listViewControl = new ListView();

        //            // 필요한 설정이 있다면 여기에 추가
        //        }

        //        // ListView를 패널에 추가
        //        if (!MainPanel.Contains(listViewControl))
        //        {
        //            listViewControl.Dock = DockStyle.Fill;
        //            MainPanel.Controls.Add(listViewControl);
        //        }
        //        listViewControl.BringToFront();
        //    };

        //    btnMessage.Click += (sender, e) =>
        //    {
        //        if (messageViewControl == null)
        //        {
        //            messageViewControl = new MessageView();
        //        }
        //        if (!MainPanel.Contains(messageViewControl))
        //        {
        //            messageViewControl.Dock = DockStyle.Fill;
        //            MainPanel.Controls.Add(messageViewControl);
        //        }
        //        messageViewControl.BringToFront();
        //    };
        //    btnSetting.Click += (sender, e) =>
        //    {
        //        if (settingViewControl == null)
        //        {
        //            settingViewControl = new SettingView();
        //        }
        //        if (!MainPanel.Contains(settingViewControl))
        //        {
        //            settingViewControl.Dock = DockStyle.Fill;
        //            MainPanel.Controls.Add(settingViewControl);
        //        }
        //        settingViewControl.BringToFront();
        //    };
        //    btnServer.Click += (sender, e) =>
        //    {
        //        if (opcViewControl == null)
        //        {
        //            opcViewControl = new OpcView();
        //        }
        //        if (!MainPanel.Contains(opcViewControl))
        //        {
        //            opcViewControl.Dock = DockStyle.Fill;
        //            MainPanel.Controls.Add(opcViewControl);
        //        }
        //        opcViewControl.BringToFront();
        //    };

        //}








    }
    }
