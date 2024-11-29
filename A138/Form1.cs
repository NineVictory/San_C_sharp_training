using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            str = "입사일 :" + Date1.Text + "\n";
            str += "우편번호 :" + Date2_1.Text + "\n";
            str += "주소 :" + Adress1.Text + "\n";
            str += "폰 :" + Phone1.Text + "\n";
            str += "주번 :" + Id1.Text + "\n";
            str += "이메일 :" + Email1.Text;

            MessageBox.Show(str,"개인정보");
        }


    }
}
