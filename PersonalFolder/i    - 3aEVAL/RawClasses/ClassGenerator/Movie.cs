namespace ClassGenerator
{
    public class Movie
    {
        private string _name;
        private DateOnly _date;
        private string _director;
        private List<Acter> _listCharacters;
        private string _sinopsis;

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetDate(DateOnly date)
        {
            _date = date;
        }

        public void SetDirector(string director)
        {
            _director = director;
        }

        public void SetCharacters(List<Acter> list)
        {
            _listCharacters = list;
        }

        public void SetSinopsis(string sinopsis)
        {
            _sinopsis = sinopsis;
        }
    }

    public class Series
    {
        private string _name;
        private DateOnly _date;
    }

    public class Acter
    {
        private string _name;
        private string _surname;
        private DateOnly _birth;
        private int _age;
        private List<Movie> _bestFilms;
        private List<Series> _bestSeries;

        public string Name => _name;
    }

    public class Cinema
    {
        private List<Movie> _moviesList = new List<Movie>();

        public void CreateList()
        {
            Movie movie1 = new Movie();
            movie1.SetName("Human Nature");
            movie1.SetDate(new DateOnly(2011, 1, 1));

            _moviesList.Add(movie1);
        }

    }
}