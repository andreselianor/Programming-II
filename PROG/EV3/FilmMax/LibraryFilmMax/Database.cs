using System.Text.Json;
using System.Xml.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;

namespace LibraryFilmMax
{
    public delegate bool DelegateFilter(User user);
    public class Database : IDatabase
    {
        private IMongoDatabase _database;
        private IMongoCollection<User> _usuariosCollection;

        public IMongoDatabase DatabaseMongo => _database;
        public IMongoCollection<User> UsersCollection => _usuariosCollection;

        public void ConnectMongoDB()
        {
            string cadenaConexion = "mongodb+srv://user1:testingUser1@cluster0.ujikwt4.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            var client = new MongoClient(cadenaConexion);
            _database = client.GetDatabase("DatabaseFilmMax");
            _usuariosCollection = _database.GetCollection<User>("UsersData");
        }


        public ObjectId CreateUser(User user)
        {
            if (IsValidUser(user))
            {
                _usuariosCollection.InsertOne(user);
                return user.id;
            }
            else
            {
                throw new ArgumentException("Los datos introducidos son incorrectos");
            }
        }
        public void UpdateUser(ObjectId id, string field, string value)
        {
            if (!IsValidField(field))
                return;
            if (!IsValidValue(value))
                return;
            User userUpdate = GetUserWithId(id);
            UpdateDefinition<User> update = Builders<User>.Update.Set(field, value);
            _usuariosCollection.UpdateOne(usuario => usuario.id == userUpdate.id, update);
        }
        public void DeleteUser(ObjectId id)
        {
            User user = GetUserWithId(id);
            _usuariosCollection.DeleteOne(usuario => usuario.id == id);
        }


        // FUNCIONES GESTION USERS
        public ObjectId GetUserWithLoginName(string loginName)
        {
            if (!IsValidLoginName(loginName))
                return ObjectId.Empty;
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.security.loginName, loginName);
            User result = _usuariosCollection.Find(filter).FirstOrDefault();
            if (result == null)
                return ObjectId.Empty;
            else
                return result.id;
        }
        public ObjectId GetUserWithUserName(string userName)
        {
            if (!IsValidUserName(userName))
                return ObjectId.Empty;
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.userName, userName);
            User result = _usuariosCollection.Find(filter).FirstOrDefault();
            if (result == null)
                return ObjectId.Empty;
            else
                return result.id;
        }
        public User GetUserWithId(ObjectId id)
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq(user => user.id, id); // Filter.Eq("loginName", "jacinto")
            if (filter == null)
                return null;
            return _usuariosCollection.Find(filter).FirstOrDefault();
        }


        public List<User> FilterAllUsers()
        {
            return _usuariosCollection.Find(usuario => true).ToList();
        }
        public List<User> FilterUsers(DelegateFilter filter)
        {
            List<User> completeList = FilterAllUsers();
            List<User> resultList = new List<User>();
            if (filter == null)
                return completeList;
            for(int i = 0; i < completeList.Count; i++)
            {
                if (filter(completeList[i]))
                    resultList.Add(completeList[i]);
            }
            return resultList;
        }
        public bool IsValidUser(User user)
        {
            if (!IsValidLoginName(user.security.loginName))
                return false;
            if (!IsValidUserName(user.security.loginName))
                return false;
            if (!IsValidBirth(user.birthDate))
                return false;
            if (user.email == null)
                return false;
            return true;
        }

        #region FUNCIONES PRIVADAS
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
        private bool IsValidField(string field)
        {
            return field != "";
        }
        private bool IsValidValue(string value)
        {
            return value != "";
        }
        private bool IsValidLoginName(string loginName)
        {
            return loginName != "";
        }
        private bool IsValidUserName(string userName)
        {
            return userName != "";
        }
        #endregion
    }
}