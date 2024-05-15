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
        private IDatabase database = new Database();
        public LoginWindow()
        {
            InitializeComponent();            
            database.CreateDatabase();
        }

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            string user = userAccess.Text;
            string password = passwordAccess.Text;

            if(database.LoginUser(user,password))
            {
                UserControlPanelWindow controlPanel = new UserControlPanelWindow();
                controlPanel.Show();
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
            register.Show();
        }
    }
}