namespace LibraryFilmMax
{
    public class OldTest
    {
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
    }
}