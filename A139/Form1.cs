using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0);
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
            srcR.Maximum = 255 + 9;
            srcG.Maximum = 255 + 9;
            srcB.Maximum = 255 + 9;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            if(txtR.Text != "" && txtG.Text != "" && txtB.Text != "")
            {
                srcR.Value = int.Parse(txtR.Text);
                srcG.Value = int.Parse(txtG.Text);
                srcB.Value = int.Parse(txtB.Text);
                panel1.BackColor = Color.FromArgb(srcR.Value, srcG.Value, srcB.Value);
            }
        }

        private void srcR_Scroll(object sender, ScrollEventArgs e)
        {
            txtR.Text = srcR.Value.ToString();
            txtG.Text = srcG.Value.ToString();
            txtB.Text = srcB.Value.ToString();
            panel1.BackColor = Color.FromArgb(srcR.Value, srcG.Value, srcB.Value);
        }
    }
}
