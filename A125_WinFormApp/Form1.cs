using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A125_WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                  //폼에서 사용하는 각종 컴포넌트와 클래스의 멤버를 위한 초기화 작업을 수행하는 역할

            //여기에 프로그램이 시작될 때 실행할 코드 작성
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello windows Forms Application!";
        }
    }
}
