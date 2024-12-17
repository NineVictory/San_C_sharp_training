using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A171
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
            chartView.Titles.Add("중간고사 성적");
            chartView.Series.Add("Series2");                        //차트에 새로운 데이터 시리즈 "Series2"를 추가
            chartView.Series["Series1"].LegendText = "수학";
            chartView.Series["Series2"].LegendText = "영어";

            chartView.ChartAreas.Add("ChartArea2");                 //새로운 차트 영역 "ChartArea2"를 추가
            chartView.Series["Series2"].ChartArea = "ChartArea2";   //"Series2" 데이터를 "ChartArea2"라는 새로운 차트 영역에 배치

            Random r = new Random();
            for(int i = 0; i<10; i++)
            {
                chartView.Series["Series1"].Points.AddXY(i, r.Next(100));
                chartView.Series["Series2"].Points.AddXY(i, r.Next(100));
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            chartView.ChartAreas.RemoveAt(chartView.ChartAreas.IndexOf("ChartArea2"));  //"ChartArea2"라는 차트 영역을 삭제
            chartView.Series["Series2"].ChartArea = "ChartArea1";                       //"Series2"를 "ChartArea1"로 이동
            //결과: "Series1"과 "Series2"가 모두 같은 차트 영역(ChartArea1)에 표시
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            chartView.ChartAreas.Add("ChartArea2");
            chartView.Series["Series2"].ChartArea = "ChartArea2";
            //결과: "Series1"은 ChartArea1에, "Series2"는 ChartArea2에 각각 표시
        }
    }
}
