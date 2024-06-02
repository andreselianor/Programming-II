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
        User GetUser(ObjectId id);
        void UpdateUser(ObjectId id, string field, string value);
        void DeleteUser(ObjectId id);


        List<User> GetAllUsers();
        ObjectId GetUserWithLoginName(string loginName);
        ObjectId GetUserWithUserName(string userName);
        bool IsValidUser(User user);
    }
}