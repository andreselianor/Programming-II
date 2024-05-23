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
    public partial class UpdateFrame : Page
    {
        ICore _controller;
        User _userSelected;
        public UpdateFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            string userName = registerName.Text;
            _userSelected = _controller.GetUserWithLoginName(userName);

            {
                listUser.Text = _userSelected.security.loginName;
                listPassword.Text = _userSelected.security.loginPassword;
                listPhone.Text = _userSelected.phone;
                listEmail.Text = _userSelected.email;
            }
        }

        private void ButtonUpdateUser_Click(object sender, RoutedEventArgs e)
        {
            string userName = registerName.Text;
            _userSelected = _controller.GetUserWithLoginName(userName);

            {
                _userSelected.security.loginName = listUser.Text;
                _userSelected.security.loginPassword = listPassword.Text;
                _userSelected.phone = listPhone.Text;
                _userSelected.email = listEmail.Text;
            }
        }
    }
}