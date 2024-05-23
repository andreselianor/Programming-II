using LibraryFilmMax;

namespace FilmMax
{
    public interface ICore
    {
        void CreateConnection();

        User GetUserWithLoginName(string loginName);
        User GetUserAtIndex(int index);

        int GetIndexOf(User user);
        List<User> GetAllUsers();

        
        void DeleteUserWithLoginName(string loginName);
        void CreateUser(User user);
        
        
    }
}