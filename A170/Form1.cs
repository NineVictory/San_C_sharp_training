using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A170
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "대충 제목";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            chart1.Titles.Add("중간고사 성적");
            for (int i = 0; i < 10; i++) 
            {
                chart1.Series["Series1"].Points.Add(r.Next(100));       //Points 컬렉션은 차트에 표시되는 데이터 포인트를 나타냄
            }
            chart1.Series["Series1"].LegendText = "수학";
            chart1.Series["Series1"].ChartType = SeriesChartType.Line;  //데이터 시리즈 "Series1"의 차트 타입을 **꺾은선(Line)**으로 설정
        }
    }
}
