namespace PruebasDB
{
    public class User
    {
        private long _id;

        private Security _security = new Security();

        private string _name = string.Empty;
        private string _firstName = string.Empty;

        private string _phoneNumber = string.Empty;
        private string _email = string.Empty;

        public long ID => _id;

        public User() { }

        public User(string name, string firstName, string phoneNumber, string email, string username, string password)
        {
            _name = name;
            _firstName = firstName;
            _phoneNumber = phoneNumber;
            _email = email;

            _security = new Security(username, password);
        }
    }
}
