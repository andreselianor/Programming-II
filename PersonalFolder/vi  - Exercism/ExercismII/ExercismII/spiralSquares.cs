namespace ExercismII
{
    public class spiralSquares
    {
        public static string GetSquare(int[,] arrayResult, int columns)
        {
            if (arrayResult == null || arrayResult.Length < 0)
                return "";

            string result = "";

            for(int i = 0; i < columns;i++)
            {
                for(int j = 0; j <  columns;j++)
                {
                    result += arrayResult[i,j] + " ";
                }
                result += "\n";
            }
            return result;
        }

        public static int[,] SortNumbers(int number)
        {
            int[,] arrayResult = new int[number,number];
            int count = 1;

            int i = 0;
            int j = 0;
            
            while(count < number * number)
            {
                arrayResult[i, j] = count;
                count++;

                j++;
                arrayResult[i, j] = count;
                count++;

                j++;
                arrayResult[i, j] = count;
                count++;

                i++;
                arrayResult[i, j] = count;
                count++;

                i++;
                arrayResult[i, j] = count;
                count++;

                j--;
                arrayResult[i, j] = count;
                count++;

                j--;
                arrayResult[i, j] = count;
                count++;

                i--;
                arrayResult[i, j] = count;
                count++;

                j++;
                arrayResult[i, j] = count;
                count++;
            }
            return arrayResult;
        }
    }
}
