using LibraryFilmMax;
using MongoDB.Driver;
using System.Text.Json;
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

namespace FilmMax
{
    public class Controller
    {
        private IDatabase _database = new Database();
        //private readonly string JSONPath = "../../../RSC/usuariosFilmMax.json";
        public IMongoCollection<User> _usuariosCollection;


        public void ConectarMongoDB()
        {
            var client = new MongoClient("mongodb+srv://user1:testingUser1@cluster0.ujikwt4.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("DatabaseFilmMax");
            _usuariosCollection = database.GetCollection<User>("UsersData");
        }
        public List<User> GetAllUsers()
        {
            return _usuariosCollection.Find(usuario => true).ToList();
        }
        public void ReviewUsers()
        {
            List<User> usersList = GetAllUsers();
            foreach (User user in usersList)
            {
                User test = user;
            }
        }
        public User GetUserAt(int index)
        {
            return GetAllUsers()[index];
        }
    }
}