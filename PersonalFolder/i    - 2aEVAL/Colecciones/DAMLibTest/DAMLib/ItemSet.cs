﻿using System.Xml.Linq;

namespace DAMLib
{
    public class ItemSet<T>
    {
        private Item[] _itemset;

        private class Item
        {
            public T Element;
            public int Hash;

            public Item()
            {
                
            }
            public Item(T element, int hash)
            {
                Element = element;
                Hash = hash;
            }
        }

        public int Count
        {
            get
            {
                if (_itemset == null)
                    return 0;
                return _itemset.Length;
            }
        }

        public bool IsEmpty => _itemset.Length == 0;


        public ItemSet()
        {
            _itemset = new Item[0];
        }


        public int GetIndexOf(T element)
        {
            if (element == null)
                return -1;

            int hash = element.GetHashCode();

            for (int i = 0; i < _itemset.Length; i++)
            {
                Item item = _itemset[i];
                if (hash == item.Hash && item.Element.Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            return GetIndexOf(element) >= 0;
        }

        public void Add(T element)
        {
            if (element == null)
                return;

            if (Contains(element))
                return;
            else
                AddElement(element);
        }

        private void AddElement(T element)
        {
            if (element == null)
                return;

            int newLength = _itemset.Length + 1;
            Item[] newItemArray = new Item[newLength];

            int hash = element.GetHashCode();
            Item newItem = new Item(element, hash);

            for (int i = 0; i < newLength - 1; i++)
            {
                newItemArray[i] = _itemset[i];
            }
            newItemArray[newLength - 1] = newItem;

            _itemset = newItemArray;
        }

        public void Remove(T element)
        {
            if (element == null)
                return;

            int index = GetIndexOf(element);
            if (index < 0)
                return;

            int newLength = _itemset.Length - 1;
            Item[] newItemArray = new Item[newLength];


            for (int i = 0; i < index; i++)
            {
                newItemArray[i] = _itemset[i];
            }

            for (int i = index; i < newLength; i++)
            {
                newItemArray[i] = _itemset[i + 1];
            }

            _itemset = newItemArray;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _itemset.Length)
                return;

            int newLength = _itemset.Length - 1;
            Item[] newItemArray = new Item[newLength];


            for (int i = 0; i < index; i++)
            {
                newItemArray[i] = _itemset[i];
            }

            for (int i = index; i < newLength; i++)
            {
                newItemArray[i] = _itemset[i + 1];
            }

            _itemset = newItemArray;
        }

        private bool Equals(Item[] items)
        {
            if (items == null)
                return false;

            for(int i = 0; i < _itemset.Length; i++)
            {
                if (_itemset[i] != items[i])
                    return false;                
            }
            return true;
        }

        private bool EqualsDeep(Item[] items)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 133 * 533 * 224 * _itemset.GetHashCode();
        }

        public override string ToString()
        {
            string result = "";
            int count = 0;

            foreach (Item item in _itemset)
            {
                result = $"El elemento numero {count} del Set es {item.element}";
                count++;
            }
            return result;
        }

        public void Clear()
        {
            _itemset = new Item[0];
        }
    }
}