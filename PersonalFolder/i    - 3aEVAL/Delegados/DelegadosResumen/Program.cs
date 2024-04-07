namespace DelegadosResumen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country test = new Country();
            test.CreateCitiesList();

            List<City> listFilter = test.Filter( cityName =>
            {
                return cityName == "Valencia";
            });

            foreach(City city in listFilter)
            {
                Console.WriteLine(city.Name);
            }

            City testCity = new City();

            DelegateFilter2 comparator = delegate (int testCity) { return testCity == 2; };

            List<City> listFilter2 = test.Filter2(comparator);
        }

        
    }
}