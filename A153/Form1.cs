using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace A153
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();


            openFileDialog1 = new OpenFileDialog();                 //openFileDialog1은 OpenFileDialog 객체로, 텍스트 파일을 선택하는 대화 상자를 구성
            openFileDialog1.FileName = "Select a text file";        //FileName 속성은 기본 파일 이름을 설정. 여기선 Select a text file 이라고함
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";    //Filter 속성은 파일 선택을 필터링해 "텍스트 파일 (*.txt)"만 표시
            //openFileDialog1.Filter = "끼룩끼룩 |*.txt";
            openFileDialog1.Title = "Open text file";               //Title 속성은 대화 상자 상단에 "Open text file"

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)    //파일 선택 대화 상자를 표시 .파일을 선택하고 확인을 클릭하면 DialogResult.OK가 반환
            {
                try
                {
                    var filePath = openFileDialog1.FileName;        //사용자가 선택한 파일의 경로를 filePath 변수에 저장
                    using (FileStream fs = File.Open(filePath, FileMode.Open))//File.Open은 선택한 파일을 열기
                    {
                        Process.Start("notepad.exe", filePath);     //Process.Start 메소드로 notepad를 실행시켜 파일을 열도록함. filePath에 저장된 경로의 파일을 기본 메모장으로 연다.
                    }
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
