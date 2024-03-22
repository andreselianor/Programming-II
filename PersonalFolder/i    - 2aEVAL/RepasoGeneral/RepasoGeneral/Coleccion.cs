namespace RepasoGeneral
{
    public class Coleccion
    {
        private List<int> list = new List<int>();

        public List<int> Clone()
        {
            List<int> clone = new List<int>();
            foreach(int i in list)
            {
                clone.Add(i);
            }
            return clone;
        }

        public void Add(int number)
        {
            list.Add(number);
        }

        public List<int> GetList()
        {
            return list;
        }
    }
}
