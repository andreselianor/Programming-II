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
using LibraryFilmMax;

namespace FilmMax
{
    public partial class UserControlPanelWindow : Window
    {
        User user = new User();
        public UserControlPanelWindow(Controller controller,int index)
        {
            InitializeComponent();
            //user = controller.GetUserAt(index);
            //DataContext = user;
        }

        // Botones de usuario
        private void User_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowAlertUser();
        }
        private void Logout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowAlertLogout();
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


        // Alerta para cambiar de usuario
        private void ShowAlertUser()
        {
            MessageBoxResult result = MessageBox.Show("¿Realmente desea cerrar la sesión y volver a la página de inicio?", "Alerta", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Close();
                LoginWindow window = new LoginWindow();
                window.ShowDialog();
            }
        }

        // Alerta para salir del programa
        private void ShowAlertLogout()
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