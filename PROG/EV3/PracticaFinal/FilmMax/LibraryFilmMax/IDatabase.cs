using MongoDB.Bson;
using MongoDB.Driver;

namespace LibraryFilmMax
{
    public interface IDatabase
    {
        void ConnectMongoDB();
        IMongoDatabase DatabaseMongo { get; }
        IMongoCollection<User> UsersCollection { get; }


        ObjectId CreateUser(User user);
        User ReadUser(User user);
        void UpdateUser(User user, string field, string value);
        void DeleteUser(User user);


        ObjectId CreateMovie(Movie movie);
        void ReadMovie(Movie movie);
        void UpdateMovie(Movie movie, string field, string value);
        void DeleteMovie(Movie movie);


        
        List<User> GetAllUsers();
        int GetIndexOf(User user);
        User? GetUserWithLoginName(string loginName);
        User? GetUserAtIndex(int index);
        bool IsValidUser(User user);
    }
}