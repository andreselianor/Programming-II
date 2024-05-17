namespace LibraryFilmMax
{
    public interface IDatabase
    {
        long CreateUser();
        void UpdateUser();
        void RemoveUser();


        int CreateMovie();
        void UpdateMovie();
        void RemoveMovie();
    }
}