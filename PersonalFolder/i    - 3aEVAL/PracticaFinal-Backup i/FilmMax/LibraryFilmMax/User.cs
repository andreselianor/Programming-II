﻿namespace LibraryFilmMax
{
    public class UserTest
    {
        public string name { get; set; }
        public string pass { get; set; }
        public object id { get; set; }
    }

    
    public class User
    {
        public object id { get; set; }
        public Security security { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public BirthDate birthDate { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string favouriteFilms { get; set; }
    }
    public class Security
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
    }
    public class BirthDate
    {
        public int dayDate { get; set; }
        public int monthDate { get; set; }
        public int yearDate { get; set; }
    }    
}