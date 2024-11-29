using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rhkdqhrdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "지랄하지마세요 병신입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "You Genius.";
        }
    }
}
