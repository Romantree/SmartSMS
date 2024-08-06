using Carriage_SMS_Project.Models;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carriage_SMS_Project.COMMON
{

    public class OpcViewModel
    {
        public List<OpcModel> OpcValue = new List<OpcModel>();

        public ObservableCollection<OpcData> ListOpcItem;
        private int _FnIndex;

        public OpcViewModel(int nIndex)
        {
            _FnIndex = nIndex;
            ListOpcItem = new ObservableCollection<OpcData>();
        }

        public void AddValue(string tName, object tValue)
        {
            for (int i = 0; i < ListOpcItem.Count; i++)
            {
                if (ListOpcItem[i].Name == tName)
                {
                    if (_FnIndex == 0)
                    {
                        if (Global.Instance.RmMasterType == 1)
                        {
                            if (i > 7743 && i < 7802)
                            {
                                string sMsg = string.Format("[{0}] : {1} -> {2}", ListOpcItem[i].Name, ListOpcItem[i].Value, tValue.ToString());
                                PublicUtils.Instance.OpcLink1Log.AddEventLog(sMsg);
                            }

                            Global.Instance.OpcValue[i].TagValue = tValue.ToString();
                        }

                        if (!Global.Instance.bOpcFirstRun1)
                            Global.Instance.OpcValue[i].TagValue = tValue.ToString();
                    }
                    else
                    {
                        if (Global.Instance.RmMasterType == 2)
                        {
                            if (i > 7743 && i < 7802)
                            {
                                string sMsg = string.Format("[{0}] : {1} -> {2}", ListOpcItem[i].Name, ListOpcItem[i].Value, tValue.ToString());
                                PublicUtils.Instance.OpcLink2Log.AddEventLog(sMsg);
                            }

                            Global.Instance.OpcValue[i].TagValue = tValue.ToString();
                        }

                        if (!Global.Instance.bOpcFirstRun2)
                            Global.Instance.OpcValue[i].TagValue = tValue.ToString();
                    }

                    ListOpcItem[i].Value = tValue.ToString();
                    break;
                }
            }
        }
            public void AddType(string tName, string strType)
            {
                for (int i = 0; i < ListOpcItem.Count; i++)
                {
                    if (ListOpcItem[i].Name == tName)
                    {
                        ListOpcItem[i].DataType = strType;
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName = null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
}
