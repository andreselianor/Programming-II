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
        Controller _controller;
        User _userSelected;

        public ReadFrame(Controller controller)
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
    }
}