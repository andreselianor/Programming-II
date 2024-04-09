namespace DelegadosResumen
{
    public class Country
    {
        private List<City> _citiesList = new List<City>();

        public void CreateCitiesList()
        {
            City c1 = new City("Alicante", 350000);
            City c2 = new City("Valencia", 850000);
            City c3 = new City("Madrid", 1250000);
            City c4 = new City("Sevilla", 950000);
            City c5 = new City("Barcelona", 1100000);
            City c6 = new City("Bilbao", 870000);
            City c7 = new City("Pontevedra", 250000);

            _citiesList = new List<City>() { c1, c2, c3, c4, c5, c6, c7 };
        }

        #region Delegate Filter
        public delegate bool DelegateFilterPlain();
        public List<City> Filter(DelegateFilterPlain filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter())
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }

        public delegate bool DelegateFilterWithInt(int population);
        public List<City> Filter(DelegateFilterWithInt filter)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count; i++)
            {
                if (filter(_citiesList[i].Population))
                {
                    result.Add(_citiesList[i]);
                }
            }
            return result;
        }

        public delegate bool DelegateFilterWithString(string name);
        public List<City> Filter(DelegateFilterWithString filter)
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

        public bool Filter()
        {
            List<City> result = new List<City>();
            
            return true;
        }
        #endregion


        public delegate int DelegateSort(City c1, City c2);
        public List<City> Sort(DelegateSort comparator)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < _citiesList.Count - 1; i++)
            {
                for (int j = i + 1; j < _citiesList.Count; j++)
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