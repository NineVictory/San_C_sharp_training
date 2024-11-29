using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            TreeNode root = new TreeNode("영국의 왕");
            TreeNode hanover = new TreeNode("하노버 왕가");
            TreeNode stuart = new TreeNode("스튜어트 왕가");

            stuart.Nodes.Add("앤(1707_1714)");
            hanover.Nodes.Add("윌리엄 4세(1830_1837)");

            root.Nodes.Add(stuart);
            root.Nodes.Add(hanover);

            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Text == "앤(1707_1714)")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/Anne.jpg");
                txtMemo.Text = "앤 여왕은 어쩌구저쩌구 궁시렁 꿍시렁 어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁" +
                    "어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁" +
                    "어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁" +
                    "어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁";
            }else if (e.Node.Text == "윌리엄 4세(1830_1837)")
            {
                pictureBox1.Image = Bitmap.FromFile("../../Images/William.jpg");
                txtMemo.Text = "윌리엄 4세는 어쩌구저쩌구 궁시렁 꿍시렁 어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁" +
                    "어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁" +
                    "어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁" +
                    "어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁어쩌구저쩌구 궁시렁 꿍시렁";
            }
        }
    }
}
