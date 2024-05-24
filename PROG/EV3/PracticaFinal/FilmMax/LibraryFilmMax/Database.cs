using System.Text.Json;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;

namespace LibraryFilmMax
{
    public class Database : IDatabase
    {
        private IMongoDatabase _database;
        private IMongoCollection<User> _usuariosCollection;
        private List<User> _usersList;

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
        public ObjectId CreateUser(User user)
        {
            if (IsValidUser(user))
            {
                _usuariosCollection.InsertOne(user);
                return GetUserID(user);
            }
            else
            {
                ObjectId insertError = new ObjectId("-1");
                return insertError;
            }            
        }
        public User? ReadUser(User user)
        {
            _usersList = GetAllUsers();
            for (int i = 0; i < _usersList.Count; i++)
            {
                if (_usersList[i] == user)
                    return _usersList[i];
            }
            return null;

        }
        public void UpdateUser(User user, string field, string value)
        {
            UpdateDefinition<User> update = Builders<User>.Update.Set(field, value);
            _usuariosCollection.UpdateOne(usuario => usuario.security.loginName == user.security.loginName, update);
        }
        public void DeleteUser(User user)
        {
            //_usuariosCollection.DeleteOne(usuario => usuario.security.loginName == user.security.loginName);
            _usuariosCollection.DeleteOne(usuario => usuario.Equals(user));
        }


        // CRUD de MOVIES
        public ObjectId CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
        public void ReadMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
        public void UpdateMovie(Movie movie, string field, string value)
        {
            throw new NotImplementedException();
        }
        public void DeleteMovie(Movie movie)
        {
            throw new NotImplementedException();
        }


        // FUNCIONES GESTION USERS
        public User? GetUserWithLoginName(string loginName)
        {
            List<User> usersList = GetAllUsers();
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].security.loginName == loginName)
                    return usersList[i];
            }
            return null;
        }
        public User? GetUserAtIndex(int index)
        {
            List<User> usersList = GetAllUsers();
            int totalUsers = usersList.Count;
            if (index < 0 || index > totalUsers)
                return null;

            return usersList[index];
        }
        public int GetIndexOf(User user)
        {
            List<User> usersList = GetAllUsers();
            for (int i = 0; i < usersList.Count; i++)
            {
                //if (usersList[i].security.loginName == user.security.loginName)      //TODO implementar Equals
                if (usersList[i].Equals(user))
                    return i;
            }
            return -1;
        }
        private ObjectId GetUserID(User user)
        {
            User? userResult = GetUserWithLoginName(user.security.loginName);
            if (userResult == null)
                return ObjectId.Empty;  // valor -1 o valor null?
            return userResult.id;
        }
        public bool IsValidUser(User user)
        {
            if (user.security.loginName == null)
                return false;
            if (user.security.loginPassword == null)
                return false;
            if (user.userName == null)
                return false;
            // TODO restos de usuarios validos
            return true;
        }
    }
}