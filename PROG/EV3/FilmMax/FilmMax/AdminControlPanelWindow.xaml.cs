using LibraryFilmMax;
using System;
using System.Windows;
using System.Windows.Input;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FilmMax
{
    public partial class AdminControlPanelWindow : Window
    {
        private ICore _controller;
        public AdminControlPanelWindow(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
            DataContext = GetAdminUser();
        }

        private User GetAdminUser()
        {
            ObjectId id = _controller.Database.GetUserWithLoginName("admin");
            return _controller.Database.GetUserWithId(id);
        }

        // Botones de usuario
        private void userLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowAlertUser();
        }
        private void userLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            userLabel.Visibility = Visibility.Visible;
        }
        private void userLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            userLabel.Visibility = Visibility.Hidden;
        }

        private void logoutLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowAlertLogout();
        }
        private void logoutLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            logoutLabel.Visibility = Visibility.Visible;
        }
        private void logoutLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            logoutLabel.Visibility = Visibility.Hidden;
        }

        private void userSettings_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowAlertUserSettings();
        }
        private void userSettingsLabel_MouseEnter(object sender, MouseEventArgs e)
        {
            settingsAdminLabel.Visibility = Visibility.Visible;
        }
        private void userSettingsLabel_MouseLeave(object sender, MouseEventArgs e)
        {
            settingsAdminLabel.Visibility = Visibility.Hidden;
        }


        // Alerta para cambiar de usuario
        private void ShowAlertUser()
        {
            string alertUser = "¿Desea realmente volver a la página de login?";
            string alert = "Cambio de usuario";
            MessageBoxResult result = MessageBox.Show(alertUser, alert, MessageBoxButton.YesNo);

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
            string quitApp = "¿Desea realmente salir de FilmMax?";
            string alert = "Salir del programa";
            MessageBoxResult result = MessageBox.Show(quitApp, alert, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                LogoutWindow window = new LogoutWindow();
                window.ShowDialog();
            }
        }

        // Alerta para modificar usuarios
        private void ShowAlertUserSettings()
        {
            string manageUsers = "¿Quiere acceder a la página de gestión de usuarios?";
            string alert = "Gestión de usuarios";
            MessageBoxResult result = MessageBox.Show(manageUsers, alert, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                CRUDWindow window = new CRUDWindow(_controller);
                window.ShowDialog();
            }
        }
    }
}