namespace LibraryFilmMax
{
    public class Database : IDatabase
    {
        private List<User> _usersList = new List<User>();

        public void CreateDatabase()
        {
            User user1 = new User();
            user1.UserName = "test";
            user1.UserPassword = "test";

            _usersList.Add(user1);
        }

        public bool LoginUser(string user, string password)
        {
            foreach(User userData in _usersList)
            {
                if (user == userData.UserName && password == userData.UserPassword)
                    return true;
            }
            return false;
        }
    }
}
