using LibraryFilmMax;
using MongoDB.Bson;
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

namespace FilmMax
{
    public partial class CreateFrame : Page
    {
        ICore _controller;
        public CreateFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonCreateUser_Click(object sender, RoutedEventArgs e)
        {
            User user = RegisterUserData();

            if(_controller.IsValidUser(user))
            {
                _controller.CreateUser(user);
                DisplayMessage.Text = "El usuario ha sido creado";
            }
            else
            {
                DisplayMessage.Text = "El usuario introducido es incorrecto";
            }
        }

        private User RegisterUserData()
        {
            User user = new User()
            {
                id = ObjectId.GenerateNewId(),
                security = new Security()
                {
                    loginName = registerLoginName.Text,
                    loginPassword = registerLoginPassword.Text,
                },
                userName = registerName.Text,
                lastName = registerlastName.Text,
                birthDate = new BirthDate() { dayDate = 1, monthDate = 2, yearDate = 3 },
                phone = registerPhone.Text,
                email = registerEmail.Text,
                favouriteFilms = "//TODO"
            };
            return user;
        }
    }
}