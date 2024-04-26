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

namespace Tinder
{
    public partial class MainWindow : Window
    {
        private double animation = 0.0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window1 nextWindow = new Window1();
            nextWindow.Show();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = (Image)sender;
            image.Opacity = 0.5;
        }
        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Image image = (Image)sender;
            image.Opacity = 1.0;
        }
    }
}