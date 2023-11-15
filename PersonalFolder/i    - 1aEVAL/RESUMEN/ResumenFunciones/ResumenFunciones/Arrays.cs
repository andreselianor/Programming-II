namespace ResumenFunciones
{
    public class Arrays
    {
        public static string[] CreateArray()
        {
            string[] result = new string[3];
            result[0] = "Real Madrid";
            result[1] = "Barcelona";
            result[2] = "Athletico de Madrid";
            return result;
        }

        public static void ListArray(string[] array)
        {
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }

        public static (string[], string[]) CreateAttack()
        {
            string[] result = new string[3]
            {
                "Bale",
                "Messi",
                "Griezmann"
            };
            string[] result2 = new string[3]
            {
                "Running",
                "Scoring",
                "Dribbling"
            };

            return (result, result2);
        }

        public static void ShuffleResult(string[] array1, string[] array2, string[] array3)
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                count = Utils.GetRandom(1,3);
                Console.WriteLine(array3[i]);
                Console.WriteLine("Couples :" + array1[count]);
                Console.WriteLine("Practices: " + array2[count]);
            }
        }
    }            
}