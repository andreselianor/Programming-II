namespace JSONTEST
{
    public class Test2
    {
        public UserData[] user { get; set; }

    }
    public class UserData
    {
        public int id { get; set; }
        public SecurityData security { get; set; }
    }
    public class SecurityData
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
}