using System.Text.Json;
using System.Xml.Linq;
using MongoDB.Driver;

namespace LibraryFilmMax
{
    public class Database : IDatabase
    {
        private IMongoDatabase _database;
        private IMongoCollection<User> _usuariosCollection;
        private List<User> _usersList = new List<User>();

        public IMongoDatabase DatabaseMongo => _database;
        public IMongoCollection<User> UsersCollection => _usuariosCollection;
        public List<User> UsersLists => _usersList;

        public void ConnectMongoDB()
        {
            var client = new MongoClient("mongodb+srv://user1:testingUser1@cluster0.ujikwt4.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            _database = client.GetDatabase("DatabaseFilmMax");
            _usuariosCollection = _database.GetCollection<User>("UsersData");
        }
        public List<User> GetAllUsers()
        {
            return _usuariosCollection.Find(usuario => true).ToList();
        }


        // CRUD de USUARIOS
        public long CreateUser(User user)
        {
            _usuariosCollection.InsertOne(user);
            return 1; //TODO OBJ INDEX
        }
        public void ReadUser()
        {
            throw new NotImplementedException();
        }
        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
        public void DeleteUser(string loginName)
        {
            _usuariosCollection.DeleteOne(usuario => usuario.security.loginName == loginName);
        }


        // CRUD de MOVIES
        public int CreateMovie()
        {
            throw new NotImplementedException();
        }
        public void ReadMovie()
        {
            throw new NotImplementedException();
        }
        public void UpdateMovie()
        {
            throw new NotImplementedException();
        }
        public void DeleteMovie()
        {
            throw new NotImplementedException();
        }


        // FUNCIONES GESTION USERS
        public User GetUserWithLoginName(string loginName)
        {
            List<User> usersList = GetAllUsers();
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].security.loginName == loginName)
                    return usersList[i];
            }
            return null;
        }
        public User GetUserAtIndex(int index)
        {
            if (index < 0)
                return null;        // TODO index valido
            List<User> usersList = GetAllUsers();
            return usersList[index];
        }
        public int GetIndexOf(User user)
        {
            List<User> usersList = GetAllUsers();
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].security.loginName == user.security.loginName)      //TODO user.Equals
                    return i;
            }
            return -1;
        }
    }
}