using System.Security.Cryptography;

namespace DelegadosResumen
{
    public delegate bool DelegateFilter2(int city);
    public class Country
    {
        private List<City> _citiesList = new List<City>();

        public void CreateCitiesList()
        {
            City c1 = new City("Alicante");
            City c2 = new City("Valencia");
            City c3 = new City("Madrid");
            City c4 = new City("Sevilla");
            City c5 = new City("Barcelona");
            City c6 = new City("Bilbao");
            City c7 = new City("Pontevedra");

            _citiesList = new List<City>() { c1, c2, c3, c4, c5, c6, c7 };
        }

        public delegate bool DelegateFilter(string name);
        public List<City> Filter(DelegateFilter filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter(_citiesList[i].Name))
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }

        
        public List<City> Filter2(DelegateFilter2 filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter(_citiesList[i]))
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }

        public delegate int DelegateSort(City c1, City c2);

        public List<City> Sort(DelegateSort comparator)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count - 1; i++)
            {
                for (int j = j + 1; j < _citiesList.Count; j++)
                {
                    if (comparator(_citiesList[i], _citiesList[j]) >= 1)
                    {
                        City aux;
                        aux = _citiesList[i];
                        _citiesList[i] = _citiesList[j];
                        _citiesList[j] = aux;
                    }
                }
            }
            _citiesList = result;
            return result;
        }

        public delegate void DelegateVisit(City city);

        public void Visit()
        {
            foreach(City city in _citiesList)
            {

            }
        }
    }
}