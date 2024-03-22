namespace RepasoGeneral
{
    public class ItemList
    {
        public delegate Item DelegateRemoveAll(int index);
        public delegate bool DelegateRemoveAll2<Item>();
        private List<Item> _listItem = new List<Item>();

        public class Item
        {
            public int _value;
            public string _description;
        }

        public int GetItemsCount()
        {
            return _listItem.Count;
        }

        public int GetIndexOf(Item item)
        {
            for (int i = 0; i < _listItem.Count; i++)
            {
                if (_listItem[i] == item)
                    return i;
            }
            return -1;
        }
        public Item GetItemAt(int index)
        {
            return _listItem[index];
        }

        public void RemoveAllOcurrences(Predicate<Item> del)
        {            
            _listItem.RemoveAll(del);
        }
    }
}
