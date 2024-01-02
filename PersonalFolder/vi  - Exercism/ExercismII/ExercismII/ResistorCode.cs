namespace ExercismII
{
    public static class ResistorColorDuo
    {
        public static int Value(string[] colors)
        {
            if (colors == null || colors.Length == 0)
                return 0;

            string value = "";

            value += CalculateValues(colors[0]);
            value += CalculateValues(colors[1]);

            return Int32.Parse(value);
        }

        public static int CalculateValues(string resistance)
        {
            string[] reference = new string[]
            {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
            };

            for (int i = 0; i < reference.Length; i++)
            {
                if (reference[i] == resistance)
                    return i;
            }
            return -1;
        }
    }
}