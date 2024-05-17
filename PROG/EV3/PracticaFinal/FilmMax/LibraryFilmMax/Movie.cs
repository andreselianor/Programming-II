namespace LibraryFilmMax
{
    public enum GENRE
    {
        DRAMA,
        COMEDY
    }
    public class Movie
    {
        public string title { get; set; }
        public int year { get; set; }
        public GENRE genre { get; set; }
        public List<Acter> acters { get; set; }
    }
    public class Acter
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }    
}