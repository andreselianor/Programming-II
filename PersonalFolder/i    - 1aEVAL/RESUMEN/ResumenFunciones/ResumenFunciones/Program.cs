namespace ResumenFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(array[^1]);

            Range range = 2..4;
            foreach (int i in array[range])
            {
                Console.WriteLine(i);
            }
            
        }
    }
}