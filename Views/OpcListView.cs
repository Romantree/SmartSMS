using Carriage_SMS_Project.COMMON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class OpcListView : UserControl
    {
  

        public bool bOpcLink1Open;
        //
        public Thread RunThreadOpc1;

        static DateTime tmDay = DateTime.Now;

        public System.Threading.Timer OpcLink1OpenTmr;

        private int _FnTrendUpdate;


        delegate void TimerEventFiredDelegate();


        public void OpcLinkTimerStart()
        {
            //// 최초 한번만 실행
            OpcLink1OpenTmr = new System.Threading.Timer(OpcLink1CallBack);
            //OpcLink1OpenTmr.Change(0, 1000);	// (대기시간, 반복주기)
            ////
        }
        public void OpcLink1CallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate(OpcLink1Open));
        }
        //----------------------------------------------------------------------
        public OpcListView()
        {
            InitializeComponent();

            //PublicUtils.Instance.OpcLink1Log.AddEventLog("OPC_LInk ");
            //PublicUtils.Instance.DataLoggingLog.AddEventLog("Data Logging ");

        }

        private void CheckLogDate()
        {
            DateTime tmNowDay = DateTime.Now;

            if (tmDay.Day != tmNowDay.Day)
            {
                PublicUtils.Instance.OpcLink1Log.MakeNewLogFile();
                PublicUtils.Instance.OpcLink2Log.MakeNewLogFile();
                PublicUtils.Instance.DataGatheringLog.MakeNewLogFile();
                PublicUtils.Instance.DataLoggingLog.MakeNewLogFile();
                PublicUtils.Instance.RecipeGatheringLog.MakeNewLogFile();

                tmDay = DateTime.Now;
            }
    
        }

        private void tmLog_Tick(object sender, EventArgs e)
        {
            CheckLogDate();

            UpdateOpcLink1View();
            UpdateDataLoggingView();
        }
        private void tmDataLogging_Tick(object sender, EventArgs e)
        {
            string sMsg = "";
            tmDataLogging.Stop();

     
            // Data Logging(Trend)
            _FnTrendUpdate++;
            if (_FnTrendUpdate >= 10)
            {
                sMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                _FnTrendUpdate = 0;
            }
            //
            tmDataLogging.Start();
        }
        //----------------------------------------------------------------------
        private void tm1Sec_Tick(object sender, EventArgs e)
        {
            if (Global.Instance.OpcLink1 != null)
            {
                if (Global.Instance.OpcLink1.IsServerNullCheck())
                {
                    if (Global.Instance.OpcLink1.IsServerConnected()) ;
                }
            }
        }

        public void LoggingInit()
        { 

            tmLog.Enabled = true;
            tm1Sec.Enabled = true;
            tmDataLogging.Enabled = true;

            _FnTrendUpdate = 0;
        }
        private void OpcLink1Open()
        {
            if (bOpcLink1Open)
                OpcLinkConn1();
        }
        public void CloseFrame()
        {
            // Timer Thread 중지(무한대 값을 주어서 실행되지 않도록)
            if (OpcLink1OpenTmr != null)
                OpcLink1OpenTmr.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            //

            if (Global.Instance.OpcLink1.IsServerState())
            {
                Global.Instance.OpcLink1.OpcDisconnect();
            }
        }
        private void UpdateOpcLink1View()
        {
            string sLog = "";

            if (PublicUtils.Instance.OpcLink1Log.LogQueue.Count > 0)
            {
                while (PublicUtils.Instance.OpcLink1Log.LogQueue.Count > 0)
                {
                    sLog = PublicUtils.Instance.OpcLink1Log.GetLogCommaStr(PublicUtils.Instance.OpcLink1Log.LogQueue.Peek());

                    listOpcLog1.Items.Add(sLog);

                    PublicUtils.Instance.OpcLink1Log.LogQueue.Dequeue();
                }

                while (listOpcLog1.Items.Count > Common.MAX_LOG_CNT)
                {
                    listOpcLog1.Items.RemoveAt(0);
                }

                if (listOpcLog1.Items.Count >= 0)
                {
                    listOpcLog1.TopIndex = listOpcLog1.Items.Count - 1;
                }
                listOpcLog1.SelectedIndex = -1;
            }
        }
        private void UpdateDataLoggingView()
        {
            string sLog = "";

            if (PublicUtils.Instance.DataLoggingLog.LogQueue.Count > 0)
            {
                while (PublicUtils.Instance.DataLoggingLog.LogQueue.Count > 0)
                {
                    sLog = PublicUtils.Instance.DataLoggingLog.GetLogCommaStr(PublicUtils.Instance.DataLoggingLog.LogQueue.Peek());

                    DataLoggingLog.Items.Add(sLog);

                    PublicUtils.Instance.DataLoggingLog.LogQueue.Dequeue();
                }

                while (DataLoggingLog.Items.Count > Common.MAX_LOG_CNT)
                {
                    DataLoggingLog.Items.RemoveAt(0);
                }

                if (DataLoggingLog.Items.Count >= 0)
                {
                    DataLoggingLog.TopIndex = DataLoggingLog.Items.Count - 1;
                }
                DataLoggingLog.SelectedIndex = -1;
            }
        }
        public bool OpcLinkConn1()
        {
            string sMsg = "";

            try
            {
                if (Global.Instance.OpcLink1 != null)
                {
                    if (Global.Instance.OpcLink1.OpcConnect())
                    {
                        Global.Instance.bFirstRun1 = true;
                        PublicUtils.Instance.OpcLink1Log.AddEventLog("Opc_Link 1 Connect Success");
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                sMsg = "OPC Server connect failed with exception" + ex.Message;
                PublicUtils.Instance.OpcLink1Log.AddEventLog(sMsg);
                return false;
            }
        }

    
    }
}
