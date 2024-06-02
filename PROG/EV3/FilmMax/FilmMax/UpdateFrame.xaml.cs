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

        public UpdateFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            string loginName = LoginName.Text;
            ObjectId id = _controller.Database.GetUserWithLoginName(loginName);
            _userContext = _controller.Database.GetUser(id);
            GetUserData();            
        }
        private void ButtonUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateUserData();            
        }

        private void GetUserData()
        {
            listLoginUser.Text = _userContext.security.loginName;
            listLoginPassword.Text = "*****";
            listUserName.Text = _userContext.userName;
            listLastName.Text = _userContext.lastName;
            listPhone.Text = _userContext.phone;
            listEmail.Text = _userContext.email;
        }
        private void UpdateUserData()
        {
            _controller.Database.UpdateUser(_userContext.id, "userName", UserName.Text);
            _controller.Database.UpdateUser(_userContext.id, "lastName", LastName.Text);
            _controller.Database.UpdateUser(_userContext.id, "phone", Phone.Text);
            _controller.Database.UpdateUser(_userContext.id, "email", Email.Text);
        }
    }
}