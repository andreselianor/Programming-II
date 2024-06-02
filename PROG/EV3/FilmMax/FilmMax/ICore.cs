using LibraryFilmMax;
using MongoDB.Driver;

namespace FilmMax
{
    public interface ICore
    {
        void CreateConnection();
        IDatabase Database { get; }

        /*
        User GetUserWithLoginName(string loginName);
        User GetUserAtIndex(int index);
        int GetIndexOf(User user);
        List<User> GetAllUsers();

        bool IsValidUser(User user);

        void DeleteUserWithLoginName(string loginName);
        void CreateUser(User user);
        */
    }
}