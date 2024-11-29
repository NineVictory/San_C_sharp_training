using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A147
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "";
            timer1.Interval = 1000;     //1초마다 화면이 업데이트됨 : 초가 빠르게 흐르는것이 아니라 화면 주사율이 빨라진다고 생각하면 이해가 쉬울듯.
            timer1.Tick += Timer1_Tick;
            timer1.Start();             //timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Location = new Point(ClientSize.Width / 2 - lblTime.Width / 2, ClientSize.Height / 2 - lblTime.Height / 2);

            lblTime.Font = new Font("맑은 고딕", 30, FontStyle.Bold);
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
