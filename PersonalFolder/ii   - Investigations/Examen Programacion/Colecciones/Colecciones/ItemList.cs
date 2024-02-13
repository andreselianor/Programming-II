namespace Colecciones
{
    public class ItemList : IList<string>
    {
        public List<int> listInt;
        public List<char> listChar;
        public List<string> listString;
        public List<City> listCities;
        public List<City, string> _listCityCombination;
        public List<Fact<double>> _genericLsit;
        public Fact<int> _listFact;
        public Fact<string> _listFactString;
        public class City
        {
            private string _name;
            private int _population;
        }

        public class Fact<T>
        {
            private string _description;
        }
    }

    public class ItemListTest
    {
        public void Proof1()
        {
            ItemList i1 = new ItemList();
            int count = i1.listInt.Count;
        }
    }
}
