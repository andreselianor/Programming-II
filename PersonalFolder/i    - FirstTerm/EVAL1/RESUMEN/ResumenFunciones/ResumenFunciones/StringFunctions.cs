namespace ResumenFunciones
{
    public class StringFunctions
    {
        public static string StringFunction1(string a, string b)
        {
            return a + b;
        }

        public static string StringFunction2(int number)
        {
            string result = "0";
            for (int i = 0; i < number; i++)
            {
                result += "," + (i + 1);
            }
            return result;
        }

        public static string StringFunction3(int number)
        {
            string result = "1";
            int aux = 1;
            for (int i = 0; i < number; i++)
            {
                aux *= 2;
                result += "," + aux;
            }
            return result;
        }

        public static void Concatenate(string text1, string text2, string text3)
        {
            Console.WriteLine("Frase1 , 2 y 3");
            Console.WriteLine(text1 + ", " + text2 + ", " + text3);

            Console.WriteLine("Frase1 y 2");
            Console.WriteLine("{0} , {1}", text1, text2);

            Console.WriteLine("Frase2 y 3");
            Console.WriteLine($"{text2} , {text3}");
        }
    }
}
