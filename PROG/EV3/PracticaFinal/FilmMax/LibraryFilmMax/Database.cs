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
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.id, id); // Filter.Eq("ciudad", "valencia")
            return _usuariosCollection.Find(filter).First();
        }
        public void UpdateUser(ObjectId id, string field, string value)
        {
            User userUpdate = ReadUser(id);
            UpdateDefinition<User> update = Builders<User>.Update.Set(field, value);
            _usuariosCollection.UpdateOne(usuario => usuario.id == userUpdate.id, update);
        }
        public void DeleteUser(ObjectId id)
        {
            User user = ReadUser(id);
            _usuariosCollection.DeleteOne(usuario => usuario.Equals(user));
        }


        // FUNCIONES GESTION USERS
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
            if (user.lastName == null)
                return false;
            if (!IsValidBirth(user.birthDate))
                return false;
            if (user.phone == null)
                return false;
            if (user.email == null)
                return false;
            return true;
        }

        private bool IsValidBirth(BirthDate birth)
        {
            if (birth.dayDate < 1 || birth.dayDate > 31)
                return false;
            if (birth.monthDate < 1 || birth.monthDate > 12)
                return false;
            if (birth.yearDate < 1900 || birth.yearDate > 2025)
                return false;
            return true;
        }
    }
}