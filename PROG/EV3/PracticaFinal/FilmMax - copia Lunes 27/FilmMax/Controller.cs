using LibraryFilmMax;
using MongoDB.Driver;

namespace FilmMax
{
    public class Controller : ICore
    {
        private IDatabase _database = new Database();

        public IDatabase Database => _database;

        public void CreateConnection()
        {
            _database.ConnectMongoDB();
        }
    }
}