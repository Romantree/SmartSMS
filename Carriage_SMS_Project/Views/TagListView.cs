using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class TagListView : UserControl
    {


            public TagListView()
            {
                InitializeComponent();

                AssociateAndRaiseViewEvents();
            }

            private void AssociateAndRaiseViewEvents()
            {
                // DataGridView를 생성합니다.
                DataGridView dataGridView1 = new DataGridView();

                // DataGridView의 속성을 설정합니다.
                dataGridView1.Size = new Size(642, 370); // 크기 설정
                dataGridView1.Location = new Point(50, 90); // 위치 설정
                dataGridView1.BorderStyle = BorderStyle.None; // 테두리 스타일 설정

                // DataGridView에 컬럼과 데이터를 추가할 수 있습니다.
                // 예시로 컬럼과 데이터를 추가하는 코드를 작성합니다.
                // 열 추가
                // 열 추가
                for (int i = 0; i < 6; i++)
                {
                    dataGridView1.Columns.Add(new DataGridViewColumn
                    {
                        Name = $"Column{i + 1}",
                        HeaderText = $"Column{i + 1}",
                        CellTemplate = new DataGridViewTextBoxCell()
                    });
                }
                // 행 추가
                for (int i = 0; i < 14; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dataGridView1.Rows.Add(row);

                    // 각 행의 셀에 빈 값을 설정
                    for (int j = 0; j < 6; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = "";
                    }
                    // 짝수 번째 행의 배경색 변경
                    if (i % 2 == 1) // 짝수 번째 행 색상 변경
                    {
                        foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                        {
                            cell.Style.BackColor = Color.Yellow; // 배경색을 연한 회색으로 설정
                        }
                    }
                }
                int columnWidth = 100;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = columnWidth;
                }
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.HeaderCell.Style.Font = new Font("Arial", 11, FontStyle.Bold);
                }
                // MainForm에 DataGridView를 추가합니다.
                Controls.Add(dataGridView1);
            }

        }
    }
