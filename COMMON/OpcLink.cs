using Microsoft.Office.Interop.Excel;
using Opc.Da;
using Opc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Carriage_SMS_Project.Presenters;

namespace Carriage_SMS_Project.COMMON
{
    public class OpcLink
    {
        private int _FnIndex;
        //public int RmMasterIdx;
        public bool RmMasterVar = false;
        public bool RmMasterOld;

        private bool[] LineStart = new bool[13];
        private bool[] Schedule = new bool[5];
        //private bool[] Op11Start = new bool[5];
        //private bool[] Op11Stop = new bool[5];

        //public int[] PanghwaChange = new int[5];

        private string sOpcServerName = "OPCServer.WinCC";

        private string sOpcNodeName1 = "192.168.30.20";

        private Opc.Da.Server m_server = null;
        private IDiscovery m_discovery;
        // Define group objects (subscribers)
        private Subscription m_MonitoringSubscription = null;
        private SubscriptionState m_MonitoringGroup = null;

        private OpcViewModel cOpcViewModel;

        private List<string> ServerList;
        //private List<string> m_ItemNameList;

        public OpcLink(int nIndex)
        {
            OpcConnect();
            _FnIndex = nIndex;

            for (int i = 0; i < 5; i++)
            {
                Schedule[i] = false;
            }
        }
        ~OpcLink()
        {

        }

        public bool OpcConnect()
        {
            try 
            {
                string sHost = "";

                m_discovery = new OpcCom.ServerEnumerator();
                cOpcViewModel = new OpcViewModel(_FnIndex);
                ServerList = new List<string>();

                if (_FnIndex == 0)
                    sHost = string.Format("opcda://{0}/{1}", sOpcNodeName1, sOpcServerName);

                URL url = new URL(sHost);

                m_server = new Opc.Da.Server(new OpcCom.Factory(), url);

                //connect to the server
                if (m_server != null)
                    m_server.Connect();
                else
                    return false;

                var serverStatus = m_server.GetStatus();

                // Set group status
                // Group (subscriber) status, equivalent to the parameters of the group in the OPC specification
                //m_MonitoringGroup = new SubscriptionState();
                //m_MonitoringGroup.Name = "MyOpc";                          // Group Name
                //m_MonitoringGroup.ServerHandle = null;                          // The handle assigned by the server to the group.
                //m_MonitoringGroup.ClientHandle = Guid.NewGuid().ToString();     // The handle assigned by the client to the group.
                //m_MonitoringGroup.Active = true;                                // Activate the group.
                //m_MonitoringGroup.UpdateRate = 1000;                             // The refresh rate is 1 second. -> 1000
                //m_MonitoringGroup.Deadband = 0;                                 // When the dead zone value is set to 0, the server will notify the group of any data changes in the group.
                //m_MonitoringGroup.Locale = null;                                //No regional values are set.

                // Add Group
                //m_MonitoringSubscription = (Subscription)m_server.CreateSubscription(m_MonitoringGroup); // Create Group



                if (_FnIndex == 0)
                    Global.Instance.bOpcFirstRun1 = true;

                return true;
            }
            catch (Exception ex)
            {
                if (_FnIndex == 0)
                    PublicUtils.Instance.OpcLink1Log.AddEventLog("OPC Link 1 Connection Fail: " + ex.Message);


                return false;
            }



        }
        public void OpcDisconnect()
        {
            if (m_MonitoringSubscription != null)
            {
                m_MonitoringSubscription.DataChanged -= OnDataChange;
                m_MonitoringSubscription.RemoveItems(m_MonitoringSubscription.Items);
                m_server.CancelSubscription(m_MonitoringSubscription);
                m_MonitoringSubscription.Dispose();
                m_MonitoringSubscription = null;
            }
            if (m_server != null)
            {
                m_server.Disconnect();
                m_server = null;
            }
            cOpcViewModel.ListOpcItem.Clear();

            cOpcViewModel = null;

        }

        public bool IsServerConnected()
        {
            try
            {
                if (m_server == null)
                    return false;

                if (m_server.IsConnected)
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                string sMsg = ex.Message;
                return false;
            }
        }
        public bool IsServerState()
        {
            try
            {
                if (m_server == null)
                    return false;

                ServerStatus serverStatus = m_server.GetStatus();

                if (serverStatus.ServerState == serverState.running)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                string sMsg = ex.Message;
                return false;
            }
        }

        public bool IsServerNullCheck()
        {
            if (m_server != null)
                return true;

            return false;
        }
        //----------------------------------------------------------------------
        public void OpcMasterRead()
        {
            string sMsg = "";

            if (m_server == null || cOpcViewModel == null)
                return;

            try
            {
                RmMasterVar = (bool)OpcGetTagValue("@RM_MASTER");

                if (RmMasterVar != RmMasterOld)
                {
                    sMsg = string.Format("@RM_MASTER >> [{0}] -> [{1}] 변경!", RmMasterOld, RmMasterVar);

                    if (_FnIndex == 0)
                    {
                        if (RmMasterVar)
                            Global.Instance.RmMasterType = 1;
                        PublicUtils.Instance.OpcLink1Log.AddEventLog(sMsg);
                    }
                    else
                    {
                        if (RmMasterVar)
                            Global.Instance.RmMasterType = 2;
                        PublicUtils.Instance.OpcLink2Log.AddEventLog(sMsg);
                    }

                    RmMasterOld = RmMasterVar;
                }
            }
            catch (Exception ex)
            {
                if (_FnIndex == 0)
                    PublicUtils.Instance.OpcLink1Log.AddEventLog("OPC_RM_MASTER Read Error: " + ex.Message);
                else
                    PublicUtils.Instance.OpcLink2Log.AddEventLog("OPC_RM_MASTER Read Error: " + ex.Message);
            }
        }
        //----------------------------------------------------------------------
        private void OpcItemOneWrite(string sTag, bool bValue)
        {
            int nTagIndex = PublicUtils.Instance.OpcTagGetIndex(sTag);

            Item OPC_WriteItem = m_MonitoringSubscription.Items[nTagIndex];
            ItemValue[] writeValues = new ItemValue[1];
            writeValues[0] = new ItemValue(OPC_WriteItem);
            writeValues[0].Value = bValue;
            IdentifiedResult[] retValue = m_MonitoringSubscription.Write(writeValues);
        }
        //----------------------------------------------------------------------
     
    
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
        public void OnDataChange(object subscriptionHandle, object requestHandle, ItemValueResult[] values)
        {
            foreach (ItemValueResult item in values)
            {
                cOpcViewModel.AddValue(item.ItemName, item.Value);
            }
        }

        public Object OpcGetTagValue(string sTag)
        {
            Object Obj = "";
            string TagName = "";

            for (int i = 0; i < Global.Instance.List_Opc.Count; i++)
            {
                TagName = Global.Instance.List_Opc[i].Name;

                if (TagName == sTag)
                {
                    if (cOpcViewModel.ListOpcItem[i].DataType == "System.Int32")
                    {
                        Obj = int.Parse(cOpcViewModel.ListOpcItem[i].Value.Trim());
                        break;
                    }
                    else if (cOpcViewModel.ListOpcItem[i].DataType == "System.Boolean")
                    {
                        Obj = bool.Parse(cOpcViewModel.ListOpcItem[i].Value.Trim());
                        break;
                    }
                    else if (cOpcViewModel.ListOpcItem[i].DataType == "System.Single")
                    {
                        Obj = double.Parse(cOpcViewModel.ListOpcItem[i].Value.Trim());
                        break;
                    }
                    else if (cOpcViewModel.ListOpcItem[i].DataType == "System.Int16")
                    {
                        Obj = int.Parse(cOpcViewModel.ListOpcItem[i].Value.Trim());
                        break;
                    }
                    else if (cOpcViewModel.ListOpcItem[i].DataType == "System.SByte")
                    {
                        Obj = byte.Parse(cOpcViewModel.ListOpcItem[i].Value.Trim());
                        break;
                    }
                    else if (cOpcViewModel.ListOpcItem[i].DataType == "System.String")
                    {
                        Obj = cOpcViewModel.ListOpcItem[i].Value.Trim();
                        break;
                    }
                }
            }

            return Obj;
        }
        //----------------------------------------------------------------------
    }
}