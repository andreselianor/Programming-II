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
        Controller _controller;
        public CreateFrame(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void ButtonCreateUser_Click(object sender, RoutedEventArgs e)
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
                favouriteFilms = "//TODO"
            };
            _controller._usuariosCollection.InsertOne(user);
        }
    }
}