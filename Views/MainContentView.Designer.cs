namespace Carriage_SMS_Project.Views
{
    partial class MainContentView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roundButton11 = new Carriage_SMS_Project.Styler.RoundButton1();
            this.roundButton12 = new Carriage_SMS_Project.Styler.RoundButton1();
            this.pList = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.pMessage = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpc1 = new Carriage_SMS_Project.Styler.RoundButton1();
            this.pOpc = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mChart)).BeginInit();
            this.pOpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // roundButton11
            // 
            this.roundButton11.BackColor = System.Drawing.Color.White;
            this.roundButton11.BackgroundColor = System.Drawing.Color.White;
            this.roundButton11.BorderColor = System.Drawing.Color.Gray;
            this.roundButton11.BorderRadius = 4;
            this.roundButton11.BorderSize = 2;
            this.roundButton11.FlatAppearance.BorderSize = 0;
            this.roundButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.roundButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.roundButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.roundButton11.ForeColor = System.Drawing.Color.Black;
            this.roundButton11.Location = new System.Drawing.Point(19, 169);
            this.roundButton11.Name = "roundButton11";
            this.roundButton11.Size = new System.Drawing.Size(79, 26);
            this.roundButton11.TabIndex = 238;
            this.roundButton11.Text = "Message";
            this.roundButton11.TextColor = System.Drawing.Color.Black;
            this.roundButton11.UseVisualStyleBackColor = false;
            // 
            // roundButton12
            // 
            this.roundButton12.BackColor = System.Drawing.Color.White;
            this.roundButton12.BackgroundColor = System.Drawing.Color.White;
            this.roundButton12.BorderColor = System.Drawing.Color.Gray;
            this.roundButton12.BorderRadius = 4;
            this.roundButton12.BorderSize = 2;
            this.roundButton12.FlatAppearance.BorderSize = 0;
            this.roundButton12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.roundButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.roundButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.roundButton12.ForeColor = System.Drawing.Color.Black;
            this.roundButton12.Location = new System.Drawing.Point(604, 3);
            this.roundButton12.Name = "roundButton12";
            this.roundButton12.Size = new System.Drawing.Size(79, 26);
            this.roundButton12.TabIndex = 239;
            this.roundButton12.Text = "List";
            this.roundButton12.TextColor = System.Drawing.Color.Black;
            this.roundButton12.UseVisualStyleBackColor = false;
            // 
            // pList
            // 
            this.pList.Location = new System.Drawing.Point(574, 35);
            this.pList.Name = "pList";
            this.pList.Size = new System.Drawing.Size(463, 437);
            this.pList.TabIndex = 44;
            // 
            // pMessage
            // 
            this.pMessage.Controls.Add(this.pieChart);
            this.pMessage.Controls.Add(this.mChart);
            this.pMessage.Location = new System.Drawing.Point(15, 201);
            this.pMessage.Name = "pMessage";
            this.pMessage.Size = new System.Drawing.Size(553, 271);
            this.pMessage.TabIndex = 43;
            // 
            // pieChart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.pieChart.Legends.Add(legend1);
            this.pieChart.Location = new System.Drawing.Point(293, 19);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieDrawingStyle=Concave";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(242, 218);
            this.pieChart.TabIndex = 4;
            this.pieChart.Text = "chart1";
            // 
            // mChart
            // 
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.mChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.mChart.Legends.Add(legend2);
            this.mChart.Location = new System.Drawing.Point(15, 19);
            this.mChart.Name = "mChart";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "DrawingStyle=LightToDark";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.mChart.Series.Add(series2);
            this.mChart.Size = new System.Drawing.Size(294, 230);
            this.mChart.TabIndex = 3;
            this.mChart.Text = "chart3";
            title1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "2024 . 08 Error Data";
            this.mChart.Titles.Add(title1);
            // 
            // btnOpc1
            // 
            this.btnOpc1.BackColor = System.Drawing.Color.White;
            this.btnOpc1.BackgroundColor = System.Drawing.Color.White;
            this.btnOpc1.BorderColor = System.Drawing.Color.Gray;
            this.btnOpc1.BorderRadius = 4;
            this.btnOpc1.BorderSize = 2;
            this.btnOpc1.FlatAppearance.BorderSize = 0;
            this.btnOpc1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOpc1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btnOpc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpc1.ForeColor = System.Drawing.Color.Black;
            this.btnOpc1.Location = new System.Drawing.Point(19, 3);
            this.btnOpc1.Name = "btnOpc1";
            this.btnOpc1.Size = new System.Drawing.Size(79, 26);
            this.btnOpc1.TabIndex = 237;
            this.btnOpc1.Text = "OPC 1";
            this.btnOpc1.TextColor = System.Drawing.Color.Black;
            this.btnOpc1.UseVisualStyleBackColor = false;
            // 
            // pOpc
            // 
            this.pOpc.Controls.Add(this.textBox2);
            this.pOpc.Controls.Add(this.textBox1);
            this.pOpc.Controls.Add(this.label3);
            this.pOpc.Controls.Add(this.label1);
            this.pOpc.Location = new System.Drawing.Point(15, 35);
            this.pOpc.Name = "pOpc";
            this.pOpc.Size = new System.Drawing.Size(553, 128);
            this.pOpc.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(284, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 78);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = " \"MachineA\" 기계의 모터 속도를 나타내며, \r\n현재 모터 회전 속도는 1200 RPM입니다.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 77);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "장치의 센서 데이터 중 진동 속도를 나타내며, \r\n 현재 진동 값은 2.5 mm/s RMS(Root Mean Square)입니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(280, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "2. MachineA.Motor.Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HY견고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. PLC1.SensorData.Vibration";
            // 
            // MainContentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roundButton11);
            this.Controls.Add(this.roundButton12);
            this.Controls.Add(this.pList);
            this.Controls.Add(this.pMessage);
            this.Controls.Add(this.btnOpc1);
            this.Controls.Add(this.pOpc);
            this.Name = "MainContentView";
            this.Size = new System.Drawing.Size(1064, 533);
            this.Load += new System.EventHandler(this.MainContentView_Load);
            this.pMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mChart)).EndInit();
            this.pOpc.ResumeLayout(false);
            this.pOpc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Styler.RoundBorderPanel pOpc;
        private Styler.RoundButton1 btnOpc1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Styler.RoundBorderPanel pMessage;
        private Styler.RoundBorderPanel pList;
        private Styler.RoundButton1 roundButton11;
        private Styler.RoundButton1 roundButton12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart mChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
