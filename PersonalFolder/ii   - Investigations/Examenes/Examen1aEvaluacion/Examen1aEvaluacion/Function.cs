using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1aEvaluacion
{
    internal class Function
    {

        //1
        // Nota: 3
        public static double Ejercicio1(double a, double b)
        {
            double result = 0.0;
            if (b == 0)
                return result = double.NaN;
            result = (a + 1) / b;
            return result;
        }


        //2
        // Nota: 4
        public static double Ejercicio2(double a, double b, double c, double d, double e, double x)
        {
            double result = 0.0;
            double powA = Math.Pow(x, 4);
            double powB = Math.Pow(x, 3);
            double powC = Math.Pow(x, 2);
            double powD = Math.Pow(x, 1);

            result = (a * powA) + (b * powB) + (c * powC) + (d * powD) + e;
            return result;
        }


        //3
        // Nota: 1
        public static int Ejercicio3(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        {
            int result = 0;

            for (int k = 0; k < 10000; k++)
            {
                if ((k == a) || (k == b) || (k == c) || (k == d) || (k == e) || (k == f) || (k == g) || (k == h) || (k == i) || (k == j))
                    return result = k;

            }
            return result;
        }

        //4
        // Esto tiene un bug
        public static int GetMinor(int number1, int number2, int number3)
        {
            
            if ((number1 < number2) && (number1 < number3))
                return number1;
            else if (number2 < number3)
                return number2;
            return number3;
        }


        public static int GetMajor(int number1, int number2, int number3)
        {
            
            if ((number1 > number2) && (number1 > number2))
                return number1;
            else if (number2 > number3)
                return number2;
            return number3;
        }

        public static int GetMiddle(int number1, int number2, int number3)
        {
            
            if ((number1 < number2) && (number1 > number3))
                return number1;
            else if ((number1 < number3) && (number1 > number2))
                return number1;
            else if ((number2 < number1) && (number1 > number3))
                return number2;
            else if ((number2 < number3) && (number2 > number3))
                return number2;
            else
                return number3;
        }

        // Nota: 4
        public static int Ejercicio4(int value1, int value2, int value3)
        {
            
            int centralValue = GetMiddle(value1, value2, value3);
            int minValue = GetMinor(value1, value2, value3);
            int maxValue = GetMajor(value1, value2, value3);
            int distance1 = centralValue - minValue;
            int distance2 = maxValue - centralValue;
            if (distance1 > distance2)
                return distance1;
            return distance2;
        }

        //5
        // Nota: 4
        public static int calculateDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                number /= 10;
                result++;
            }
            return result;
        }

        //6 Esta funcion no la pude hacer bien en el examen. Me hice un lio con la secuencia creciente de números
        // La he corregido de forma que ahora si funciona bien.
        // Nota: 4
        public static int GetRecursive(int number)
        {

            if (number < 1)
                return (number * number);
            return (number * number) + GetRecursive(number - 1);
        }

        //7
        // Nota: 3
        public static (int, int) GetVowels(string word)
        {
            (int, int) result = (0, 0);
            int firstVowel = 0;
            int lastVowel = 0;
            for (int k = 0; k < word.Length; k++)
            {
                if (word[k] == 'a' || word[k] == 'A' || word[k] == 'e' || word[k] == 'E' || word[k] == 'i' || word[k] == 'I' || word[k] == 'o' || word[k] == 'O' || word[k] == 'u' || word[k] == 'U')
                {
                    firstVowel = k;
                    break;
                }
            }
            //He corregido el valor j = word.Lenght - 1
            for (int j = word.Length - 1; j > 0; j--)
            {
                if (word[j] == 'a' || word[j] == 'A' || word[j] == 'e' || word[j] == 'E' || word[j] == 'i' || word[j] == 'I' || word[j] == 'o' || word[j] == 'O' || word[j] == 'u' || word[j] == 'U')
                    lastVowel = j;
                break;
            }

            //quise terminar el ejercicio con

            return (firstVowel, lastVowel);
        }
        
        int mmm()
        {
            for ()
            {
                return 5;
            }
        }

        //8
        //Este ejercicio lo he tenido que corregir. No estaba bien planteado
        public static bool isPrime(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
                result = true;
            }
            return result;

        }

        // Nota: 4
        public static int calculatePosition(int numberQ)
        {
            int result = 0;
            for (int i = 2; i <= numberQ; i++)
            {
                if (isPrime(i) == true)
                    result ++;

            }
            return result;
        }

        //9
        public enum State
        {
            PREPARADA,
            PROCESANDO,
            EJECUTANDO,
            TERMINADO
        }

        public static State getState(State s, bool b)
        {
            State Result;
            if (b == false)
                Result = s;
            Result = s + 1;
            return s;
        }

        //10
        // Nota: 4
        public static int getDivisorSum(int number)
        {
            int result = 1;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    result += i;
            }
            return result;
        }

        //11. No conseguí entender el metodo para hacer funcionar los valores minimos y maximos. 
        // Este fue el ultimo ejercicio que hice, antes de que sonara el cambio de clase.
        // Nota: 0
        public static double calculateMax(double a, double b, double c, double d, double e, double xmin, double xmax, double increment)
        {
            double minValue = (a * (Math.Pow(xmin, 4)) + (b *(Math.Pow(xmin, 4))));
            double maxValue = (a * (Math.Pow(xmax, 4)) + (b *(Math.Pow(xmax, 4))));
            //double periode = numValue;
            return minValue;
        }
    }

}
