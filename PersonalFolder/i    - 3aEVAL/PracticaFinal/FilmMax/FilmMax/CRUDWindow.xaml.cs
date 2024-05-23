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
using System.Windows.Shapes;

namespace FilmMax
{
    public partial class CRUDWindow : Window
    {
        Controller _controller;
        public CRUDWindow(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ImageBackUsers_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ButtonCreateFrame_Click(object sender, RoutedEventArgs e)
        {
            ViewUI.Content = new CreateFrame(_controller);
        }
        private void ButtonReadUser_Click(object sender, RoutedEventArgs e)
        {
            ViewUI.Content = new ReadFrame(_controller);
        }
        private void ButtonUpdateFrame_Click(object sender, RoutedEventArgs e)
        {
            ViewUI.Content = new UpdateFrame(_controller);
        }
        private void ButtonRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            ViewUI.Content = new RemoveFrame(_controller);
        }
    }
}