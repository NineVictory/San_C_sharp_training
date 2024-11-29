using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string koo1 = "대충 뭐라고 문장을 써야되는데 무슨 말을 써야될지 모르겠다. 어떻게하지?";
            string koo2 = "대충 뭐라고 문장을 써야되는데 무슨 말을 써야될지 모르겠다. 어떻게할지 모르겠다 걍 복붙이나 하자 " +
                "대충 뭐라고 문장을 써야되는데 무슨 말을 써야될지 모르겠다. 어떻게할지 모르겠다 걍 복붙이나 하자" +
                "대충 뭐라고 문장을 써야되는데 무슨 말을 써야될지 모르겠다. 어떻게할지 모르겠다 걍 복붙이나 하자";


            label1.Text = koo1;
            label2.Text = koo2;
        }
    }
}
