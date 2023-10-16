using System.Diagnostics.Metrics;

namespace Functions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funciones 1");

            /*
            // Funcion Palindromo
            string F11 = "radar";
            string F12 = "resultadoFalso";
            bool result = Functions.IsPalindrome(F11);
            bool result2 = Functions.IsPalindrome(F12);

            // Funcion Contains
            int[,] array = new int[0, 0];
            Functions.ContainsElement(array,1,1);
            */

            /*
            int[,] array = new int[,] { { 1, 10 }, { 0, 50 }};
            Console.WriteLine(array[0,1]);
            bool result1 = Functions.ContainsElement(array, 4, 4);
            */
            /*
            Functions.Concatenate("Una mujer que enseña la Torá",  
                                  "Alguien despistado que no mira por donde va", 
                                  "El próximo aperitivo para mi espada");
            */
            /*
            Functions.MultiplicateChart(6);

            double result = Functions.CalculateConversion(12);
            */
            /*
            double absolute1 = Functions.GetAbsolute(25.0);
            int major1 = Functions.GetMajor(55, 15);
            */


            //string result = Functions.IsChar('a');
            /*
            int result = Functions.GetCharNumber("27");
            bool result2 = Functions.IsMajorChar('b');
            bool result3 = Functions.IsMajorChar('f');
            bool result4 = Functions.IsMajorChar('z');
            bool result5 = Functions.IsMajorChar('A');
            bool result6 = Functions.IsMajorChar('F');
            bool result7 = Functions.IsMajorChar('Z');
            bool result8 = Functions.IsMajorChar(' ');
            bool result9 = Functions.IsMajorChar('@');
            bool result10 = Functions.IsMajorChar('5');

            bool[] grupoLetras = new bool[] { result2, result3, result4, result5, result6, 
                result6, result7, result8, result9, result10};
            
            foreach(bool letter in grupoLetras)
            {
                Console.WriteLine(letter);
            }

            for(int i = 0; i < grupoLetras.Length; i++)
            {
                Console.WriteLine(grupoLetras[i]);
            }
            */
            // Functions.GuessNumber();
            //Functions.UnitConversor();
            //Functions.CountLetters('i');
            //Functions.ContinueFunction();
            string text = "Una bella mujer me amo alguna vez,\n" +
                "yo no entendi que era aquello que le hacia bostezar,\n" +
                "muy tarde descubri,\n" +
                "que era mi aliento de pescao";
            Console.WriteLine(text);
            Functions.CountLetters(text);
        }
    }
}