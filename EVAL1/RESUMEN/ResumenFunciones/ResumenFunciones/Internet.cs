namespace ResumenFunciones
{
    public class Internet
    {
        public Dictionary<int, string> _dictionary = new Dictionary<int, string>();
        public Dictionary<char, string> _dictionary2 = new Dictionary<char, string>();

        public void SetDictionary()
        {
            _dictionary.Add(0, "Maria");
            _dictionary.Add(1, "Efigenio");
            _dictionary.Add(2, "Carcelen");
            _dictionary[3] = "Eulalio";
        }

        public void SetDictionary2()
        {
            _dictionary2.Add('a', "Bollylomples");
            _dictionary2.Add('e', "VisiMisi");
            _dictionary2.Add('i', "Bobina");
        }

        public void ListDictionary()
        {
            foreach (KeyValuePair<int,string> item in _dictionary)
            {
                Console.WriteLine("" + item.Key + " " + item.Value);
            }
        }

        public void ListDictionary2()
        {
            foreach(var item in _dictionary2)
            {
                Console.WriteLine("" + item.Key + " " + item.Value);
            }
        }

        public void GetListDictionary(int number)
        {
            Console.WriteLine(_dictionary[number]);
        }

        public void GetListDictionary2(int number)
        {
            Console.WriteLine(_dictionary2['a']);
            KeyValuePair<char, string> result = _dictionary2.ElementAt(number);
            Console.WriteLine(result.Key);
            Console.WriteLine(result.Value);
        }

        public void GetDateNow()
        {            
            Console.WriteLine(DateTime.Now);
        }

        public void ToStringData()
        {
            char char1  = _dictionary2.ElementAt(0).Key;
            string result = char1.ToString();
            Console.WriteLine(result);
        }
    }
}
