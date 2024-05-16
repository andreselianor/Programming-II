using System.Text.Json;

namespace LibraryFilmMax
{
    public class Database : IDatabase
    {
        private Data _data = new Data();

        public void CreateDatabase()
        {
            string path = "../../../RSC/usuariosFilmMax.json";
            string jsonDataBase = File.ReadAllText(path);

            _data = JsonSerializer.Deserialize<Data>(jsonDataBase);
        }

        public bool LoginUser(string user, string password)
        {
            for (int i = 0; i < _data.user.Length; i++)
            {
                if (user == _data.user[i].security.userName &&
                    password == _data.user[i].security.userPassword)
                    return true;
            }
            return false;
        }
    }
}