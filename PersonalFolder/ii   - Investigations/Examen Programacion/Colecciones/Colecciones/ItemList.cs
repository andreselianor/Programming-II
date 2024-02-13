namespace Colecciones
{
    public class ItemList : IList
    {
        public List<int> listInt;
        public List<char> listChar;
        public List<string> listString;
        public List<City> listCities;
        public DoubleList<int, string> _listCityCombination;
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

        public class DoubleList<T, U>
        { 

        }


        #region Funciones Interfaz
        public void AddElement(object element)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public List<object> Clone()
        {
            throw new NotImplementedException();
        }

        public void ContainsElement(object element)
        {
            throw new NotImplementedException();
        }

        public void Filter()
        {
            throw new NotImplementedException();
        }

        public object GetElementAt(int index)
        {
            throw new NotImplementedException();
        }

        public int GetIndexOf(object element)
        {
            throw new NotImplementedException();
        }

        public int GetListCount()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsSort()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void RemoveElement(object element)
        {
            throw new NotImplementedException();
        }

        public void RemoveElementAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public void Visit()
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    public class ItemListTest
    {
        public void Proof1()
        {
            ItemList i1 = new ItemList();
            int count = i1.listInt.Count;

            ItemList.City c1 = new ItemList.City();
        }
    }
}