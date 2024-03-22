namespace DelegadosConclusion
{

    public class FilterClass<T>
    {
        private List<T> _list = new List<T>();

        public delegate bool DelegateFilter(T element);

        public List<T> Filter(DelegateFilter del)
        {
            if (del == null)
                return null;

            List<T> filterList = new List<T>();

            for (int i = 0; i < _list.Count; i++)
            {
                if (del(_list[i]))
                    filterList.Add(_list[i]);
            }

            return filterList;
        }
    }
}