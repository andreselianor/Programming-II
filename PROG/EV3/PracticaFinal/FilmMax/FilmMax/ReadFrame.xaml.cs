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

namespace FilmMax
{
    public partial class ReadFrame : Page
    {
        private ICore _controller;
        private ObservableCollection<User> _usersViewer = new ObservableCollection<User>();
        private User _userContext = new User();
        private List<User> _UIUsersList = new List<User>();

        public ReadFrame(ICore controller)
        {
            InitializeComponent();
            _controller = controller;           
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
        }
        private void DisplayAllUsers()
        {
            _UIUsersList = _controller.Database.GetAllUsers();
            _usersViewer = new ObservableCollection<User>(_UIUsersList);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithLoginName(string loginName)
        {
            User user = _controller.Database.GetUserWithLoginName(loginName);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
        private void DisplayUsersWithUserName(string userName)
        {
            User user = _controller.Database.GetUserWithUserName(userName);
            _usersViewer.Add(user);
            UIControl.ItemsSource = _usersViewer;
        }
    }
}