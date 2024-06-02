using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryFilmMax;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FilmMax
{
    public partial class UpdateFrame : Page
    {
        private ICore _controller;
        private User _userContext;
        private ObservableCollection<User> _usersViewer = new ObservableCollection<User>();
        private List<User> _UIUsersList = new List<User>();

        public UpdateFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            _usersViewer.Clear();

            string loginName = loginUpdateName.Text;
            string userName = userUpdateName.Text;

            if (loginName == "" && userName == "")
            {
                DisplayNullResult();
            }
            else if (loginName != "" && userName == "")
            {
                DisplayUsersWithLoginName(loginName);
            }
            else if (loginName == "" && userName != "")
            {
                DisplayUsersWithUserName(userName);
            }
            else if (loginName != "" && userName != "")
            {
                DisplayUsersWithNames(loginName, userName);
            }
            else
            {
                DisplayNullResult();
            }
            DisplayMessageUpdate.Text = "";
        }
        private void ButtonUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            if (_usersViewer.Count < 1)
                return;
            User userUpdate = _usersViewer[0];
            ObjectId id = _controller.Database.GetUserWithLoginName(userUpdate.security.loginName);

            if (IsValidValue(loginUpdateName.Text))
                _controller.Database.UpdateUser(id, "security.loginName", loginUpdateName.Text);
            if (IsValidValue(loginUpdatePassword.Text))
                _controller.Database.UpdateUser(id, "security.loginPassword", loginUpdatePassword.Text);
            if (IsValidValue(userUpdateName.Text))
                _controller.Database.UpdateUser(id, "userName", userUpdateName.Text);
            if (IsValidValue(lastUpdateName.Text))
                _controller.Database.UpdateUser(id, "lastName", lastUpdateName.Text);
            if (IsValidValue(phone.Text))
                _controller.Database.UpdateUser(id, "phone", phone.Text);
            if (IsValidValue(email.Text))
                _controller.Database.UpdateUser(id, "email", email.Text);

            DisplayUpdateResult();
        }

        private void DisplayUsersWithLoginName(string loginName)
        {
            ObjectId id = _controller.Database.GetUserWithLoginName(loginName);
            if (id == ObjectId.Empty)
                DisplayNullResult();
            User user = _controller.Database.GetUserWithId(id);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithUserName(string userName)
        {
            ObjectId id = _controller.Database.GetUserWithUserName(userName);
            if (id == ObjectId.Empty)
                DisplayNullResult();
            User user = _controller.Database.GetUserWithId(id);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithNames(string loginName, string userName)
        {
            ObjectId idLogin = _controller.Database.GetUserWithLoginName(loginName);
            ObjectId idName = _controller.Database.GetUserWithUserName(userName);
            if (idLogin == idName)   // TODO idLogin.Equals(idName)
            {
                User user = _controller.Database.GetUserWithId(idLogin);
                _usersViewer.Add(user);
                UIControl.ItemsSource = _usersViewer;
            }
            else
            {
                return;
            }
        }
        private void DisplayNullResult()
        {
            DisplayMessage.Text = "El usuario no existe";
        }
        private void DisplayUpdateResult()
        {
            DisplayMessageUpdate.Text = "El usuario ha sido actualizado";
        }

        private bool IsValidValue(string value)
        {
            return value != "";
        }
    }
}