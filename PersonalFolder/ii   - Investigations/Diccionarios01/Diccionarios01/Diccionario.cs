namespace Diccionarios01
{
    public class Diccionario
    {
        private Dictionary<int, string> _dictionaryEcos;
        private string[,] _arrayEcos;

        public Diccionario()
        {
            _dictionaryEcos = new Dictionary<int, string>();
            _arrayEcos = new string[0, 0];
        }

        public Diccionario(int capacity)
        {
            _dictionaryEcos = new Dictionary<int, string>();
            _arrayEcos = new string[capacity,capacity];
        }

        public void AddValueToDict(int index, string value)
        {
            _dictionaryEcos.Add(index, value);
        }

        public void AddValueToArray(int index, string value)
        {
            _arrayEcos[index,index] = value;
        }
    }
}
