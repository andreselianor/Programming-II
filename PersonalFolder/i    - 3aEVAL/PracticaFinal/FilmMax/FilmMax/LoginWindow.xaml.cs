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



            AdminControlPanelWindow window = new AdminControlPanelWindow(_controller);
            window.ShowDialog();
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
                OpenUserWindow(user);
            }
            else
            {
                ErrorLogin.Text = "El usuario no existe";
                userAccess.Text = string.Empty;
                passwordAccess.Text = string.Empty;               
            }
        }
        private void Button_NewUser(object sender, RoutedEventArgs e)
        {
            RegisterNewUserWindow register = new RegisterNewUserWindow(_controller);
            register.ShowDialog();
        }

        // Visualizador de ventanas según el user
        private void OpenUserWindow(string name)
        {
            User user = _controller.GetUserWithName(name);
            if(user.name == "admin")
            {
                AdminControlPanelWindow controlPanel = new AdminControlPanelWindow(_controller);
                controlPanel.ShowDialog();
            }
            else
            {
                int userIndex = _controller.GetIndexOf(user);
                UserControlPanelWindow controlPanel = new UserControlPanelWindow(_controller, userIndex);
                controlPanel.ShowDialog();
            }            
        }
    }
}