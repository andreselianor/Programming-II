namespace DelegadosResumen
{
    public class FunctionCall
    {
        public void CallingFirst()
        {
            Country country = new Country();
            country.CreateCitiesList();

            // Devuelve todos los componentes de la lista original.
            List<City> listResult = country.Filter(() =>
            {
                return true;
            });

            // Otra sintaxis de igual resultado.
            List<City> listResultAlt = country.Filter(() => true);

            DisplayingResult(listResult);
            Console.WriteLine();
            DisplayingResult(listResultAlt);
        }

        public void CallingSecond()
        {
            Country country = new Country();
            country.CreateCitiesList();

            List<City> listResult = country.Filter((numberPop) => { return numberPop > 1000000; });

            DisplayingResult(listResult);
        }

        public void CallingThird()
        {
            Country country = new Country();
            country.CreateCitiesList();

            List<City> listResult = country.Filter((numberPop) => { return (numberPop > 500000) && (numberPop < 1000000); });

            DisplayingResult(listResult);
        }

        public void CallingFourth()
        {
            Country country = new Country();
            country.CreateCitiesList();

            List<City> listResult = country.Filter((name) => { return name[0] == 'A'; });

            DisplayingResult(listResult);
        }

        public void CallingFiveth()
        {
            Country country = new Country();
            country.CreateCitiesList();

            // Funciones anónimas.
            Country.DelegateFilterPlain delegado = delegate () { return true; };
            List<City> listResult = country.Filter(delegado);

            DisplayingResult(listResult);
        }

        public void CallingSixth()
        {
            Country country = new Country();
            country.CreateCitiesList();

            Country.DelegateFilterPlain delegado = new Country.DelegateFilterPlain(country.Filter);
            List<City> listResult = country.Filter(delegado);

            DisplayingResult(listResult);
        }



        public void DisplayingResult(List<City> list)
        {
            foreach (City c in list)
            {
                Console.WriteLine(c.Name + " with " + c.Population + " population.");
            }
        }
    }
}
