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
        Controller _controller;
        public RegisterNewUserWindow(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void Button_CreateUser(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                id = ObjectId.GenerateNewId(),
                name = registerName.Text,
                security = new Security()
                {
                    userName = registerName.Text,
                    userPassword = registerPassword.Text,
                },
                birthDate = new BirthDate() { dayDate = 1, monthDate = 2, yearDate = 3 },
                phone = registerPhone.Text,
                email = registerEmail.Text,
                favouriteFilms = "TODO"
            };
            _controller._usuariosCollection.InsertOne(user);
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
