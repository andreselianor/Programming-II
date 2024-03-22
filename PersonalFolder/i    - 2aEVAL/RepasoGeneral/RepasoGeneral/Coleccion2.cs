using System.Collections.Generic;

namespace RepasoGeneral
{
    public class Coleccion2<T>
    {
        private List<T> list = new List<T>();

        public List<T> Clone()
        {
            List<T> clone = new List<T>();
            foreach (T i in list)
            {
                clone.Add(i);
            }
            return clone;
        }

        public void Add(T number)
        {
            list.Add(number);
        }
    }
}
