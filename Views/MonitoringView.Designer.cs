namespace Carriage_SMS_Project.Views
{
    partial class MonitoringView
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.roundBorderPanel1 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundBorderPanel2 = new Carriage_SMS_Project.Styler.RoundBorderPanel();
            this.chartWeather = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roundBorderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.roundBorderPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.Controls.Add(this.chart2);
            this.roundBorderPanel1.Location = new System.Drawing.Point(20, 16);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Size = new System.Drawing.Size(441, 462);
            this.roundBorderPanel1.TabIndex = 0;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(14, 18);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(405, 429);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "PLC 진동 모니터링";
            this.chart2.Titles.Add(title1);
            // 
            // roundBorderPanel2
            // 
            this.roundBorderPanel2.Controls.Add(this.chartWeather);
            this.roundBorderPanel2.Location = new System.Drawing.Point(467, 16);
            this.roundBorderPanel2.Name = "roundBorderPanel2";
            this.roundBorderPanel2.Size = new System.Drawing.Size(592, 462);
            this.roundBorderPanel2.TabIndex = 1;
            // 
            // chartWeather
            // 
            chartArea2.Name = "ChartArea1";
            this.chartWeather.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend1";
            this.chartWeather.Legends.Add(legend2);
            this.chartWeather.Location = new System.Drawing.Point(17, 18);
            this.chartWeather.Name = "chartWeather";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartWeather.Series.Add(series2);
            this.chartWeather.Size = new System.Drawing.Size(557, 429);
            this.chartWeather.TabIndex = 5;
            this.chartWeather.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "도시별 현재 온도";
            this.chartWeather.Titles.Add(title2);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(23, 27);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(476, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "현재 진동 데이터";
            this.chart1.Titles.Add(title3);
            // 
            // RealtimeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundBorderPanel2);
            this.Controls.Add(this.roundBorderPanel1);
            this.Name = "RealtimeView";
            this.Size = new System.Drawing.Size(1088, 487);
            this.Load += new System.EventHandler(this.RealtimeView_Load);
            this.roundBorderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.roundBorderPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Styler.RoundBorderPanel roundBorderPanel1;
        private Styler.RoundBorderPanel roundBorderPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeather;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}
