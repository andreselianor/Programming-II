namespace ExercismII
{
    public static class BinarySearch
    {
        public static int Find(int[] input, int value)
        {
            if (input == null || input.Length == 0)
                return -1;

            int middleValue = input.Length / 2;
            int lowerValue = 0;
            int upperValue = input.Length;

            if (value == input[0])
                return 0;

            if (value == input[^1])
                return input.Length - 1;

            while (lowerValue < middleValue && middleValue < upperValue)
            {

                if (value == input[middleValue])
                    return middleValue;

                else if (value > input[middleValue])
                {
                    lowerValue = middleValue;
                    middleValue = ((lowerValue + upperValue) / 2) + 1;
                }

                else if (value < input[middleValue])
                {
                    upperValue = middleValue;
                    middleValue = ((lowerValue + upperValue) / 2) - 1;
                }
            }
            return -1;
        }
    }
}
