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
    public partial class LogoutWindow : Window
    {
        Brush brushRight = Brushes.DodgerBlue;
        Brush brushWrong = Brushes.Crimson;

        public LogoutWindow()
        {
            InitializeComponent();
        }

        private void button_Answer1(object sender, RoutedEventArgs e)
        {           
            borderButton1.Background = brushRight;

            answerText1.Visibility = Visibility.Visible;
            logoutButton.Visibility = Visibility.Visible;
        }

        private void button_Answer2(object sender, RoutedEventArgs e)
        {
            borderButton1.Background = brushRight;
            borderButton2.Background = brushWrong;

            answerText1.Visibility = Visibility.Visible;
            logoutButton.Visibility = Visibility.Visible;
        }

        private void button_Answer3(object sender, RoutedEventArgs e)
        {
            borderButton1.Background = brushRight;
            borderButton3.Background = brushWrong;

            answerText1.Visibility = Visibility.Visible;
            logoutButton.Visibility = Visibility.Visible;
        }

        private void button_Answer4(object sender, RoutedEventArgs e)
        {
            borderButton1.Background = brushRight;
            borderButton4.Background = brushWrong;

            answerText1.Visibility = Visibility.Visible;
            logoutButton.Visibility = Visibility.Visible;
        }

        private void logoutButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}