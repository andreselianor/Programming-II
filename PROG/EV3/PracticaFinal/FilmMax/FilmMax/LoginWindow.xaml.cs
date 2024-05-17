using LibraryFilmMax;
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
    public partial class LoginWindow : Window
    {
        private Controller _controller = new Controller();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            string user = userAccess.Text;
            string password = passwordAccess.Text;

            if(_controller.LoginUser(user,password))
            {
                UserControlPanelWindow controlPanel = new UserControlPanelWindow();
                controlPanel.ShowDialog();
            }
            else
            {
                ErrorLogin.Text = "El usuario no existe";
                userAccess.Text = "";
                passwordAccess.Text = "";
            }
        }

        private void Button_NewUser(object sender, RoutedEventArgs e)
        {
            RegisterNewUserWindow register = new RegisterNewUserWindow();
            register.ShowDialog();
        }
    }
}