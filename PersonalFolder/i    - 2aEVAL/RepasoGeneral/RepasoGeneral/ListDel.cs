using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGeneral
{
    public class City
    {
        public string _name;
        public int population;

        public City(string name, int population)
        {
            _name = name;
            this.population = population;
        }
    }
    public delegate bool DelegateFilter(string name);
    public delegate int DelegateSort(City city1, City city2);
    public class ListDel
    {
        public List<City> listcities;

        public void CreateList()
        {
            listcities = new List<City>();
            City c1 = new City("Madrid", 100);
            listcities.Add(c1);

            City c2 = new City("Barcelona", 50);
            listcities.Add(c2);

            City c3 = new City("Berlin", 1000);
            listcities.Add(c3);

            City c4 = new City("Roma", 200);
            listcities.Add(c4);

            City c5 = new City("Londres", 400);
            listcities.Add(c5);
        }

        public List<City> Filter(DelegateFilter del)
        {
            List<City> result = new List<City>();
            for (int i = 0; i < listcities.Count; i++)
            {
                if (del(listcities[i]._name))
                {
                    result.Add(listcities[i]);
                }
            }
            return result;
        }

        public List<City> Sort(DelegateSort del)
        {
            City aux;
            for (int i = 0; i < listcities.Count - 1; i++)
            {
                for (int j = i + 1; j < listcities.Count; j++)
                {
                    if (del(listcities[i], listcities[j]) >= 1)
                    {
                        aux = listcities[i];
                        listcities[i] = listcities[j];
                        listcities[j] = aux;
                    }
                }
            }
            return listcities;
        }
    }
}
