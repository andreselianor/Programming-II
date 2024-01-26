namespace ExercismII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "pepe", "juan" , "Aurelio"};
            int[] array1 = new int[] { 5,10,15,20 };
            int number = 25;

            int resultIndex = BinarySearch.GetIndexWithBinarySearch(array1, number);
            
        }
        
    }
}