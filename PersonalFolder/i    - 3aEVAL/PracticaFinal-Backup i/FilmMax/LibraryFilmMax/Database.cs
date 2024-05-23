using System.Text.Json;

namespace LibraryFilmMax
{
    public class Database : IDatabase
    {
        private List<User> _usersList = new List<User>();

        public void LoadDatabaseFromLocal(string path)
        {
            try
            {
                string jsonDataBase = File.ReadAllText(path);
                User u = JsonSerializer.Deserialize<User>(jsonDataBase);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void LoadDatabaseFromServer()
        {
            throw new NotImplementedException();
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


        public void RemoveMovie()
        {
            throw new NotImplementedException();
        }
        public int CreateMovie()
        {
            throw new NotImplementedException();
        }
        public void UpdateMovie()
        {
            throw new NotImplementedException();
        }
    }
}