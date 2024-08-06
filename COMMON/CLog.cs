using Carriage_SMS_Project.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.COMMON
{





    public class CLog
    {

   

        public Queue<TLogMsgInfo> LogQueue = new Queue<TLogMsgInfo>();
        public enum EMoveMethod : uint
        {
            Begin = 0,
            Current = 1,
            End = 2
        }

        public const int MAX_LOG_CNT = 100;


        string _FsLogDir;
        int _FnIndex;


        const int FILE_SHARE_READ = 0x00000001;
        const uint GENERIC_WRITE = 0x40000000;
        const uint GENERIC_READ = 0x80000000;

        const int CREATE_NEW = 1;
        const int CREATE_ALWAYS = 2;
        const int OPEN_EXISTING = 3;
        const int OPEN_ALWAYS = 4;
        IntPtr FLogHandle;

        [DllImport("kernel32")]
        static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);
        [DllImport("kernel32")]
        static extern IntPtr WriteFile(IntPtr hObject, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);
        //static extern IntPtr WriteFile(IntPtr hObject, string l pBuffer, int nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);
        [DllImport("kernel32")]
        static extern void CloseHandle(IntPtr hObject);
        [DllImport("kernel32")]
        static extern void SetFilePointerEx(IntPtr hObject, long lDistanceToMove, int lpDistanceToMoveHigh, EMoveMethod dwMoveMethod);

        //---------------------------------------------------------------------------
        public CLog(string sLogDir, int nIndex)
        {
            // 생성자
            ClearLogQueue();

            _FsLogDir = sLogDir;
            _FnIndex = nIndex;

            MakeNewLogFile();
        }
        public void MakeNewLogFile()
        {
            string sTime;
            string sFile = "";

            if (FLogHandle != null)
                CloseHandle(FLogHandle);

            sTime = DateTime.Now.ToString("yyyy-MM-dd");
            if (_FnIndex == 0)
                sFile = "SysLog_" + sTime + ".LOG";
            else if (_FnIndex == 1)
                sFile = "Tracking_" + sTime + ".LOG";
            else if (_FnIndex == 2)
                sFile = "Schedule_" + sTime + ".LOG";
            else if (_FnIndex == 3)
                sFile = "InterfaceMES_" + sTime + ".LOG";
            else if (_FnIndex == 4)
                sFile = "OpcLink1_" + sTime + ".LOG";
            else if (_FnIndex == 5)
                sFile = "OpcLink2_" + sTime + ".LOG";
            else if (_FnIndex == 6)
                sFile = "DataGathering_" + sTime + ".LOG";
            else if (_FnIndex == 7)
                sFile = "DataLogging_" + sTime + ".LOG";
            else if (_FnIndex == 8)
                sFile = "RecipeGathering_" + sTime + ".LOG";

            sFile = _FsLogDir + sFile;

            FileInfo fi = new FileInfo(sFile);
            if (fi.Exists)
                FLogHandle = CreateFile(@sFile, GENERIC_WRITE, FILE_SHARE_READ, IntPtr.Zero, OPEN_EXISTING, (uint)System.IO.FileAttributes.Normal, IntPtr.Zero);
            else
                FLogHandle = CreateFile(@sFile, GENERIC_WRITE, FILE_SHARE_READ, IntPtr.Zero, CREATE_NEW, (uint)System.IO.FileAttributes.Normal, IntPtr.Zero);

            if (FLogHandle == IntPtr.Zero)
                MessageBox.Show("Invalid File Handle!!!");//ShowMsg("Invalid File Handle!!!");
            else
                SetFilePointerEx(FLogHandle, 0, 0, EMoveMethod.End);
        }
        public void ClearLogQueue()
        {
            LogQueue.Clear();
        }

        public void AddEventLog(string sLogMsg/*, bool bDbLog = false, int nKind = 0, int nProduct = 0, TErrTime ErrTm = null*/)
        {
            TLogMsgInfo LogMsg = new TLogMsgInfo(sLogMsg);
            //if (ErrTm != null)
            //{
            //    LogMsg.FdtTime = ErrTm.FdtStart;
            //    LogMsg.FdtReset = ErrTm.FdtReset;
            //}
            string sSaveLog = GetLogCommaStr(LogMsg) + "\r\n";
            AddLogToFile(sSaveLog);

            LogQueue.Enqueue(LogMsg);
            while (LogQueue.Count() > MAX_LOG_CNT)
            {
                LogQueue.Dequeue();
            }
        }
        //---------------------------------------------------------------------------
        public void AddLogToFile(string sLog)
        {
            uint lpNumberOfBytesWritten = 0;
            byte[] bytes = Encoding.Default.GetBytes(sLog);
            uint bytesLen = (uint)bytes.Length;

            WriteFile(FLogHandle, bytes, bytesLen, out lpNumberOfBytesWritten, IntPtr.Zero);
        }

        //---------------------------------------------------------------------------
        public string GetLogCommaStr(TLogMsgInfo LogMsg)
        {
            try
            {// 날짜 및 시간을 구함 ( msec 까지 )
                string sTime = LogMsg.FdtTime.ToString("yyyy-MM-dd HH:mm:ss");

                string sBuf;
                //sBuf = "\"" + sTime + "\"" + ", ";
                sBuf = string.Format("\"{0:g}\", ", sTime);
                //----------------------------------------------------------------------------
                string sLog = sBuf + "\"" + LogMsg.FsLogMsg + "\"";
                //----------------------------------------------------------------------------
                return sLog;
            }
            catch (Exception ex)
            {
                string sMsg = ex.Message;

                return "";
            }
        }
        public class TLogMsgInfo
        {
            public TLogMsgInfo(string sLogMsg)
            {
                this.FdtTime = DateTime.Now;
                this.FsLogMsg = sLogMsg;
            }

            public string FsLogMsg;
            public DateTime FdtTime;
        };

    }

}
