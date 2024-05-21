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
using MongoDB.Driver;

namespace TestingJSON
{
    public partial class MainWindow : Window
    {
        //private readonly string pathfile = "../../../usuariosMongo.json";

        private IMongoCollection<User> _usuariosCollection;
        public MainWindow()
        {
            InitializeComponent();
            ConectarMongoDB();
        }

        private void ConectarMongoDB()
        {
            var client = new MongoClient("mongodb+srv://user1:testingUser1@cluster0.ujikwt4.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("DBTest2");
            _usuariosCollection = database.GetCollection<User>("Test2");
        }

        private void CargarUsuarios()
        {
            var usuarios = _usuariosCollection.Find(usuario => true).ToList();
            usuariosListBox.Items.Clear();
            JSONtest.Text = "";
            foreach (var usuario in usuarios)
            {
                usuariosListBox.Items.Add($"{usuario.name} - {usuario.pass}");
            }

            foreach (var usuario in usuarios)
            {
                JSONtest.Text += usuario.name + " " + usuario.pass + "\n";
            }
        }



        public void TestingJSON()
        {
            string json = File.ReadAllText(pathfile);
            User[] users = new User[3];
            users = JsonSerializer.Deserialize<User[]>(json);
            VisualizeJSON(users);            
        }
        public void VisualizeJSON(User[] users)
        {
            string completeUsersList = "";
            foreach (User user in users)
            {
                completeUsersList += user.name + " " + user.pass + "\n";
            }

            JSONtest.Text = completeUsersList;
        }
        private void Button_GetAllUsers_Click(object sender, RoutedEventArgs e)
        {
            CargarUsuarios();
        }

        private void Button_Reset_Click(object sender, RoutedEventArgs e)
        {
            JSONtest.Text = "Lista vacia";
            usuariosListBox.Items.Clear();
        }
    }
}