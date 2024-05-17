namespace LibraryFilmMax
{
    public interface IDatabase
    {
        long CreateUser();
        void UpdateUser();
        void RemoveUser();


        int CreateFilm();
        void UpdateFilm();
        void RemoveFilm();
    }
}