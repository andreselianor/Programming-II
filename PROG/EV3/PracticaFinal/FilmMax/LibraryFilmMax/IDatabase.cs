namespace LibraryFilmMax
{
    public interface IDatabase
    {
        void CreateDatabase();
        bool LoginUser(string user, string password);
    }
}
