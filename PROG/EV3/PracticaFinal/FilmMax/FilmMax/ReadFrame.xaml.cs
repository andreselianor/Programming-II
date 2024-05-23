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
        User _userSelected;

        public ReadFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            string loginName = registerName.Text;
            _userSelected = _controller.GetUserWithLoginName(loginName);

            {
                listUser.Text = _userSelected.security.loginName;
                listPassword.Text = _userSelected.security.loginPassword;
                listPhone.Text = _userSelected.phone;
                listEmail.Text = _userSelected.email;
            }
        }
    }
}