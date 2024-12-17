using System;
using System.Drawing;
using System.Windows.Forms;

namespace A165
{
    public partial class Form1 : Form
    {
        Graphics g;             // 그래픽 객체를 선언하여 그래픽 작업을 수행할 준비
        private Point center;   // 시계의 중심 좌표
        private double radius;  // 시계의 반지름
        private int hourHand;   // 시침의 길이
        private int minHand;    // 분침의 길이
        private int secHand;    // 초침의 길이
        private Timer timer1;   // 시계의 초침을 움직이기 위한 타이머
        private const int clientSize = 300; // 윈도우 크기 (클라이언트 사이즈)
        private const int clockSize = 200;  // 시계판의 지름

        public Form1()
        {
            InitializeComponent(); // 폼 초기화

            this.ClientSize = new Size(clientSize, clientSize); // 폼 크기 설정
            this.Text = "Analog Clock"; // 폼의 제목 설정
            panel1.BackColor = Color.Beige; // 패널의 배경색 설정
            this.Padding = new Padding(5); // 폼에 여백 추가

            g = panel1.CreateGraphics(); // 패널에 그릴 그래픽 객체 생성

            aClockSetting();  // 아날로그 시계의 기본 설정
            TimerSetting();   // 타이머 설정
        }

        private void aClockSetting()
        {
            center = new Point(panel1.Width / 2, panel1.Height / 2); // 시계 중심 좌표 설정
            radius = panel1.Height / 2; // 시계 반지름 설정

            hourHand = (int)(radius * 0.45); // 시침 길이를 반지름의 45%로 설정
            minHand = (int)(radius * 0.55);  // 분침 길이를 반지름의 55%로 설정
            secHand = (int)(radius * 0.65);  // 초침 길이를 반지름의 65%로 설정
        }

        private void TimerSetting()
        {
            timer1 = new Timer();           // 새로운 타이머 객체 생성
            timer1.Interval = 1000;         // 1초 간격으로 설정
            timer1.Tick += Timer1_Tick;     // 타이머 이벤트 연결
            timer1.Start();                 // 타이머 시작
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;      // 현재 시간을 얻어옴

            panel1.Refresh();               // 패널을 새로고침하여 이전 그리기 내용을 삭제(이걸안하면 초침이 중첩이된다)

            DrawClockFace();                // 시계판을 그리는 함수 호출(원모양 시계판을 그림)

            // 시침, 분침, 초침의 각도를 라디안 단위로 계산
            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180; // 시침 각도
            double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;    // 분침 각도
            double radSec = (c.Second) * 6 * Math.PI / 180;                      // 초침 각도

            DrawHands(radHr, radMin, radSec); // 시계 바늘을 그리는 함수 호출
        }

        private void DrawClockFace()
        {
            Pen pen = new Pen(Brushes.LightSteelBlue, 15);  // 시계판 테두리 펜 설정
            g.DrawEllipse(pen, center.X - clockSize / 2, center.Y - clockSize / 2, clockSize, clockSize); // 원형 시계판 그리기
        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            // 시침 그리기
            DrawLine((int)(hourHand * Math.Sin(radHr)), (int)(-hourHand * Math.Cos(radHr)),
                0, 0, Brushes.RoyalBlue, 8, center.X, center.Y);

            // 분침 그리기
            DrawLine((int)(minHand * Math.Sin(radMin)), (int)(-minHand * Math.Cos(radMin)),
                0, 0, Brushes.SkyBlue, 6, center.X, center.Y);

            // 초침 그리기
            DrawLine((int)(secHand * Math.Sin(radSec)), (int)(-secHand * Math.Cos(radSec)),
                0, 0, Brushes.OrangeRed, 3, center.X, center.Y);

            // 시계 중심의 작은 원 (배꼽) 그리기
            int coreSize = 16; // 중심 원의 크기
            Rectangle r = new Rectangle(center.X - coreSize / 2, center.Y - coreSize / 2, coreSize, coreSize); // 중심 원 영역 설정
            g.FillEllipse(Brushes.Gold, r);  // 중심 원을 채우기
            Pen p = new Pen(Brushes.DarkRed, 3); // 중심 원 테두리 펜 설정
            g.DrawEllipse(p, r);             // 중심 원 테두리 그리기
        }

        private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, int Cx, int Cy)
        {
            Pen pen = new Pen(color, thick);             // 색상과 두께로 펜 설정
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round; // 라인의 시작 모양을 둥글게 설정
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;   // 라인의 끝 모양을 둥글게 설정
            g.DrawLine(pen, x1 + Cx, y1 + Cy, x2 + Cx, y2 + Cy);   // 선을 그리는 좌표 계산 및 그리기
        }

    }
}
