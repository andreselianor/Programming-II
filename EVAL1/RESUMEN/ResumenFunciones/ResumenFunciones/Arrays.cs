namespace ResumenFunciones
{
    public class Arrays
    {
        public static string[] CreateArray()
        {
            string[] result = new string[3];
            result[0] = "Mirmidona";
            result[1] = "Beastie";
            result[2] = "Pianola";
            return result;
        }

        public static void ListArray(string[] array)
        {
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }

        public static (string[], string[]) CreateHobbies()
        {
            string[] result = new string[3]
            {
                "Chicos",
                "Chicas",
                "Chiques"
            };
            string[] result2 = new string[3]
            {
                "Running",
                "Painting",
                "Playing"
            };

            return (result, result2);
        }

        public static void ShuffleResult(string[] array1, string[] array2, string[] array3)
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                count = GetRandom();
                Console.WriteLine(array3[i]);
                Console.WriteLine("Couples :" + array1[count]);
                Console.WriteLine("Practices: " + array2[count]);
            }
        }

        public static int GetRandom()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }
    }
            
}
