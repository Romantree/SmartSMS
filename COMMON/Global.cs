using Carriage_SMS_Project.DB;
using Carriage_SMS_Project.Models;
using Carriage_SMS_Project.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Carriage_SMS_Project.COMMON
{
    public class Global :Singleton<Global>

    {
        public bool bMasterTypeChange;

        public bool bFirstRun1;
        public bool bFirstRun2;
        public OpcLink opcData;
        public int RmMasterType;
        public List<MDB.TB_OPC_TAG> List_Opc = new List<MDB.TB_OPC_TAG>();

        public OpcLink OpcLink1;
        public bool bOpcFirstRun1;
        public bool bOpcFirstRun2;
        public bool[] Op11Start = new bool[5];
        public bool[] Op11Stop = new bool[5];
        public int[] PanghwaChange = new int[5];

        public List<OpcModel> OpcValue = new List<OpcModel>();


        public Global()
        {
            opcData = new OpcLink(0);
            InitMachineVar();

        }
        private void InitMachineVar()
        {
            List_Opc.Clear();


            bOpcFirstRun1 = false;


            OpcLink1 = new OpcLink(0);

            RmMasterType = 0;   // 1: OPC_LINK1, 2: OPC_LINK2

            for (int i = 0; i < 5; i++)
            {
                Op11Start[i] = false;
                Op11Stop[i] = false;
                PanghwaChange[i] = 0;
            }
        }
    }
}
