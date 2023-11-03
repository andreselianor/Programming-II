namespace ResumenFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                int number = Utils.GetRandom();
                list.Add(number);
            }
            
        }
    }
}