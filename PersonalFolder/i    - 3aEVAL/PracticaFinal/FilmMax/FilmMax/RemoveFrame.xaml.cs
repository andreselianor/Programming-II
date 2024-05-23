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
        Controller _controller;
        User _userSelected;
        public RemoveFrame(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            string userName = registerName.Text;
            _userSelected = _controller.GetUserWithName(userName);

            {
                listUser.Text = _userSelected.security.userName;
                listPassword.Text = _userSelected.security.userPassword;
                listPhone.Text = _userSelected.phone;
                listEmail.Text = _userSelected.email;
            }            
        }

        private void ButtonRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            _controller.RemoveUser(_userSelected.security.userName);
        }
    }
}
