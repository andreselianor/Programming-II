﻿namespace LibraryFilmMax
{
    public class Data
    {
        public UserData[] user { get; set; }
    }
    public class UserData
    {
        public SecurityData security { get; set; }
    }

    public class SecurityData
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
}
