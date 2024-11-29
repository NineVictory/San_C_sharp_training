using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A129_FormClass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.ClientSize = new Size(300,200);

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            CenterToParent();   //부모의 중앙에 위치시키는 코드
        }
        

    }
}
