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
using System.IO;
using System.Text.Json;

namespace TestingJSON
{
    public partial class MainWindow : Window
    {
        private readonly string pathfile = "../../../usuariosMongo.json";
        public MainWindow()
        {
            InitializeComponent();
        }

        public void TestingJSON()
        {
            string json = File.ReadAllText(pathfile);
            User[] users = new User[3];
            users = JsonSerializer.Deserialize<User[]>(json);

            string completeUsersList = "";
            foreach(User user in users)
            {
                completeUsersList += user.name + " " + user.pass + "\n";
            }

            JSONtest.Text = completeUsersList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestingJSON();
        }
    }
}
