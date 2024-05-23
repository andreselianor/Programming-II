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

namespace FilmMax
{
    public partial class RemoveFrame : Page
    {
        ICore _controller;
        User _userContext;

        public RemoveFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            string loginName = registerLoginName.Text;
            _userContext = _controller.GetUserWithLoginName(loginName);

            if (_userContext == null)
            {
                DisplayMessage.Text = "El usuario no existe";
            }
            else
            {
                DisplayDataTextBlock();
            }
        }

        private void ButtonRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            _controller.DeleteUserWithLoginName(_userContext.security.loginName);

            string alert = "El usuario ha sido eliminado";
            DisplayMessage.Text = alert;
            DisplayEmptyTextBlock();
        }

        private void DisplayDataTextBlock()
        {
            listLoginUser.Text = _userContext.security.loginName;
            listLoginPassword.Text = "*****";
            listUserName.Text = _userContext.userName;
            listLastName.Text = _userContext.lastName;
            listPhone.Text = _userContext.phone;
            listEmail.Text = _userContext.email;
        }
        private void DisplayEmptyTextBlock()
        {
            listLoginUser.Text = string.Empty;
            listLoginPassword.Text = string.Empty;
            listUserName.Text = string.Empty;
            listLastName.Text = string.Empty;
            listPhone.Text = string.Empty;
            listEmail.Text = string.Empty;
        }
    }
}