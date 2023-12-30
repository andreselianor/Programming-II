namespace ExercismII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            spiralSquares sq1 = new spiralSquares();
            int[,] array = spiralSquares.SortNumbers(3);
            Console.WriteLine(spiralSquares.GetSquare(array, 3));
        }
    }
}