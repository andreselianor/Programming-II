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
        }
    }
}