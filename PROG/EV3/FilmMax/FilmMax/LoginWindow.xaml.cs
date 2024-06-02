using LibraryFilmMax;
using MongoDB.Driver;
using System.Windows;
using MongoDB.Bson;

namespace FilmMax
{
    public partial class LoginWindow : Window
    {
        private ICore _controller = new Controller();
        public LoginWindow()
        {
            InitializeComponent();
            _controller.CreateConnection();
        }

        public bool LoginUser(string user, string password)
        {
            List<User> usersList = _controller.Database.GetAllUsers();
            for (int i = 0; i < usersList.Count; i++)
            {
                if (user == usersList[i].security.loginName &&
                    password == usersList[i].security.loginPassword)
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
        private void OpenUserWindow(string loginName)
        {
            ObjectId id = _controller.Database.GetUserWithLoginName(loginName);
            User user = _controller.Database.GetUser(id);

            if(user.security.loginName == "admin")
            {
                AdminControlPanelWindow controlPanel = new AdminControlPanelWindow(_controller);
                controlPanel.ShowDialog();
            }
            else
            {
                UserControlPanelWindow controlPanel = new UserControlPanelWindow(_controller, id);
                controlPanel.ShowDialog();
            }            
        }
    }
}