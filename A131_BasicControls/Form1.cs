using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A131_BasicControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void botton1_Click(object sender, EventArgs e) 
        { 
            if(textBox1.Text == "")
            {
                MessageBox.Show("이름을 입력하세요","Warning");
            }
            else
            {
                label2.Text = textBox1.Text + "님 하이룽";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
