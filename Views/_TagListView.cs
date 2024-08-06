using Carriage_SMS_Project.Repositories;
using Carriage_SMS_Project.Views.IViews;
using ExcelDataReader;
 using System;
 using System.Collections.Generic;
 using System.ComponentModel;
 using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
 using System.IO;
 using System.Linq;
 using System.Runtime.InteropServices;
 using System.Text;
 using System.Threading.Tasks;
 using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class _TagListView : Form
    {


        DataTableCollection tableCollection;
        DataTable dt;
        MainRepository mainRepository;
        private byte[] _imageData;
        private string _fileName;

        public event EventHandler ExitApplication;


        public _TagListView()
        {
            InitializeComponent();


            mainRepository = new MainRepository();  

            btnClose.Click += (sender, e) =>
            {
                DialogResult result = MessageBox.Show("종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    // Do nothing, keep the window open
                }
            };


            btnSearch.Click += delegate { this.Search(); };
        }


        private void _TagListView_Load(object sender, EventArgs e)
        {
            ExcelLoad();
            StyleDataGridView();
            dataGridView1.CellPainting += dataGridView1_CellPainting;

        }

        private void Search()
        {
            string searchText = txtSearchBox.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("검색어를 작성하세요.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool match = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        match = true;
                        break;
                    }
                }
                row.DefaultCellStyle.BackColor = match ? Color.Beige : Color.White;
            }
            dataGridView1.ClearSelection();

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);
            }
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ExcelLoad()
        {
            string filePath = @"D:\직원명단.xlsx";

            if (File.Exists(filePath))
            {
                LoadFile(filePath);
            }
            else
            {
                MessageBox.Show("The file 'D:\\직원명단.xlsx' was not found.");
            }

        }
        private void LoadFile(string filePath)
        {
            selectSheet.Items.Clear();
            selectSheet.Text = "";
            txtFileName.Text = filePath;

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
            selectSheet.Enabled = true;
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

                foreach (DataTable table in tableCollection)
                {
                    selectSheet.Items.Add(table.TableName); // Add sheet to combobox
                }

                selectSheet.Enabled = true;
                selectSheet.SelectedIndex = 0;
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

                selectSheet.Enabled = false;
                dt = result.Tables[0];
                dataGridView1.DataSource = dt;
            }
        }


        private void cmbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectSheet.SelectedItem != null)
            {
                var selectedSheet = selectSheet.SelectedItem.ToString();
                dt = tableCollection[selectedSheet];
                dataGridView1.DataSource = dt;
            }
        }

        private void StyleDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DataGridViewCellStyle centerAlignStyle = new DataGridViewCellStyle();
            centerAlignStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style = centerAlignStyle;

            dataGridView1.Columns[0].DefaultCellStyle = centerAlignStyle;
            dataGridView1.Columns[1].DefaultCellStyle = centerAlignStyle;
            dataGridView1.Columns[2].DefaultCellStyle = centerAlignStyle;

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 335;
            dataGridView1.Columns[2].Width = 180;


        }

        [DebuggerHidden]
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.Value != null)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.PaintContent(e.ClipBounds);

                using (Pen gridLinePen = new Pen(Color.Gray))
                {
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
                    e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom);
                }

                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select an Image File";


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);

                    _imageData = File.ReadAllBytes(ofd.FileName);

                    _fileName = Path.GetFileName(ofd.FileName); // 저장된 파일 이름
                    txtImage.Text = _fileName.ToString();


                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_imageData == null)
                {
                    MessageBox.Show("선택된 이미지가 없습니다.");
                    return;
                }

                bool success = mainRepository.SaveImage(
                    model: "PLC1234",
                    fileName: _fileName,
                    imageData: _imageData,
                    description: "Uploaded image via application",
                    createdBy: "admin"
                );

                if (success)
                {
                    MessageBox.Show("이미지 업데이트 완료");
                }
                else
                {
                    MessageBox.Show("이미지 업로드 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("예기치 않은 오류 발생: " + ex.Message);
            }
        }

    }
}
