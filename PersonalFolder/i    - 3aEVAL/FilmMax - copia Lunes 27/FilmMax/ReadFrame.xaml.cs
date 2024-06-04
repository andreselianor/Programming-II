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
using FilmMax;
using LibraryFilmMax;

namespace FilmMax
{    
    public partial class ReadFrame : Page
    {
        ICore _controller;
        User _userContext;

        public ReadFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            string loginName = registerLoginName.Text;
            _userContext = _controller.Database.GetUserWithLoginName(loginName);

            if(_userContext == null ) 
            {
                DisplayMessage.Text = "El usuario no existe";
            }
            else
            {
                listLoginUser.Text = _userContext.security.loginName;
                listLoginPassword.Text = "*****";
                listUserName.Text = _userContext.userName;
                listLastName.Text = _userContext.lastName;
                listPhone.Text = _userContext.phone;
                listEmail.Text = _userContext.email;
            }
        }
    }
}