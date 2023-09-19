namespace Functions
{
    public class Functions
    {
        
        public static int GetSumatory1(int number)
        {
            int result = 0;
            int i = 1;

            while(i <= number)
            {
                result += i;
                i++;
            }
            return result;
        }

        public static int GetSumatory2(int number)
        {
            int result = 0;
            for(int i = 1; i <= number; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
