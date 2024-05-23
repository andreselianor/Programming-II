using LibraryFilmMax;
using MongoDB.Driver;

namespace FilmMax
{
    public class Controller : ICore
    {
        private IDatabase _database = new Database();

        public void CreateConnection()
        {
            _database.ConnectMongoDB();
        }

        public List<User> GetAllUsers() => _database.GetAllUsers();
        public void CreateUser(User user) => _database.CreateUser(user);
        public void DeleteUserWithLoginName(string loginName) => _database.DeleteUser(loginName);

        public User GetUserWithLoginName(string loginName) => _database.GetUserWithLoginName(loginName);
        public User GetUserAtIndex(int index) => _database.GetUserAtIndex(index);
        public int GetIndexOf(User user) => _database.GetIndexOf(user);        
    }
}