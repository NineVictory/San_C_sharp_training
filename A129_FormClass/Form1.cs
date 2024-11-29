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
    public partial class Form1 : Form       //Form을 상속받는 Form1 클래스
    {
        public Form1()      //Form1 클래스의 생성자
        { 
            InitializeComponent();

            this.ClientSize = new Size(500, 500);   //ClientSize : 폼의 영역크기

            Form f2 = new Form2();
            this.AddOwnedForm(f2);

            f2.Show();
        }
    }
}
