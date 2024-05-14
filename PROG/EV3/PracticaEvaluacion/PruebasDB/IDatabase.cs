namespace PruebasDB
{
    public interface IDatabase
    {
        void DisplayDatabase();
        long CreateUser(string name, string firstName, string phone, string email, string userName, string password);

        User? GetUserWithId(long id);
        long GetUserID(User user);

        void RemoveUser(User user);
        void RemoveUserWithId(long ID);
    }
}