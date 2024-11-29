using System.Drawing;
using System.Windows.Forms;
using System;

namespace A155
{
    enum DrawMode { LINE, RECTANGLE, CIRCLE, CURVED_LINE }; // 그림 모드 설정을 위한 열거형(enum) 정의

    public partial class Form1 : Form
    {
        private DrawMode drawMode;                          // 현재 선택된 드로잉 모드 저장
        private Pen pen = new Pen(Color.Black, 2);          // 기본 검은색 펜 생성, 선의 두께는 2
        private Pen eraser;                                 // 이전 도형 지우기용 펜
        private Graphics g;                                 // 그림을 그리기 위한 Graphics 객체
        Point startP; // 시작점                             // 시작점 위치
        Point endP;   // 끝점                               // 끝점 위치
        Point currP;  // 현재 위치                           // 마우스 현재 위치
        Point prevP;  // 이전 위치                           // 마우스 이전 위치

        public Form1()
        {
            InitializeComponent();

            g = CreateGraphics();                           // Graphics 객체 초기화
            toolStripStatusLabel1.Text = "Line Mode";       // 초기 모드를 "Line Mode"로 설정
            this.BackColor = Color.White;                   // 폼의 배경색을 흰색으로 설정
            this.eraser = new Pen(this.BackColor, 2);       // 지우개 펜 생성, 폼 배경색과 같은 색상으로 설정
        }

        // 도구 모음에서 Line 모드 선택 시
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.LINE;                       // 현재 드로잉 모드를 LINE으로 설정
            toolStripStatusLabel1.Text = "Line Mode";       // 상태 표시줄에 현재 모드 표시
        }

        // 도구 모음에서 Rectangle 모드 선택 시
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.RECTANGLE;                  // 현재 드로잉 모드를 RECTANGLE로 설정
            toolStripStatusLabel1.Text = "Rectangle Mode";  // 상태 표시줄에 현재 모드 표시
        }

        // 도구 모음에서 Circle 모드 선택 시
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.CIRCLE;                     // 현재 드로잉 모드를 CIRCLE로 설정
            toolStripStatusLabel1.Text = "Circle Mode";     // 상태 표시줄에 현재 모드 표시
        }

        // 도구 모음에서 Curved Line 모드 선택 시
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            drawMode = DrawMode.CURVED_LINE;                // 현재 드로잉 모드를 CURVED_LINE으로 설정
            toolStripStatusLabel1.Text = "Curved_Line Mode";// 상태 표시줄에 현재 모드 표시
        }

        // 도구 모음에서 색상 변경 버튼 클릭 시
        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();    // 색상 선택 대화상자 생성
            if (colorDialog.ShowDialog() == DialogResult.OK) // 사용자가 색상을 선택하고 "확인"을 누르면
                pen.Color = colorDialog.Color;              // 선택한 색상을 pen의 색상으로 설정
        }

        // 마우스 클릭 시 그림의 시작 위치 설정
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startP = new Point(e.X, e.Y);                   // 시작점을 현재 마우스 위치로 설정
            prevP = startP;                                 // 이전 위치를 시작점으로 설정
            currP = startP;                                 // 현재 위치를 시작점으로 설정
        }

        // 마우스 버튼을 떼면 그리기 동작 완료
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endP = new Point(e.X, e.Y);                     // 끝점을 현재 마우스 위치로 설정
            switch (drawMode)                               // 현재 선택된 모드에 따라 그리기
            {
                case DrawMode.LINE:
                    g.DrawLine(pen, startP, endP);          // LINE 모드 - 시작점과 끝점을 연결하는 선을 그림
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(pen, new Rectangle(     // RECTANGLE 모드 - 시작점과 끝점으로 사각형을 그림
                        startP,
                        new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(pen, new Rectangle(       // CIRCLE 모드 - 시작점과 끝점으로 원을 그림
                        startP,
                        new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;                                  // CURVED_LINE 모드에서는 MouseMove에서 그림
            }
        }

        // 마우스 이동 시 그림을 그리기 위해 호출
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)              // 마우스 왼쪽 버튼이 눌려있지 않으면 종료
                return;

            prevP = currP;                                  // 이전 위치를 현재 위치로 업데이트
            currP = new Point(e.X, e.Y);                    // 현재 위치를 새로운 마우스 위치로 설정

            switch (drawMode)
            {
                case DrawMode.LINE:
                    g.DrawLine(eraser, startP, prevP);      // 이전 선을 지우기 위해 지우개로 선을 그림
                    g.DrawLine(pen, startP, currP);         // 새로운 선을 현재 위치까지 그림
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(eraser, new Rectangle(  // 이전 사각형 지우기
                        startP,
                        new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawRectangle(pen, new Rectangle(     // 새로운 사각형을 현재 위치까지 그림
                        startP,
                        new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(eraser, new Rectangle(    // 이전 원을 지우기 위해 그려줌
                        startP,
                        new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawEllipse(pen, new Rectangle(       // 새로운 원을 현재 위치까지 그림
                        startP,
                        new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    g.DrawLine(pen, prevP, currP);          // CURVED_LINE 모드 - 마우스 이동 경로를 따라 자유 곡선 그림
                    break;
            }
        }
    }
}
