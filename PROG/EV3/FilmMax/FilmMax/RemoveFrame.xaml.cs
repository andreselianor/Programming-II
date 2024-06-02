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
using LibraryFilmMax;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FilmMax
{
    public partial class RemoveFrame : Page
    {
        private ICore _controller;
        private User _userContext;
        private ObservableCollection<User> _usersViewer = new ObservableCollection<User>();
        private List<User> _UIUsersList = new List<User>();

        public RemoveFrame(ICore controller)
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

            if (loginName == "" && userName == "")
            {
                DisplayAllUsers();
            }
            else if (loginName != "" && userName == "")
            {
                DisplayUsersWithLoginName(loginName);
            }
            else if (loginName == "" && userName != "")
            {
                DisplayUsersWithUserName(userName);
            }
            else if (loginName != "" && userName != "")
            {
                DisplayUsersWithNames(loginName, userName);
            }
            else
            {
                DisplayNullResult();
            }
            DisplayMessageRemove.Text = "";
        }
        private void DisplayAllUsers()
        {
            _UIUsersList = _controller.Database.FilterAllUsers();
            _usersViewer = new ObservableCollection<User>(_UIUsersList);    //TODO??
            UIControl.ItemsSource = _usersViewer;
        }

        //TODO implementar busqueda dinamica
        private void DisplayUsersWithLoginName(string loginName)
        {
            ObjectId id = _controller.Database.GetUserWithLoginName(loginName);
            if (id == ObjectId.Empty)
                DisplayNullResult();

            User user = _controller.Database.GetUserWithId(id);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithUserName(string userName)
        {
            ObjectId id = _controller.Database.GetUserWithUserName(userName);
            if (id == ObjectId.Empty)
                DisplayNullResult();

            User user = _controller.Database.GetUserWithId(id);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithNames(string loginName, string userName)
        {
            ObjectId idLogin = _controller.Database.GetUserWithLoginName(loginName);
            ObjectId idName = _controller.Database.GetUserWithUserName(userName);
            if (idLogin == idName && idLogin != ObjectId.Empty)   // TODO idLogin.Equals(idName)
            {
                User user = _controller.Database.GetUserWithId(idLogin);
                _usersViewer.Add(user);
                UIControl.ItemsSource = _usersViewer;
            }
            else
            {
                DisplayNullResult();
            }
        }

        #region FUNCIONES PRIVADAS
        private void DisplayNullResult()
        {
            DisplayMessageFilter.Text = "El usuario no existe";
        }

        private void ButtonRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            bool check = ShowAlertUser();
            if (check)
            {
                for (int i = 0; i < _usersViewer.Count; i++)
                {
                    _controller.Database.DeleteUser(_usersViewer[i].id);
                }
                string alert = "El usuario ha sido eliminado";
                DisplayMessageRemove.Text = alert;
            }
        }
        private bool ShowAlertUser()
        {
            string alertUser = "¿Desea realmente eliminar los usuarios seleccionados?";
            string alert = "Eliminar usuarios";
            MessageBoxResult result = MessageBox.Show(alertUser, alert, MessageBoxButton.YesNo);
            return result == MessageBoxResult.Yes;
        }
        #endregion
    }
}