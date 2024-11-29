using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A156_1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (label1.Foreground != Brushes.White)
            {
                label1.Foreground = Brushes.White;
                this.Background = Brushes.Blue; 
            }
            else
            {
                label1.Foreground = SystemColors.WindowTextBrush;
                this.Background = SystemColors.WindowBrush;
            }
        }
    }

}
