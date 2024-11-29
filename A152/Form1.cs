using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A152
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            axWindowsMediaPlayer1.uiMode = "full";                                  //재생목록,일지정지,볼륨등을 보이게함. full대신 none와 mini도있음
            axWindowsMediaPlayer1.stretchToFit = true;                              //영상의 크기를 미디어 플레이어 창에 맞추도록 설정하는 옵션
                                                                                    //비디오가 미디어 플레이어 창 크기에 맞춰 자동으로 늘어나거나 축소됩니다. 영상이 플레이어 창에 맞게 표시되는 방식을 제어

            btnFile.Location = new Point(ClientSize.Width - btnFile.Size.Width - 5, //숫자가 클수록 점점 가운데로감.
                                        ClientSize.Height - btnFile.Size.Height - 5);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();                              //OpenFileDialog로 파일선택창을 띄을 준비.
            if (ofd.ShowDialog() == DialogResult.OK)                                //파일 선택 창을 열어 사용자가 파일을 선택했을 때 OK 버튼을 클릭했는지 확인
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;                           //사용자가 선택한 파일의 경로를 axWindowsMediaPlayer1.URL 속성에 할당
                                                                                    //이 속성에 경로가 지정되면 선택한 파일이 자동으로 미디어 플레이어에서 재생
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = this.ClientSize;                           //미디어 플레이어의 크기를 현재 폼의 클라이언트 영역(ClientSize) 크기와 일치시키도록

            btnFile.Location = new Point(ClientSize.Width - btnFile.Size.Width - 5,
              ClientSize.Height - btnFile.Size.Height - 5);                         //폼의 크기가 변할 때마다 버튼 위치가 재설정되므로, 항상 오른쪽 하단에 고정
        }
    }
}
