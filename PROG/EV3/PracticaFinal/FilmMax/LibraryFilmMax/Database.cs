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


        public IMongoDatabase DatabaseMongo => _database;
        public IMongoCollection<User> UsersCollection => _usuariosCollection;


        public void ConnectMongoDB()
        {
            var client = new MongoClient("mongodb+srv://user1:testingUser1@cluster0.ujikwt4.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            _database = client.GetDatabase("DatabaseFilmMax");
            _usuariosCollection = _database.GetCollection<User>("UsersData");
        }


        // CRUD de USUARIOS
        public ObjectId CreateUser(User user)
        {
            if (IsValidUser(user))
            {
                _usuariosCollection.InsertOne(user);
                User result = GetUserWithLoginName(user.security.loginName);
                return result.id;
            }
            else
            {
                throw new ArgumentException();
            }            
        }
        public User? ReadUser(ObjectId id)
        {
            return GetUserWithID(id);

        }
        public void UpdateUser(ObjectId id, string field, string value)
        {
            User user = GetUserWithID(id);
            UpdateDefinition<User> update = Builders<User>.Update.Set(field, value);
            _usuariosCollection.UpdateOne(usuario => usuario.security.loginName == user.security.loginName, update);
        }
        public void DeleteUser(ObjectId id)
        {
            User user = GetUserWithID(id);
            _usuariosCollection.DeleteOne(usuario => usuario.Equals(user));
        }




        // FUNCIONES GESTION USERS
        public User GetUserWithID(ObjectId id)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.id, id);
            return _usuariosCollection.Find(filter).First();
        }
        public User? GetUserWithLoginName(string loginName)
        {            
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.security.loginName, loginName);
            return _usuariosCollection.Find(filter).First();
        }
        public User? GetUserWithUserName(string userName)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.userName, userName);
            return _usuariosCollection.Find(filter).First();
        }
        public User? GetUserWithPhone(string phone)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.phone, phone);
            return _usuariosCollection.Find(filter).First();
        }
        public User? GetUserWithEmail(string email)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.email, email);
            return _usuariosCollection.Find(filter).First();
        }
        public List<User> GetAllUsers()
        {
            return _usuariosCollection.Find(usuario => true).ToList();
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