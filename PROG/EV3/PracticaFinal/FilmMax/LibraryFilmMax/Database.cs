using System.Text.Json;

namespace LibraryFilmMax
{
    public class Database : IDatabase
    {
        private UserDB _usersDB = new UserDB();
        private MovieDB _movieDB = new MovieDB();


        public void LoadDatabaseFromLocalJSON(string path)
        {
            try
            {
                string jsonDataBase = File.ReadAllText(path);
                _usersDB = JsonSerializer.Deserialize<UserDB>(jsonDataBase);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public UserDB UsersToArray()
        {
            int count = _usersDB.user.Length;
            UserDB clone = new UserDB();
            clone.user = new Users[count];
            for (int i = 0; i < count; i++)
            {
                clone.user[i] = _usersDB.user[i];
            }
            return clone;
        }


        public long CreateUser()
        {
            throw new NotImplementedException();
        }
        public void RemoveUser()
        {
            throw new NotImplementedException();
        }
        public void UpdateUser()
        {
            throw new NotImplementedException();
        }


        public int AddFilm(Movie movie)
        {
            int id = _movieDB.AddMovie(movie);
            return id;
        }
        public void UpdateFilm(Movie movie)
        {
            _movieDB.UpdateMovie(movie);
        }
        public void RemoveFilm(Movie movie)
        {
            _movieDB.RemoveMovie(movie);
        }



        public void LoadDatabaseFromServer()
        {
            throw new NotImplementedException();
        }
    }
}