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
    public partial class UserControlPanelWindow : Window
    {
        public UserControlPanelWindow()
        {
            InitializeComponent();
        }

        // Botones de usuario
        private void User_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
            LoginWindow window = new LoginWindow();
            window.ShowDialog();
        }
        private void Logout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowAlert();
        }
        private void userLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            userLabel.Visibility = Visibility.Visible;
        }
        private void logoutLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            logoutLabel.Visibility = Visibility.Visible;
        }
        private void userLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            userLabel.Visibility = Visibility.Hidden;
        }
        private void logoutLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            logoutLabel.Visibility = Visibility.Hidden;
        }


        // Alerta para salir del programa
        private void ShowAlert()
        {
            MessageBoxResult result = MessageBox.Show("Desea realmente salir de la aplicación?", "Alerta", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                LogoutWindow window = new LogoutWindow();
                window.ShowDialog();
            }
        }        
    }
}