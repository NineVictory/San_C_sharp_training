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

namespace A156_3
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
        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (label1.Foreground != Brushes.White)
            {
                label1.Foreground = Brushes.White;              // label1의 글자 색상을 흰색으로 설정
                this.Background = Brushes.Blue;                 // UserControl의 배경색을 파란색으로 설정
            }
            else
            {
                label1.Foreground = SystemColors.WindowTextBrush; // label1의 글자 색상을 시스템 기본 텍스트 색상으로 설정
                this.Background = SystemColors.WindowBrush;       // UserControl의 배경을 시스템 기본 배경색으로 설정
            }

        }
    }
}
