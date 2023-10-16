using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCrazyRace
{
    public class ClaseGenericos<T>
    {
        private T _obj1;
        private List<T> _list = new List<T>();

        public T Objeto
        {
            get { return _obj1; }
        }

        public List<T> List
        {
            get { return _list; }
        }

        public List<T> AddObject(T obj1)
        {
            _list.Add(obj1);
            return _list;
        }
    }
}
