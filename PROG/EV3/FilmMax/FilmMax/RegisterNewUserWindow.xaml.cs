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
using System.Windows.Shapes;
using LibraryFilmMax;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FilmMax
{
    public partial class RegisterNewUserWindow : Window
    {
        private ICore _controller;
        public RegisterNewUserWindow(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                id = ObjectId.GenerateNewId(),
                security = new Security()
                {
                    loginName = registerLoginName.Text,
                    loginPassword = registerLoginPassword.Text
                },
                userName = registerName.Text,
                lastName = registerLastName.Text,
                birthDate = new BirthDate() { dayDate = Int32.Parse(registerDayBirth.Text), monthDate = Int32.Parse(registerMonthBirth.Text), yearDate = Int32.Parse(registerYearBirth.Text) },
                phone = registerPhone.Text,
                email = registerEmail.Text,
                favouriteFilms = "TODO"
            };

            if (_controller.Database.IsValidUser(user))
            {
                _controller.Database.CreateUser(user);
                DisplayMessage.Text = "El usuario ha sido creado";
            }
            else
            {
                DisplayMessage.Text = "El usuario introducido es incorrecto";
            }
        }

        // Seleccion de peliculas favoritas
        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film1Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film2Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film3Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film4Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film5Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film6Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film7Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }
        private void Image8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border brush = film8Border;
            if (brush.BorderBrush == Brushes.White)
                brush.BorderBrush = Brushes.IndianRed;
            else
                brush.BorderBrush = Brushes.White;
        }        
    }
}