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
        private ICore _controller;
        public CreateFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonCreateUser_Click(object sender, RoutedEventArgs e)
        {
            User user = RegisterNewUser();

            if(_controller.Database.IsValidUser(user))
            {
                _controller.Database.CreateUser(user);
                DisplayMessage.Text = "El usuario ha sido creado";
            }
            else
            {
                DisplayMessage.Text = "El usuario introducido es incorrecto";
            }
        }

        private User RegisterNewUser()
        {
            User user = new User()
            {
                id = ObjectId.Empty,
                security = new Security()
                {
                    loginName = registerLoginName.Text,
                    loginPassword = registerLoginPassword.Text,
                },
                userName = registerName.Text,
                lastName = registerLastName.Text,
                birthDate = new BirthDate() { 
                    dayDate = Int16.Parse(registerDayBirth.Text), 
                    monthDate = Int32.Parse(registerMonthBirth.Text), 
                    yearDate = Int32.Parse(registerYearBirth.Text) 
                },
                phone = registerPhone.Text,
                email = registerEmail.Text
            };
            return user;
        }
    }
}