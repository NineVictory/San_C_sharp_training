using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Middle_Review
{
    public partial class Form2 : Form
    {
        public string InputValue { get; private set; } // 텍스트 값을 저장할 속성
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에서 입력된 값 가져오기
            InputValue = Restaurant_txt.Text;




            // OpenFileDialog로 사진 선택
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택한 파일 경로
                string selectedImagePath = openFileDialog.FileName;

                // 프로젝트의 'images' 폴더에 저장할 경로
                string projectImagesPath = Path.Combine(Application.StartupPath, "images");


            }
        }
    }
}
