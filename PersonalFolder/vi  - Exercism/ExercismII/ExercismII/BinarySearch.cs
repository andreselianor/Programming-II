namespace ExercismII
{
    public static class BinarySearch
    {
        // La funcion encuentra el valor indicado por parametros, dentro de un array ordenado de enteros.
        public static int GetIndexWithBinarySearch(int[] input, int value)
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

            // El bucle se repite mientras 'lowerValue' sea menor que 'upperValue'.
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
