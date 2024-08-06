using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Views;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.COMMON
{
     class PublicUtils : Singleton<PublicUtils>
    {
 



        public string gsDataDir;
        public string gsLogDir;
        public string gsLogTempDir;
        public string gsOpcLink1Dir;
        public string gsDataLoggingDir;

        public static IntPtr hWnd;


        public CLog SystemLog = null;
        public CLog TrackingLog = null;
        public CLog ScheduleLog = null;
        public CLog InferfaceMesLog = null;
        public CLog OpcLink1Log = null;
        public CLog OpcLink2Log = null;
        public CLog DataGatheringLog = null;
        public CLog DataLoggingLog = null;
        public CLog RecipeGatheringLog = null;


        public OpcListView OpcListView = null;

        public int OpcTagGetIndex(string sTagName)
        {
            int nIndex = -1;

            for (int i = 0; i < Global.Instance.List_Opc.Count; i++)
            {
                if (sTagName == Global.Instance.List_Opc[i].Name)
                {
                    return i;
                }
            }

            return nIndex;
        }


        public void SetSysPath(OpcListView pParent)
        {
            string sPath;
            bool bDExist = false;
            bool bNotCD = false;

            OpcListView = pParent;
            hWnd = OpcListView.Handle;

            DriveInfo[] drv = DriveInfo.GetDrives();

            foreach (DriveInfo d in drv)
            {
                if (d.Name == "D:\\")
                {
                    bDExist = true;
                    if ((d.DriveType == DriveType.Fixed) && (d.DriveType != DriveType.CDRom))
                        bNotCD = true;
                }
            }

            if (bDExist && bNotCD)
                sPath = "D:\\System_Data";
            else
                sPath = System.IO.Directory.GetCurrentDirectory();

            gsDataDir = sPath + "\\DATA\\";
            gsLogDir = sPath + "\\LOG\\" + "\\SYSTEM\\";
            gsLogTempDir = sPath + "\\LOG\\";

            try
            {
                // Data Directory Create
                DirectoryInfo di = new DirectoryInfo(gsDataDir);
                if (di.Exists == false)
                {
                    di.Create();
                }

                // Log Directory Create
                di = new DirectoryInfo(gsLogDir);
                if (di.Exists == false)
                {
                    di.Create();
                }

         
                // Opc Link1 Directory Create
                gsOpcLink1Dir = gsLogTempDir + "\\OPCLINK_1\\";
                di = new DirectoryInfo(gsOpcLink1Dir);
                if (di.Exists == false)
                {
                    di.Create();
                }
                // Opc Link2 Directory Create
      
                // DataLogging Directory Create
                gsDataLoggingDir = gsLogTempDir + "\\DATA_LOGGING\\";
                di = new DirectoryInfo(gsDataLoggingDir);
                if (di.Exists == false)
                {
                    di.Create();
                }
     
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //MakeNewLogFile();

            // LOG FILE CREATE
            SystemLog = new CLog(gsLogDir, 0);
            OpcLink1Log = new CLog(gsOpcLink1Dir, 1);
            DataLoggingLog = new CLog(gsDataLoggingDir, 2);
            //
        }
    }
}
