using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MongoDB.Bson;

namespace FilmMax
{
    public partial class ReadFrame : Page
    {
        private ICore _controller;
        private ObservableCollection<User> _usersViewer = new ObservableCollection<User>();
        private List<User> _UIUsersList = new List<User>();

        public ReadFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;
            DisplayAllUsers();
        }

        private void ButtonFindUser_Click(object sender, RoutedEventArgs e)
        {
            _usersViewer.Clear();

            string loginName = registerLoginName.Text;
            string userName = registerName.Text;

            if(loginName == "" && userName == "")
            {
                DisplayAllUsers();
            }
            else if(loginName != "" && userName == "")
            {
                DisplayUsersWithLoginName(loginName);
            }
            else if (loginName == "" && userName != "")
            {
                DisplayUsersWithUserName(userName);
            }
            else if(loginName != "" && userName != "")
            {
                DisplayUsersWithNames(loginName, userName);
            }
            else
            {
                DisplayEmptyResult();
            }
        }
        private void DisplayAllUsers()
        {
            _UIUsersList = _controller.Database.GetAllUsers();
            _usersViewer = new ObservableCollection<User>(_UIUsersList);    //TODO??
            UIControl.ItemsSource = _usersViewer;
        }

        //TODO implementar busqueda dinamica
        private void DisplayUsersWithLoginName(string loginName)
        {
            ObjectId id = _controller.Database.GetUserWithLoginName(loginName);
            User user = _controller.Database.GetUser(id);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithUserName(string userName)
        {
            ObjectId id = _controller.Database.GetUserWithLoginName(userName);
            User user = _controller.Database.GetUser(id);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithNames(string loginName, string userName)
        {
            ObjectId idLogin = _controller.Database.GetUserWithLoginName(loginName);
            ObjectId idName = _controller.Database.GetUserWithLoginName(userName);
            if(idLogin == idName)   // TODO idLogin.Equals(idName)
            {
                User user = _controller.Database.GetUser(idLogin);
                _usersViewer.Add(user);
                UIControl.ItemsSource = _usersViewer;
            }
        }
        private void DisplayEmptyResult()
        {
            DisplayMessage.Text = "Usuario no encontrado";
        }
    }
}