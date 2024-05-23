using LibraryFilmMax;
using MongoDB.Driver;

namespace FilmMax
{
    /*
    public class Controller : ICore
    {
        private IMongoDatabase _database;
        public IMongoCollection<User> _usuariosCollection;

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
        public User GetUserAtIndex(int index)
        {
            if (index < 0)
                return null;        // TODO index valido
            List<User> usersList = GetAllUsers();
            return usersList[index];
        }
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
        public void RemoveUserWithLoginName(string name)
        {
            _usuariosCollection.DeleteOne(usuario => usuario.security.loginName == name);
        }
        public void InsertUser(User user)
        {
            _usuariosCollection.InsertOne(user);
        }
    }*/
}