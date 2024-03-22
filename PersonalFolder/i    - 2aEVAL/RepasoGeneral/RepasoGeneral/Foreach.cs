namespace RepasoGeneral
{
    public class Foreach
    {
        Dictionary<int, string> dictionary1 = new Dictionary<int, string>();

        List<string> list = new List<string>();

        public void CreateList()
        {
            list = new List<string> { "Jorge", "Jose", "Jere", "Jaime", "Javier", "Jimenez", "Jut" };
        }

        public void AddValuesToDictionary()
        {
            //foreach('tipo' 'nombreVariable' 'in' 'contenedor')
            int count = 0;
            foreach(string value in list)
            {
                dictionary1[count] = value;
                count++;
            }
        }

        public void AddValuesToDictionary2()
        {
            int count = 0;
            foreach (string value in list)
            {
                dictionary1.Add(count, value);
                count++;
            }
        }

        public void DisplayDictionary()
        {
            foreach(KeyValuePair<int,string> value in dictionary1)
            {
                Console.WriteLine(value);
                //Console.WriteLine(value.Key);
                //Console.WriteLine(value.Value);
                //Console.WriteLine(value.Key + " " + value.Value);
            }
        }

        public void Clear()
        {
            dictionary1 = new Dictionary<int, string>();
        }
    }
}