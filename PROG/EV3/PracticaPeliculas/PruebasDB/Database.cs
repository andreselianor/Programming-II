namespace PruebasDB
{
    public class Database : IDatabase
    {
        private List<User> _usersList = new List<User>();        

        public long CreateUser(string name, string firstName, string phone, string email, string userName, string password)
        {
            User newUser = new User(name, firstName, phone, email, userName, password);
            if (IsValidUser(newUser))
            {                
                _usersList.Add(newUser);
                return newUser.GetHashCode();
            }
            else
            {
                throw new Exception("User is NOT valid");
            }
        }

        public void AddUser(User user)
        {
            if (IsValidUser(user))
                _usersList.Add(user);            
            else
                throw new Exception("User is NOT valid");
        }

        public void RemoveUser(User user)
        {
            if (IsValidUser(user))
            {
                for (int i = 0; i < _usersList.Count; i++)
                {
                    if (_usersList[i] == user)
                    {
                        _usersList.RemoveAt(i--);
                    }
                }
            }
            else
            {
                throw new ArgumentException("User is NOT valid");
            }
        }
        public void RemoveUserWithId(long ID)
        {
            if (ID < 0)
                throw new ArgumentException("ID is not valid");

            for(int i = 0; i < _usersList.Count;i++)
            {
                if (_usersList[i].ID == ID)
                {
                    _usersList.RemoveAt(i--);
                }
            }
        }
        public User? GetUserWithId(long id)
        {
            for (int i = 0; i < _usersList.Count; i++)
            {
                if (_usersList[i].ID == id)
                {
                    return _usersList[i];
                }
            }
            return null;
        }
        public long GetUserID(User user)
        {
            for (int i = 0; i < _usersList.Count; i++)
            {
                if (_usersList[i] == user)
                {
                    return _usersList[i].ID;
                }
            }
            return -1;
        }

        public int GetUsersCount()
        {
            return _usersList.Count;
        }


        #region FUNCIONES PRIVADAS
        private bool IsValidUser(User user)
        {
            if (!IsValidName())
                return false;
            else if (!IsValidFirstName())
                return false;
            else if (!IsValidPhone())
                return false;
            else if (!IsValidEmail())
                return false;
            else if (!IsValidUserName())
                return false;
            else if (!IsValidPassword())
                return false;
            return true;
        }


        private bool IsValidName()
        {
            return true;
        }

        private bool IsValidFirstName()
        {
            return true;
        }

        private bool IsValidPhone()
        {
            return true;
        }
        private bool IsValidEmail()
        {
            return true;
        }

        private bool IsValidUserName()
        {
            return true;
        }
        private bool IsValidPassword()
        {
            return true;
        }

        #endregion
    }
}