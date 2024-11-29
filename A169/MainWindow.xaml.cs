//using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;


namespace A169
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();              //Windows Forms에서 제공하는 파일 열기 대화상자를 생성
            ofd.InitialDirectory = @"C:\Users\shkoo\Pictures";      //대화상자가 처음 열릴 때 보여줄 디렉터리를 설정
            ofd.Multiselect = true;                                 //대화상자에서 여러 파일을 선택할 수 있도록 설정
            var result = ofd.ShowDialog();                          //파일 열기 대화상자를 화면에 표시하고, 사용자의 동작 결과를 반환
            if (result == System.Windows.Forms.DialogResult.OK)     
            {
                foreach (var s in ofd.FileNames) 
                {
                    lbFiles.Items.Add(s);
                }

            }
        }
    }
}
