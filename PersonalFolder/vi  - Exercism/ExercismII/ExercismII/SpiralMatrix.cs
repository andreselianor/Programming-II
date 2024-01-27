namespace ExercismII
{
    public class SpiralMatrix
    {
        public static int[,] GetMatrix(int size)
        {
            int[,] result = new int[size, size];
            int count = 1;

            int finalNumber = size * size;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = count;
                    count++;
                }
            }
            return result;
        }

        public static void Display(int[,] matrix)
        {

            string result = "";

            int Xsize = matrix.GetLength(0);
            int Ysize = matrix.GetLength(1);


            for (int i = 0; i < Xsize; i++)
            {
                for (int j = 0; j < Ysize; j++)
                {
                    result += matrix[i, j] + " ";
                }
                result += "\n";
            }
            Console.WriteLine(result);
        }
    }
}
