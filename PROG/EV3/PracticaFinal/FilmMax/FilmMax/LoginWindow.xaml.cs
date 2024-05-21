using LibraryFilmMax;
using MongoDB.Driver;
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
            _controller.ConectarMongoDB();
        }

        public bool LoginUser(string user, string password)
        {
            List<User> usersList = _controller.GetAllUsers();
            for (int i = 0; i < usersList.Count; i++)
            {
                if (user == usersList[i].security.userName &&
                    password == usersList[i].security.userPassword)
                    return true;
            }
            return false;
        }


        // FUNCIONAMIENTO DE LOS BOTONES
        private void Button_Login(object sender, RoutedEventArgs e)
        {
            string user = userAccess.Text;
            string password = passwordAccess.Text;

            if(LoginUser(user,password))
            {
                Close();
                UserControlPanelWindow controlPanel = new UserControlPanelWindow(_controller,3);
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
            RegisterNewUserWindow register = new RegisterNewUserWindow(_controller);
            register.ShowDialog();
        }
    }
}