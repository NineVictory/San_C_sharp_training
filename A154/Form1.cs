using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A154
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTime.Text = "";
            lblTime.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
            t.Interval = 1000;
            t.Tick += timer1_Tick;
            t.Start();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Location = new Point(
                ClientSize.Width /2 - lblTime.Width /2,
                ClientSize.Height /2 - lblTime.Height /2);
            lblTime.Text = DateTime.Now.ToString();
        }
        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fDlg = new FontDialog();           // FontDialog 객체 fDlg를 생성하여 초기화

            fDlg.ShowColor = true;                        // 글자 색상 선택 가능하도록 설정
            fDlg.ShowEffects = true;                      // 텍스트 효과(굵게, 기울임꼴 등) 설정 가능하도록 설정
            fDlg.Font = lblTime.Font;                     // 현재 lblTime의 폰트를 FontDialog의 기본 폰트로 설정
            fDlg.Color = lblTime.ForeColor;               // 현재 lblTime의 글자색을 FontDialog의 기본 글자색으로 설정

            if (fDlg.ShowDialog() == DialogResult.OK)     // "확인" 버튼을 눌러 설정을 완료했는지 확인
            {
                lblTime.Font = fDlg.Font;                 // 선택한 폰트를 lblTime에 적용
                lblTime.ForeColor = fDlg.Color;           // 선택한 글자색을 lblTime에 적용
            }
        }


        private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cDlg = new ColorDialog();         // ColorDialog 객체 cDlg를 생성하여 초기화
            if (cDlg.ShowDialog() == DialogResult.OK)     // "확인" 버튼을 눌러 색상이 선택되었는지 확인
            {
                this.BackColor = cDlg.Color;              // 선택한 색상을 폼의 배경색으로 적용
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
