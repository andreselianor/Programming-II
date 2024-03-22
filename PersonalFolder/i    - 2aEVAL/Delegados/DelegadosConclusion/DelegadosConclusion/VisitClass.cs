namespace DelegadosConclusion
{
    public class VisitClass<T>
    {
        private List<T> _list = new List<T>();

        public delegate void DelegateVisit(T visitor);

        public void Visit(DelegateVisit visitor)
        {
            if (visitor == null)
                return;

            foreach(T element in _list)
            {
                visitor(element);
            }
        }
    }
}
