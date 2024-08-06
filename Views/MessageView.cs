using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using SMS_Sender.kr.co.hhi.officeeai;
using Newtonsoft.Json.Linq;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Carriage_SMS_Project.Models;
using System.Data.SqlClient;
using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Repositories;
using Carriage_SMS_Project.Styler;
using Carriage_SMS_Project.Views.IViews;

namespace Carriage_SMS_Project.Views
{


    public partial class MessageView : UserControl, IMessageView
    {

        public delegate void ChildFormSendDataHandler(string message);
        public event ChildFormSendDataHandler ChildFormEvent;
        private IConfiguration Configuration;  //IConfiguration 인터페이스 설정 로드 및 저장용
                                               // ****************************************************************************

        string Line = "";
        private List<string> EmployeeList = new List<string>();
        string[] RecvPerson = new string[2]; //전송 받을 직원
        List<string[]> RecvPersonList = new List<string[]>(); //2차원 동적 배열 생성
        Int32 RecvNumbers = 0;
        StringBuilder logtext = new StringBuilder();
        DateTime StartTime = DateTime.Now;


        private MessageModel messageModel;
        private MessagePresenter messagePresenter;
        private MessageRepository messageRepository;
        MessageViewStyler messageViewStyler;
        _TagListView _tagListView;

        public MessageView()
        {

            InitializeComponent();
            messageRepository= new MessageRepository();

            btnUpdate.Click += (sender, e) =>
            {
                messagePresenter.UpdateMessages(dataGridView);

            };


            btnTagList.Click += (sender, e) =>
            {
                if (_tagListView == null || _tagListView.IsDisposed)
                {
                    _tagListView = new _TagListView();
                    _tagListView.StartPosition = FormStartPosition.CenterScreen;
                    _tagListView.FormBorderStyle = FormBorderStyle.None;
                }
                _tagListView.Show();
            };
            dataGridView.RowHeadersVisible = false;
        }


        private void MessageView_Load(object sender, EventArgs e)
        {
            messagePresenter = new MessagePresenter(this, new MessageRepository());
            MessageViewStyler.InitMessageViewStyler(dataGridView, messagePresenter);
            
            messagePresenter.LoadData();




        }

  
        public void ShowUpdateCompleteMessage()
        {
            MessageBox.Show("업데이트 완료");
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show("오류 발생: " + message);
        }

        public void LoadComboBoxItems(DataGridViewComboBoxColumn comboBoxColumn, string columnName)
        {
            messagePresenter.LoadComboBoxItems(comboBoxColumn, columnName);
        }
    


    public void MessageUserList(List<MessageModel> messageModel)
        {
            //dataGridView1.DataSource = userModel != null ? new BindingList<UserModel>(userModel) : new BindingList<UserModel>();
            dataGridView.DataSource = new BindingList<MessageModel>(messageModel);
        }


        public int UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserCheck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UserName3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }






        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnSetting.Enabled = false;

            // 받는 사람 파일 읽기
            string filePath = Path.Combine(Application.StartupPath, "SMS_RecvList.txt");
            string[] RecvListValue = File.ReadAllLines(filePath, Encoding.Default);

            if (RecvListValue.Length > 0)
            {
                for (int i = 0; i < RecvListValue.Length; i++)
                {
                    if (i == 0) // 받는 사람
                    {
                        string recvNumberStr = Regex.Replace(RecvListValue[i], @"\D", "");
                        if (int.TryParse(recvNumberStr, out int recvNumber))
                        {
                            RecvNumbers = recvNumber;
                            Console.WriteLine(RecvNumbers);
                        }
                        else
                        {
                            MessageBox.Show("받는 사람 번호 형식이 잘못되었습니다.");
                            return;
                        }
                    }
                    else
                    {
                        if (RecvListValue[i].Contains("="))
                        {
                            break;
                        }
                        RecvPerson = RecvListValue[i].Split(',');
                        RecvPersonList.Add(RecvPerson);
                    }
                }
            }

            // 스케쥴 간격을 설정
            if (EmployeeList.Count > 0)
            {
                if (int.TryParse(EmployeeList[0], out int interval))
                {
                    tmStart.Interval = interval * 1000;
                    tmStart.Start(); // 타이머를 발동시킨다.
                    tmStart.Tick += timer1_Tick; //타이머 완로 휴 버튼 다시 활성화
                    Console.WriteLine(interval);
                }
                else
                {
                    MessageBox.Show("스케쥴 간격 형식이 잘못되었습니다.");
                    btnStart.Enabled = true;    
                }
            }
            else
            {
                MessageBox.Show("EmployeeList가 비어 있습니다.");
                btnStart.Enabled = true;
            }
        }
    


private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan ts;
            ts = now - StartTime;
            txtSendNumBox.Text = ts.Days.ToString() + 'd' + ts.Hours.ToString() + ':' + ts.Minutes.ToString();

            //FileInfo생성
            FileInfo fi = new FileInfo(EmployeeList[4]);
            //FileInfo.Exists로 파일 존재유무 확인 "
            if (fi.Exists)
            {
                string[] textValue = System.IO.File.ReadAllLines(EmployeeList[4], Encoding.UTF8); //Encoding.Default UTF-8을 기본으로 사용함
                if (textValue.Length > 0)
                {
                    for (int i = 0; i < textValue.Length; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < RecvNumbers; j++)   // 
                            {
                                // 푸시알림 Request Class 선언
                                Ora_Push_REQ_TALK320 request = new Ora_Push_REQ_TALK320();
                                // 푸시알림 데이터를 Request 변수에 할당
                                request.SEND_SABUN = EmployeeList[2];
                                request.RCV_SABUN = RecvPersonList[j][1];
                                // request.RCV_ORG = "CF10"; // 조직코드 - 이거 절대 쓰지 말자

                                request.TITLE = "모형시험 알림";
                                request.CONTENT = textValue[i];
                                request.SMS_GUBUN = "B"; // 푸시 실패시 문자 전송(단문 : B, 장문 : L)
                                request.SYS_TYPE = "185";
                                request.FROM_SYS = "예인수조";
                                // 푸시알림 Response Class 선언
                                Ora_Push_RSP response = new Ora_Push_RSP();
                                // 푸시알림 WebService 선언
                                HHI_WebService service = new HHI_WebService();
                                // 푸시알림 메소드 호출
                                //response = service.Send_Push_Ora(request);
                                // Response 확인
                                string sStatus = response.STATUS;
                                string sDescription = response.DESCRIPTION;
                                string sError = response.ERROR;


                                string thisLog = string.Format("{0}/Stat:{1}/{2}", RecvPersonList[j][0], sStatus, textValue[i]);
                                logtext.AppendLine(thisLog);
                                LogFile(thisLog);


                                Delay(2000);
                            }
                        }
                    }
                    // Delete a file by using File class static method...
                    if (System.IO.File.Exists(EmployeeList[4]))
                    {
                        // Use a try block to catch IOExceptions, to
                        // handle the case of the file already being
                        // opened by another process.
                        try
                        {
                            System.IO.File.Delete(EmployeeList[4]);
                        }
                        catch (System.IO.IOException exce)
                        {
                            Console.WriteLine(exce.Message);
                            return;
                        }
                    }
                }
            }
        }
        public void LogFile(String msg)

        {
            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
            string DirPath = Directory.GetCurrentDirectory() + @"\Logs";
            string temp;

            DirectoryInfo di = new DirectoryInfo(DirPath);
            FileInfo fi = new FileInfo(FilePath);
            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);
                if (fi.Exists != true)

                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        //temp = string.Format("[{0}] {1}", GetDateTime(), msg);
                        temp = msg;
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
                else

                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {

                        //temp = string.Format("[{0}] {2} - {1}", GetDateTime(), this.TargetKey, msg);
                        temp = msg;
                        sw.WriteLine(temp);
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
            }

        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
      
        }

        private void MessageView_ChildFormEvent(string str)
        {     
                Line = str.ToString();
                EmployeeList = Line.Split(',').ToList();
          
        }

        private void btnRecvList_Click(object sender, EventArgs e)
        {

            string programPath = Application.ExecutablePath; // 실행 파일 경로
            string folderPath = Path.GetDirectoryName(programPath); // 실행 파일이 있는 폴더 경로S
            string txtFilePath = Path.Combine(folderPath, "SMS_RecvList.txt");

            if (File.Exists(txtFilePath))
            {
                try
                {
                    Process.Start(txtFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("파일 실행 중 오류 발생: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("파일을 찾을 수 없습니다.");
            }

        }



        private void btnSet_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            List<string> setList = new List<string>
            {
                numericDelay.Value.ToString(),
                personBox.Text,
        
            };
        }
        private void SaveConfiguration()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
            var json = File.ReadAllText(filePath);
            var jsonObj = JObject.Parse(json);

            jsonObj["TI"] = numericDelay.Value.ToString();
            jsonObj["person"] = personBox.Text;
          

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, output);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            numericDelay.Value = 0;
            personBox.Text = "";
  
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            messagePresenter.UpdateMessages(dataGridView);

        }
        //strip 코드
        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Rectangle rect = this.dataGridView.GetColumnDisplayRectangle(e.ColumnIndex, true);
                this.contextMenuStrip1.Items.Clear();
                this.contextMenuStrip1.Items.Add(this.dataGridView.Columns[e.ColumnIndex].HeaderText);
                this.contextMenuStrip1.Items.Add("설정");
                this.contextMenuStrip1.Items.Add("삭제");
                this.contextMenuStrip1.Items.Add("-");
                this.contextMenuStrip1.Items.Add("이동");
                this.contextMenuStrip1.Items.Add("수정");
                Point p = new Point(rect.X, this.dataGridView.ColumnHeadersHeight);
                this.contextMenuStrip1.Show(this.dataGridView.PointToScreen(p));


            }
        }
    }

    
    }


