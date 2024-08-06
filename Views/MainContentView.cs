using Carriage_SMS_Project.Models;
using Carriage_SMS_Project.Repositories;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataTable = System.Data.DataTable;

namespace Carriage_SMS_Project.Views
{
    public partial class MainContentView : UserControl
    {
        MessageModel messageModel;
        DataTable dt;
        MainRepository mainRepository = new MainRepository();

        public MainContentView()
        {
            InitializeComponent();
        }

        private void MainContentView_Load(object sender, EventArgs e)
        {
            TagListView tagListView = new TagListView();
            pList.Controls.Clear();
            tagListView.Dock = DockStyle.Fill;
            pList.Controls.Add(tagListView);





            //차트 추가
            Random random = new Random();
            string[] Legend = { "X축", "Y축", "진동", "Level", "RL" };


            int[] Data = { 100, 200, 300, 400, 500 };

            pieChart.Series[0].LegendText = "#VALX (#PERCENT{P1})";
            pieChart.Series[0].Label = "#VALY";


            for (int i = 0; i < 5; i++)
            {
                pieChart.Series[0].Points.AddXY(Legend[i], Data[i]);
            }

            pieChart.Legends[0].Docking =
                System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            pieChart.DataManipulator.Sort(
            System.Windows.Forms.DataVisualization.
            Charting.PointSortOrder.Descending, pieChart.Series[0]);

  
            pieChart.Series[0]["PieLabelStyle"] = "OutSide";
            pieChart.Series[0].BorderWidth = 1;
            pieChart.Series[0].BorderColor = Color.Black;

            pieChart.Series[0]["CollectedSliceExploded"] = "true";
            pieChart.Series[0]["CollectedThreshold"] = "200";
            pieChart.Series[0]["CollectedThresholdUsePercent"] = "false";

            chartUpdate();

        }

        public void chartUpdate()
        {
         
            mainRepository.GetErrorEventData();
            
            // Chart에 데이터 바인딩
            mChart.DataSource = mainRepository.dataTable;
            mChart.Series[0].XValueMember = "Date";
            mChart.Series["Series1"].YValueMembers = "ErrorCount";
            mChart.Series[0].LegendText = "메시지";

            mChart.DataBind();

        }

    }
    class Employee
    {
        private string name;
        private int result;
        public Employee(string name,int result)
            { this.name = name;
            this.result = result; }

        public string Name { get { return name; } set { name = value; } }
        public int Result { get { return result; } set { result = value; } } 
    }
}
