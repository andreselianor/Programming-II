using LibraryFilmMax;
using System.Text.Json;

namespace FilmMax
{
    public class Controller
    {
        private IDatabase _database = new Database();
        private readonly string JSONPath = "../../../RSC/usuariosFilmMax.json";

        public Controller()
        {
            _database.LoadDatabaseFromLocalJSON(JSONPath);
        }

        public bool LoginUser(string user, string password)
        {
            UserDB users = _database.UsersToArray();

            for (int i = 0; i < users.user.Length; i++)
            {
                if (user == users.user[i].security.userName &&
                    password == users.user[i].security.userPassword)
                    return true;
            }
            return false;
        }
    }
}