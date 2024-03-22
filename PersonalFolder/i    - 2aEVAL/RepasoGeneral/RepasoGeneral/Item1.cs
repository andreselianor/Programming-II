using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGeneral
{
    public class Item1<T>
    {
        private Item _item;
        public Item ItemGet => _item;

        public class Item
        {
            public T _attribute1;
            public T _attribute2;

            public int GetAttribute()
            {
                return 1;
            }
        }
        public Item Clone()
        {
            return _item;
        }

        public Item1() { }

        public void SetAttribute1(T attribute1)
        {
            _item._attribute1 = attribute1;
        }
        public void Test()
        {
            _item.GetAttribute();
        }
    }
}
