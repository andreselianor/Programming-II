namespace PruebasDB
{
    public class Security
    {
        private string _username = string.Empty;
        private string _password = string.Empty;

        public string Username => _username;
        public string Password => _password;


        public Security() { }
        public Security(string username, string password)
        {
            _username = username;
            _password = password;
        }


        public void SetUsername(string username)
        {
            _username = username;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }
    }
}
