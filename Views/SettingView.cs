using Carriage_SMS_Project.COMMON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carriage_SMS_Project.Views
{
    public partial class SettingView : UserControl
    {

        private MessageLogger messageLogger;

        public SettingView()
        {
            InitializeComponent();


            btnWrite.Click += (sender, e) =>
            {
                CrossThreadSetLogMessage(txtLogger.Text);

            };
        }


        //함수 INI 파일 읽기 함수(섹션 설정)

        #region [함수] INI 파일 읽기 함수(섹션설정)
        public string[] GetIniValue(string Section, string path)
        {
            byte[] ba = new byte[5000];
            uint Flag = GetPrivateProfileSection(Section, ba, 5000, path);
            return Encoding.Default.GetString(ba).Split(new char[1] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
        }
        #endregion

        #region [함수] INI 파일 읽기 함수(섹션,키값설정)
        public string GetIniValue(string Section, string Key, string path)
        {
            StringBuilder sb = new StringBuilder(500);
            int Flag = GetPrivateProfileString(Section, Key, "", sb, 500, path);
            return sb.ToString();
        }
        #endregion

        #region [함수] INI 파일 쓰기 함수(섹션, 키값설정, 값, 저장 주소)
        public bool SetIniValue(string Section, string Key, string Value, string path)
        {
            return (WritePrivateProfileString(Section, Key, Value, path));
        }
        #endregion

        #region [DLL 함수] INI DLL 로드
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32")]
        public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32.dll")]
        public static extern uint GetPrivateProfileSection(string IpAppName, byte[] IpPairValues, uint nSize, string IpFileName);
        [DllImport("kernel32.dll")]
        public static extern uint GetPrivateProfileSectionNames(byte[] IpSections, uint nSize, string IpFileName);
        #endregion

        #region 프로그램 날짜 얻어오기
        public void GetSystemDate(out string outTime)
        {
            outTime = string.Format(DateTime.Now.ToString("yyyy.MM.dd"));
        }
        #endregion

        #region 프로그램 날짜 및 시간 얻어오기
        public void GetSystemTime(out string outTime)
        {
            outTime = string.Format("[" + DateTime.Now.ToString("yyyy.MM.dd") + "_" + DateTime.Now.ToString("HH:mm:ss") + "] ");
        }
        #endregion

        #region listbox1 에 log 출력 및 log 저장
        #region 크로스스레드 에러를 막기 위해 작업
        delegate void CrossThreadSafetySetLogMessage(string inMessage);

        public void CrossThreadSetLogMessage(string inMessage)
        {
            this.Invoke(new CrossThreadSafetySetLogMessage(SetLogMessage), inMessage);
        }
        #endregion

        public void SetLogMessage(string inMessage)
        {
            string LogMessage = "";
            string strTime = "";
            GetSystemTime(out strTime);

            // 입력받은 문자에 날짜와 시간을 붙여서 출력
            LogMessage = string.Format(strTime.ToString() + inMessage.ToString());
            listLoggerBox.Items.Add(LogMessage);

            // 리스트박스는 맨 마지막줄을 항상 선택
            int index = listLoggerBox.Items.Count;
            listLoggerBox.SelectedIndex = index - 1;

            // 리스트박스 버퍼가 1000줄이 넘으면 가장오래된 로그를 한줄 지운다
            if (listLoggerBox.Items.Count > 1000)
            {
                listLoggerBox.Items.RemoveAt(0);
            }

            // 검사 결과를 로그에 추가
            SaveLogFile(LogMessage);
        }
        #endregion

        #region Log Data 저장
        public void SaveLogFile(string inLogMessage)
        {
            // 로그 데이터 파일에 들어갈 날짜 얻어오기
            string strDate;
            GetSystemDate(out strDate);

            // 로그 데이터가 저장될 폴더와 파일명 설정
            string FilePath = "D:\\Test2\\" + strDate + "_Log.txt";
            FileInfo fi = new FileInfo(FilePath);

            // 폴더가 존재하는지 확인하고 존재하지 않으면 폴더부터 생성
            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(FilePath));

            if (dir.Exists == false)
            {
                // 새로 생성합니다.
                dir.Create();
            }

            // 기존 로그 데이터가 존재시 이어쓰고 아니면 새로 생성
            try
            {
                if (fi.Exists != true)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath, true)) // true는 이어쓰기 모드를 나타냄
                    {
                        sw.WriteLine(inLogMessage);
                    }

                }
                else
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {

                        sw.WriteLine(inLogMessage);
                        sw.Close();
                    }
                }
            }
            catch (IOException ex)
            {
                CrossThreadSetLogMessage("파일 작업 중 예외 발생: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                CrossThreadSetLogMessage("파일 접근 권한 부족: " + ex.Message);
            }
            catch (Exception ex)
            {
                CrossThreadSetLogMessage("예외 발생: " + ex.Message);
            }

        }

        #endregion

        private void txtLogger_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtLogger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //로그 출력 및 저장
                CrossThreadSetLogMessage(txtLogger.Text);

                //텍스트 박스 문자열 초기화.
                txtLogger.Text = "";


            }
        }

        private void SettingView_Load(object sender, EventArgs e)
        {

        }
    }

}


   
