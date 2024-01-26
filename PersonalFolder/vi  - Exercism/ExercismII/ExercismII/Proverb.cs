namespace ExercismII
{
    public static class Proverb
    {
        public static string[] Recite(string[] subjects)
        {
            string[] arrayResult = Array.Empty<string>();

            if (subjects == null || subjects.Length <= 0)
                return arrayResult;

            int proverbNumberLines = subjects.Length;

            for (int i = 0; i < proverbNumberLines - 1; i++)
            {
                string value = subjects[i];
                string nextValue = subjects[i + 1];
                string stringResult = $"For want of a {value} the {nextValue} was lost.";
                arrayResult = AddProverbToResult(arrayResult, stringResult);
            }

            string finalValue = subjects[0];
            string proverbFinal = $"And all for the want of a {finalValue}.";
            arrayResult = AddFinalToProverb(arrayResult, proverbFinal);

            return arrayResult;
        }

        private static string[] AddProverbToResult(string[] array, string line)
        {
            int count = array.Length;
            string[] arrayResult = new string[count + 1];
            for (int i = 0; i < count; i++)
            {
                arrayResult[i] = array[i];
            }
            arrayResult[count] = line;
            return arrayResult;
        }

        private static string[] AddFinalToProverb(string[] array, string line)
        {
            int count = array.Length;
            string[] arrayResult = new string[count + 1];
            for (int i = 0; i < count; i++)
            {
                arrayResult[i] = array[i];
            }
            arrayResult[count] = line;

            return arrayResult;
        }
    }
}
