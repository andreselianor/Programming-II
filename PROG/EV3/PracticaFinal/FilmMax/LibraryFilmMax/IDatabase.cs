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
        User ReadUser(ObjectId id);
        void UpdateUser(ObjectId id, string field, string value);
        void DeleteUser(ObjectId id);

        bool IsValidUser(User user);

        List<User> GetAllUsers();
        User GetUserWithID(ObjectId id);
        User? GetUserWithLoginName(string loginName);
        User? GetUserWithUserName(string userName);
        User? GetUserWithPhone(string phone);
        User? GetUserWithEmail(string email);
    }
}