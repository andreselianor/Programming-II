using MongoDB.Driver;

namespace LibraryFilmMax
{
    public interface IDatabase
    {
        void ConnectMongoDB();
        IMongoDatabase DatabaseMongo { get; }
        IMongoCollection<User> UsersCollection { get; }


        long CreateUser(User user);
        void ReadUser(User user);
        void UpdateUser(User user, string field, string value);
        void DeleteUser(User user);


        int CreateMovie();
        void ReadMovie();
        void UpdateMovie();
        void DeleteMovie();


        
        List<User> GetAllUsers();
        int GetIndexOf(User user);
        User GetUserWithLoginName(string loginName);
        User GetUserAtIndex(int index);
        bool IsValidUser(User user);
    }
}