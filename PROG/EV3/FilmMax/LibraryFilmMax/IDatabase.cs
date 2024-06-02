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
        void UpdateUser(ObjectId id, string field, string value);
        void DeleteUser(ObjectId id);


        ObjectId GetUserWithLoginName(string loginName);
        ObjectId GetUserWithUserName(string userName);
        User GetUserWithId(ObjectId id);


        List<User> FilterAllUsers();
        List<User> FilterUsers(DelegateFilter filter);
        bool IsValidUser(User user);
    }
}