using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carriage_SMS_Project.Styler
{
    public class MessageViewStyler
    {
        public static void InitMessageViewStyler(DataGridView dataGridView, MessagePresenter messagePresenter)
        {
            // 컬럼 정의
            var sabunColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Sabun",
                Name = "_sabun",
                DataPropertyName = "Sabun",
                Width = 40,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8, FontStyle.Regular)
                }
            };
            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Check",
                Name = "_check",
                DataPropertyName = "Check",
                TrueValue = true,
                FalseValue = false,
                Width = 50,
          
            };
            var messageColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Message",
                Name = "_message",
                DataPropertyName = "Message",
                Width = 345,
         
            };
            var comboBoxColumn1 = new DataGridViewComboBoxColumn
            {
                HeaderText = "Name1",
                Name = "_name1",
                DataPropertyName = "Name1",
                Width = 85,
                FlatStyle = FlatStyle.Flat,
        
            };
            var comboBoxColumn2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "Name2",
                Name = "_name2",
                DataPropertyName = "Name2",
                Width = 85,
                FlatStyle = FlatStyle.Flat,
          
            };
            var comboBoxColumn3 = new DataGridViewComboBoxColumn
            {
                HeaderText = "Name3",
                Name = "_name3",
                DataPropertyName = "Name3",
                Width = 85,
                FlatStyle = FlatStyle.Flat,

            };
            var buttonColumn1 = new DataGridViewButtonColumn 
            {                   
                HeaderText = "SEND",
                  Name = "_sendBtn",
                DataPropertyName = "sendBtn",
                Width = 70,
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true,
                Text = "전송"

            };
            var buttonColumn2 = new DataGridViewButtonColumn
            {
                HeaderText = "RESET",
                Name = "_resetBtn",
                DataPropertyName = "_resetBtn",
                Width = 70,
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true,
                Text = "리셋"

            };


            // 컬럼 추가
            dataGridView.Columns.Add(sabunColumn);
            dataGridView.Columns.Add(checkBoxColumn);
            dataGridView.Columns.Add(messageColumn);
            dataGridView.Columns.Add(comboBoxColumn1);
            dataGridView.Columns.Add(comboBoxColumn2);
            dataGridView.Columns.Add(comboBoxColumn3); 
            dataGridView.Columns.Add(buttonColumn1);
            dataGridView.Columns.Add(buttonColumn2);


            // 스타일 적용
            ApplyStyles(dataGridView);

            // 콤보박스 컬럼에 데이터 로드
            messagePresenter.LoadComboBoxItems(comboBoxColumn1, "Name1");
            messagePresenter.LoadComboBoxItems(comboBoxColumn2, "Name2");
            messagePresenter.LoadComboBoxItems(comboBoxColumn3, "Name3");

            dataGridView.ClearSelection();
            dataGridView.CurrentCell = null;
        }

        private static void ApplyStyles(DataGridView dataGridView)
        {
            // 데이터 그리드 뷰 기본 스타일 설정
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); 
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView.DefaultCellStyle.BackColor = Color.White;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.AllowUserToAddRows = false;


            // 행 스타일 설정
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridView.RowsDefaultCellStyle.BackColor = Color.White;

            // 자동 크기 조정
            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // 헤더 텍스트 정렬
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 체크박스 컬럼 스타일
            DataGridViewCheckBoxColumn checkBoxColumn = dataGridView.Columns["_check"] as DataGridViewCheckBoxColumn;
            if (checkBoxColumn != null)
            {
                checkBoxColumn.FlatStyle = FlatStyle.Standard;
                checkBoxColumn.ThreeState = false;
                checkBoxColumn.Width = 50; // 체크박스 컬럼 너비를 설정합니다.

            }
            // 셀 텍스트와 크기 설정


            // 특정 열에 대해 텍스트와 크기 설정
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial Regular", 12,FontStyle.Bold);
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


        }
    

    }
}
