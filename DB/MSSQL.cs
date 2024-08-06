using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carriage_SMS_Project.DB
{
    public class MSSQL
    {

        SqlConnection DataConn;
        SqlCommand DataComm;
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataSet dtSet = new DataSet();
        DataTable dtTable = new DataTable();
        DataTable DataTbl = new DataTable();

        private bool _IsConnect;
        private bool _FbTrendUpdate;


        public MSSQL()
        {
            _IsConnect = false;
            _FbTrendUpdate = false;
        }
        public void Release()
        {
        }
        //---------------------------------------------------------------------------
        /****************************************************************************
        * MCS DATA SQL
        ****************************************************************************/
        public void ConnDBSql()
        {
            //string sConn = "Server=10.10.10.123; "
            //+ "database=SMIC; "
            //+ "uid=SMIC; "
            //+ "pwd=SMICSMIC; ";
            string sConn = "Data Source=(local);Initial Catalog=erpDB;User ID=SoohoKim;Password=4588;TrustServerCertificate=True";

            try
            {
                DataConn = new SqlConnection(sConn);
                DataComm = DataConn.CreateCommand();

                DataConn.Open();

                //conn.
                _IsConnect = true;
            }
            catch (Exception e)
            {
                _IsConnect = false;
                string sMsg = e.Message.ToString();
            }
        }
        //---------------------------------------------------------------------------
        public void CloseDB()
        {
            if (_IsConnect)
                DataConn.Close();
        }
        //---------------------------------------------------------------------------
        public bool IsConnect()
        {
            if (DataConn.State == ConnectionState.Closed)
            {
                DataConn.Open();

                if (DataConn.State == ConnectionState.Closed)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }
        //----------------------------------------------------------------------
        public void TableSelect(string sQuery, ref DataTable dtTable)
        {
            if (!IsConnect())
                return;

            SqlDataAdapter SqlDa = new SqlDataAdapter(sQuery, DataConn);

            try
            {
                //DataAdapter.Fill(dtTable);
                SqlDa.Fill(dtTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Table Select Failure! " + ex.Message);
            }
        }
        //----------------------------------------------------------------------
        public void TableSelect(SqlCommand sqlcmd, ref DataTable dtTable)
        {
            if (!IsConnect())
                return;

            SqlDataAdapter SqlDa = new SqlDataAdapter();

            try
            {
                sqlcmd.Connection = DataConn;

                SqlDa.SelectCommand = sqlcmd;
                SqlDa.Fill(dtTable);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Table Select Failure! " + ex.Message);
            }
        }
        //---------------------------------------------------------------------------
        public void TableInsert(string sInsertQuery, ref int nCount)
        {
            if (!IsConnect())
                return;

            SqlCommand SqlCmd = new SqlCommand(sInsertQuery, DataConn);

            try
            {
                nCount = SqlCmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Table Insert Failure! " + ex.Message);
            }

        }



        //---------------------------------------------------------------------------
        public void TableInsert(SqlCommand SqlCmd, ref int nCount)
        {
            if (!IsConnect())
                return;

            try
            {
                SqlCmd.Connection = DataConn;
                nCount = SqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Table Insert Failure! " + ex.Message);
            }
        }
        //---------------------------------------------------------------------------
        public int TableUpdate(string sUpdateQuery)
        {
            int nReturn = 0;

            if (!IsConnect())
                return 0;

            SqlCommand SqlCmd = new SqlCommand(sUpdateQuery, DataConn);

            try
            {
                nReturn = SqlCmd.ExecuteNonQuery();

                return nReturn;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Table Update Failure! " + ex.Message);

                return 0;
            }
        }
        //---------------------------------------------------------------------------
        public int TableUpdate(SqlCommand SqlCmd)
        {
            int nReturn = 0;

            if (!IsConnect())
                return 0;

            try
            {
                SqlCmd.Connection = DataConn;
                nReturn = SqlCmd.ExecuteNonQuery();

                return nReturn;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Table Update Failure! " + ex.Message);

                return 0;
            }
        }
        //----------------------------------------------------------------------
        public void StoredProcedureCall(string sProcedureName, string sReturnName, int nReturnValue)
        {
            SqlCommand SqlCmd = new SqlCommand(sProcedureName, DataConn);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.Add(sReturnName, SqlDbType.Decimal);
            SqlCmd.Parameters[sReturnName].Direction = ParameterDirection.ReturnValue;

            SqlCmd.ExecuteScalar();
            nReturnValue = int.Parse(SqlCmd.Parameters[sReturnName].Value.ToString());
        }
        //---------------------------------------------------------------------------
        public int TableInsert(SqlCommand SqlCmd)
        {
            if (!IsConnect())
                return 1;

            //string sMethodName = "[Table_Insert]";

            int nReturn = -1;

            try
            {
                //DataComm.CommandText = SqlCmd.CommandText;

                //nReturn = DataComm.ExecuteNonQuery();

                SqlCmd.Connection = DataConn;
                nReturn = SqlCmd.ExecuteNonQuery();

                return nReturn;
            }
            catch (Exception ex)
            {
                //PublicUtils.Instance.DataLoggingLog.AddEventLog(sMethodName + ": " + ex.Message);

                return -1;
            }
        }
        //---------------------------------------------------------------------------
        public int TableDelete(SqlCommand SqlCmd)
        {
            if (!IsConnect())
                return 1;

            string sMethodName = "[Table_Delete]";

            int nReturn = -1;

            try
            {
                DataComm.CommandText = SqlCmd.CommandText;

                nReturn = DataComm.ExecuteNonQuery();

                return nReturn;
            }
            catch (Exception ex)
            {
                //PublicUtils.Instance.DataLoggingLog.AddEventLog(sMethodName + ": " + ex.Message);

                return -1;
            }
        }
    }
}