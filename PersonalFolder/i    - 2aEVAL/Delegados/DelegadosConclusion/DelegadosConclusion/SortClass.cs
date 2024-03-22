namespace DelegadosConclusion
{
    public class SortClass<T>
    {
        private List<T> _list = new List<T>();

        public delegate int DelegateSort(T element1, T element2);

        public List<T> Sort(DelegateSort comparison)
        {
            if (comparison == null)
                return null;

            List<T> listSort = new List<T>();

            for(int i = 0; i < _list.Count - 1; i++)
            {
                for(int j = i + 1; i < _list.Count; j++)
                {
                    if (comparison(_list[i], _list[j]) >= 1)
                    {
                        T aux;
                        aux = _list[i];
                        _list[j] = _list[i];
                        _list[j] = aux;
                    }
                }
            }
            return listSort;
        }
    }
}