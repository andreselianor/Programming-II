namespace ResumenFunciones
{
    public class Dictionary
    {       
        // CONSTRUCTORES
        public Dictionary<int, string> presetDictionary1 = new Dictionary<int, string>
        {
            [0] = "Portero",
            [1] = "Central",
            [2] = "Central Derecho"
        };

        public Dictionary<int, string> presetDictionary2 = new Dictionary<int, string>
        {
            {9,"Delantero" }, {10, "Punta" }, {11,"Falso Nueve" }
        };

        public Dictionary<char, string> newPresetDictionary = new Dictionary<char, string>();


        // ADD VALUES
        public static Dictionary<int, string> AddValueToDictionary(Dictionary<int, string> dictionary, int key, string value)
        {
            dictionary.Add(key, value);
            return dictionary;
        }

        public void AddValueToDictionary(int key, string value)
        {
            presetDictionary1.Add(key, value);
            presetDictionary2.Add(key, value);
        }

        // GETTERS        

        public static string GetValue(Dictionary<int, string> dictionary, int number)
        {
            return dictionary[number];
        }

        public (string, string) GetValue(int number)
        {
            return (presetDictionary1[number], presetDictionary2[number]);
        }


        // LISTING DICTIONARIES
        public static void ListDictionary(Dictionary<int, string> dictionary)
        {
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("" + item.Key + " : " + item.Value);
            }
        }

        public void ListDictionary()
        {
            foreach (KeyValuePair<int, string> item in presetDictionary1)
            {
                Console.WriteLine("" + item.Key + " : " + item.Value);
            }

            foreach (KeyValuePair<int, string> item in presetDictionary2)
            {
                Console.WriteLine("" + item.Key + " : " + item.Value);
            }
        }

        public void ListDictionary(int index)
        {
            Console.WriteLine(presetDictionary1[index]);
            KeyValuePair<int, string> result = presetDictionary1.ElementAt(index);
            Console.WriteLine(result.Key);
            Console.WriteLine(result.Value);
        }
        public static void ToString(Dictionary<int, string> dictionary)
        {
            int key = dictionary.ElementAt(0).Key;
            string result = key.ToString();

            string value = dictionary.ElementAt(0).Value;
            string resultValue = value.ToString();

            Console.WriteLine(result + ", " + resultValue);
        }
    }
}