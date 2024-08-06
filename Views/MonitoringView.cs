using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Carriage_SMS_Project.Views
{
    public partial class MonitoringView : UserControl
    {

        private const string apiKey = "1d0b09e1b53dddad8c1e1429c7cf55b2"; // 기본 API 키
        private readonly string[] cities = { "Seoul", "Busan", "Ulsan", "cheonan", "Daegu", "Namhae","Jeju" };


        public MonitoringView()
        {
            InitializeComponent();
            InitializeChart();
            LoadWeatherData();
        }

        private void RealtimeView_Load(object sender, EventArgs e)
        {
            
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Maximum = 100;

            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 300;

            chart2.ChartAreas[0].AxisX.Title = "X-Axis ";
            chart2.ChartAreas[0].AxisY.Title = "Y-Axis ";


            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 45; // Rotate X-axis labels
            chart2.ChartAreas[0].AxisY.LabelStyle.Format = "0.00"; // Format Y-axis labels
            chart2.ChartAreas[0].AxisX.LineColor = Color.Blue;
            chart2.ChartAreas[0].AxisY.LineColor = Color.Blue;
            chart2.ChartAreas[0].BackColor = Color.White;

            chart2.Series[0].Color = Color.Red;

            //chart2.Series[0].MarkerStyle = MarkerStyle.Circle;
            //chart2.Series[0].MarkerSize = 8;
            //chart2.Series[0].MarkerColor = Color.Blue;

            chart2.Series[0].BorderWidth = 2;

            chart2.ChartAreas[0].AxisX.LineWidth = 2;

            chart2.BorderlineColor = Color.Black;
            chart2.BorderlineWidth = 2;

            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            Random random = new Random();

            if (chart2.Series[0].Points.Count == 100)
            {
                chart2.Series[0].Points.Clear();
            }

            chart2.Series[0].Points.Add(random.Next(300));
        }
        private void InitializeChart()
        {
            // 차트 초기화
            chartWeather.Series.Clear();
            chartWeather.ChartAreas.Clear();
            chartWeather.Legends.Clear(); // 기존의 레전드 제거

            // 차트 영역 설정
            ChartArea chartArea = new ChartArea
            {
                Name = "MainChartArea",
                AxisX =
        {
            Title = "City",
            Interval = 1, // X축 간격 설정
            LabelStyle = { Angle = -45 } // 레이블 각도 조정 (필요시)
        },
                AxisY =
        {
            Title = "Temperature (°C)",
            Interval = 5, // Y축 간격 설정
            Minimum = -20, // Y축 최소값 설정
            Maximum = 50 // Y축 최대값 설정
        }
            };
            chartWeather.ChartAreas.Add(chartArea);

            // 단일 시리즈 설정
            Series series = new Series("ondo")
            {
                ChartType = SeriesChartType.Column, // 세로 막대 그래프 타입으로 설정
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                BorderWidth = 2,
                ["PixelPointWidth"] = "20", // 막대 너비 설정
                IsValueShownAsLabel = true // 데이터 포인트에 값 표시
            };

            // 시리즈를 차트에 추가
            chartWeather.Series.Add(series);

            // 레전드 설정
            Legend legend = new Legend
            {
                Name = "MainLegend",
                Title = "Weather Data",
                TitleFont = new Font("Arial", 12, FontStyle.Bold),
                Docking = Docking.Top,
                Alignment = StringAlignment.Center
            };
            chartWeather.Legends.Add(legend);
        }

     

        private async void LoadWeatherData()
        {
            using (HttpClient client = new HttpClient())
            {
                foreach (var city in cities)
                {
                    string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

                    try
                    {
                        string response = await client.GetStringAsync(apiUrl);
                        JObject json = JObject.Parse(response);

                        double temperature = (double)json["main"]["temp"];

                        // 차트 업데이트
                        UpdateChart(city, temperature);
                    }
                    catch (HttpRequestException httpEx)
                    {
                        MessageBox.Show($"HTTP Error for {city}: {httpEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error for {city}: {ex.Message}");
                    }
                }
            }
        }

        private void UpdateChart(string city, double temperature)
        {
            Series series = chartWeather.Series["ondo"];

            // 데이터 포인트 추가
            DataPoint point = new DataPoint
            {
                AxisLabel = city,
                YValues = new double[] { temperature },
                Color = GetColorForCity(city) // 각 도시별 색상 설정
            };
            series.Points.Add(point);

            // 데이터 포인트가 제대로 보이도록 확인합니다.
            chartWeather.ChartAreas[0].RecalculateAxesScale(); // 축의 스케일을 다시 계산
        }

        private Color GetColorForCity(string city)
        {
            // 각 도시별 색상을 반환하는 방법을 정의
            // 예를 들어, 도시 이름에 따라 색상을 반환하거나, 색상 배열을 사용할 수 있습니다.
            // 이 예시에서는 색상 배열을 사용합니다.
            var cityColors = new Dictionary<string, Color>
            {
                { "Seoul", Color.Red },
                { "Busan", Color.Green },
                { "Ulsan", Color.Blue },
                { "Cheonan", Color.Orange },
                { "Daegu", Color.Purple },
                { "Namhae", Color.Pink },
                { "Jeju", Color.Cyan }
            };

            return cityColors.ContainsKey(city) ? cityColors[city] : Color.Gray; // 기본 색상 설정
        }

 
    }
}
