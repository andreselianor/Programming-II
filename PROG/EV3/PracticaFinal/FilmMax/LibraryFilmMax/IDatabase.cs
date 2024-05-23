using MongoDB.Driver;

namespace LibraryFilmMax
{
    public interface IDatabase
    {
        void ConnectMongoDB();
        IMongoDatabase DatabaseMongo { get; }
        IMongoCollection<User> UsersCollection { get; }


        long CreateUser(User user);
        void ReadUser();
        void UpdateUser();
        void DeleteUser(string loginName);


        int CreateMovie();
        void ReadMovie();
        void UpdateMovie();
        void DeleteMovie();


        
        List<User> GetAllUsers();
        int GetIndexOf(User user);
        User GetUserWithLoginName(string loginName);
        User GetUserAtIndex(int index);
    }
}