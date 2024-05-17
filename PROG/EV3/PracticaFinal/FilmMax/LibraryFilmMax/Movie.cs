namespace LibraryFilmMax
{
    public enum GENRE
    {
        DRAMA,
        COMEDY
    }
    public class MovieDB
    {
        private List<Movie> moviesDB = new List<Movie>();


        public Movie CreateMovie()
        {
            Movie newMovie = new Movie();
            return newMovie;
        }
        public int AddMovie(Movie movie)
        {
            if (!IsValidMovie(movie))
            {
                throw new ArgumentNullException();
            }
            else
            {
                moviesDB.Add(movie);
                return movie.GetHashCode();
            }
        }
        public void RemoveMovie(Movie movie)
        {
            if (!IsValidMovie(movie))
            {
                throw new ArgumentNullException("error code");
            }
            else
            {
                for (int i = 0; i < moviesDB.Count; i++)
                {
                    if (moviesDB[i] == movie)
                        moviesDB.RemoveAt(i--);
                }
            }            
        }
        public void UpdateMovie(Movie movie)
        {
            if (!IsValidMovie(movie))
            {
                throw new ArgumentNullException("error code");
            }
            else
            {
                //UPDATE
                //moviesDB.Add(movie);
            }
        }

        private bool IsValidMovie(Movie movie)
        {
            return true;
        }
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