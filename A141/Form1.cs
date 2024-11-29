using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A141
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            lblRestaurant.Text = comboBox.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                lblRestaurant.Text = comboBox1.Text + "Added!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                lblRestaurant.Text = comboBox1.SelectedItem.ToString() + "Deleted!";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                //comboBox1.Items.RemoveAt(comboBox1.SelectedIndex); // 인덱스로 삭제
            }
        }
    }
}
