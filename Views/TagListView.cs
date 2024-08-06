using ExcelDataReader;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class TagListView : UserControl
    {
        DataTableCollection tableCollection;
        DataTable dt;

        public TagListView()
        {
            InitializeComponent();
            ExcelLoad();
            CustomizeDataGridView();

        }

        private void TagListView_Load(object sender, EventArgs e)
        {
        }

        private void ExcelLoad()
        {
            string filePath = @"D:\TagList_1.xlsx";

            if (File.Exists(filePath))
            {
                LoadFile(filePath);
                dataGridView1.ClearSelection();

            }
            else
            {
                MessageBox.Show("The file 'D:\\TagList_1.xlsx' was not found.");
            }
        }

        private void LoadFile(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                var extension = Path.GetExtension(filePath).ToUpper();
                if (extension == ".XLS" || extension == ".XLSX")
                {
                    LoadExcelFile(stream);
                }
                else if (extension == ".CSV" || extension == ".TXT")
                {
                    LoadCsvOrTxtFile(stream);
                }
            }
        }

        private void LoadExcelFile(Stream stream)
        {
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var result = reader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        EmptyColumnNamePrefix = "Column",
                        UseHeaderRow = true
                    }
                });

                dt = result.Tables[0];
                dataGridView1.DataSource = dt;
                tableCollection = result.Tables;
            }
        }

        private void LoadCsvOrTxtFile(Stream stream)
        {
            using (var reader = ExcelReaderFactory.CreateCsvReader(stream))
            {
                var result = reader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        EmptyColumnNamePrefix = "Column",
                        UseHeaderRow = true
                    }
                });

                dt = result.Tables[0];
                dataGridView1.DataSource = dt;
            }
        }

        private void CustomizeDataGridView()
        {
            // DataGridView 스타일링
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            // 각 열의 크기 변경 불가 설정 (선택 사항)
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // 각 행의 크기 변경 불가 설정 (선택 사항)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }

            //셀값 조정
            DataGridViewCellStyle centerAlignStyle = new DataGridViewCellStyle();
            centerAlignStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style = centerAlignStyle;
            dataGridView1.Columns[0].DefaultCellStyle = centerAlignStyle;

            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 350;

            // 조건부 서식 추가
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 짝수 행의 배경색 변경
            if (e.RowIndex % 2 == 0) 
            {
                e.CellStyle.BackColor = Color.AliceBlue; 
                e.CellStyle.ForeColor = Color.Black; 
            }
            else
            {
                e.CellStyle.BackColor = Color.LightGray; 
                e.CellStyle.ForeColor = Color.Black; 
            }
        }


    }
}
