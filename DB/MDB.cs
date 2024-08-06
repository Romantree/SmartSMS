using Carriage_SMS_Project.Presenters;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carriage_SMS_Project.COMMON;

namespace Carriage_SMS_Project.DB
{
    public class MDB : Singleton<MDB>
    {
        public struct TB_OPC_TAG
        {
            public string ID;
            public string Line;
            public string OP;
            public string Name;
            public string Type;
            public string TagValue;
            public string TagDesc;
            public string Qulity;
            public string TCode;
            public string Flag;
        };

        const string DB_WINCC_NAME = "OPCServer_WinCC.mdb";

        private bool _IsConnect;

        private string FsDbPath;

        OleDbConnection WinccConn;
        OleDbCommand WinccComm;

        OleDbDataAdapter DataAdapter = new OleDbDataAdapter();
        DataSet dtSet = new DataSet();
        DataTable dtTable = new DataTable();

        public void ConnDB()
        {
            FsDbPath = PublicUtils.Instance.gsDataDir + DB_WINCC_NAME;

            //string sConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FsDbPath;	// 32bit
            string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FsDbPath;     // 64bit

            if (System.IO.File.Exists(FsDbPath))
            {
                try
                {
                    WinccConn = new OleDbConnection(sConn);
                    WinccComm = WinccConn.CreateCommand();

                    WinccConn.Open();

                    _IsConnect = true;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    PublicUtils.Instance.SystemLog.AddEventLog("MDBConn Exception: " + e.Message);
                    _IsConnect = false;
                }
            }
        }
        public void CloseDB()
        {
            if (_IsConnect)
           
                WinccConn.Close();
        }
        //---------------------------------------------------------------------------
        public bool IsConnect()
        {
            return _IsConnect;

        }
        //public bool GetOpcList(List<TB_OPC_TAG> lst)
        //{
        //    string sMsg = "";

        //    if (!IsConnect())
        //        return false;

        //    string cmdText = "SELECT * FROM OPC_Tag ORDER BY ID ASC";
        //    WinccComm.CommandText = cmdText;

        //    OleDbDataReader reader = WinccComm.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        TB_OPC_TAG opc = new TB_OPC_TAG();

        //        try
        //        {
        //            opc.ID = reader["ID"].ToString();
        //            opc.Line = reader["Line"].ToString();
        //            opc.Name = reader["Name"].ToString();
        //            opc.Type = reader["Type"].ToString();
        //            opc.TagValue = reader["TagValue"].ToString();
        //            opc.TagDesc = reader["TagDesc"].ToString();
        //            opc.Qulity = reader["Qulity"].ToString();
        //            opc.TCode = reader["TCode"].ToString();
        //            opc.Flag = reader["Flag"].ToString();

        //            lst.Add(opc);
        //        }
        //        catch (Exception e)
        //        {
        //            sMsg = e.Message;
        //            return false;
        //        }
        //    }

        //    reader.Close();

        //    return true;
        //}
        ////---------

    }
}
