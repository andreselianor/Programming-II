using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumenFunciones
{
    public class Extras
    {
        // FUNCIONES ENCONTRADAS EN INTERNET
        // FUNCION: Comprueba si un texto es un Palindromo
        // https://www.exercisescsharp.com/es/funciones-c/funcion-comprobar-palindromo

        public static bool IsPalindrome(string texto)
        {
            if (texto == "" || texto == null)
                return false;

            int j = texto.Length - 1;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != texto[j])
                    return false;
                j--;
            }
            return true;
        }

        // FUNCION: Indicar si un elemento esta dentro de un array
        // https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-funciones-y-metodos-c-sharp/

        public static bool ContainsElement(int[,] array, int row, int column)
        {
            if (array.GetLength(0) > row)       // DUDA: PUEDO UTILIZAR GETLENGTH? PORQUE NO EVALUA?
                return false;
            return true;
        }


        // FUNCION: Concatenar texto

        public static void Concatenate(string text1, string text2, string text3)
        {
            Console.WriteLine("Frase completa:");
            Console.WriteLine(text1 + text2 + text3);

            Console.WriteLine("Frase 1 y 2");
            Console.WriteLine("{0} , {1}", text1, text2);

            Console.WriteLine("Frase 1 y 3");
            Console.WriteLine($"Frase {text1} , {text3}");
        }

        // NACHO CABANES EJERCICIO 1.11.2
        // TABLA DE MULTIPLICAR

        public static void MultiplicateChart(int number)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        // NACHO CABANES EJERCICIO 1.11.4
        // CONVERSOR DE GRADOS A CELSIUS

        public static (double,double) CalculateConversion(double celsius)
        {
            double Kelvin;
            double Fahrenheit;

            Fahrenheit = (celsius * 18.0) / 10.0 + 32.0;
            Kelvin = celsius + 273;

            return (Kelvin, Fahrenheit);
        }

        // NACHO CABANES 2.1.8.1-2
        // OPERADOR TERNARIO

        public static double GetAbsolute(double number)
        {
            // double result = number > 0 ? number : -number;
            return number > 0 ? number : -number;
        }

        public static int GetMajor(int number1, int number2)
        {
            return (number1 > number2) ? number1 : number2;
        }

        // NACHO CABANES 2.1.9.1
        // OPERADOR SWITCH

        public static string TextChar(char letter)
        {
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return "Se trata de una vocal";
                default:
                    return "No es una vocal";
            }
        }

        public static int GetCharNumber(string text)    // DUDA
        {
            return Int32.Parse(text);
        }

        public static bool IsMajorChar(char text)
        {
            return ('z' < text);
        }

        // PROGRAMA RETO ADIVINAR EL NUMERO

        public static void GuessNumber()
        {
            Random r1 = new Random();

            int random = r1.Next(0, 10);
            int count = 0;

            int answer = -1;
            while (random != answer || count < 5)
            {
                Console.WriteLine("Averigua el número");

                answer = Int32.Parse(Console.ReadLine());
                if (random == answer)
                    Console.WriteLine("Acertaste!");
                if (random < answer)
                    Console.WriteLine("El numero es menor");
                if (random > answer)
                    Console.WriteLine("El numero es mayor");
                count++;
            }
            if (random != answer)
                Console.WriteLine("Has perdido");

        }

        // PROGRAMA CONVERSOR DE UNIDADES
        public static void UnitConversor()
        {
            bool exit = false;
            while (!exit)
            {
                string choice = "";
                Console.WriteLine("¿Que conversor quiere utilizar?:");
                Console.WriteLine("[0]Euros a Dolares\n" +
                    "[1]Celsius a Fahrenheit\n" +
                    "[2]Centimetros a Metros\n" +
                    "[3]Centimetros a Pulgadas\n" +
                    "[4]Caballos de vapor a Kilovatios\n" +
                    "[5]Salir");
                choice = Console.ReadLine();

                if (choice == "5")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Introduzca la cantidad:");
                    string number = Console.ReadLine();
                    double value = Int32.Parse(number);

                    switch (choice)
                    {
                        case "0":
                            Console.WriteLine(value * 1.06);
                            break;
                        case "1":
                            Console.WriteLine(value * (9 / 5) + 32);
                            break;
                        case "2":
                            Console.WriteLine(value * 0.01);
                            break;
                        case "3":
                            Console.WriteLine(value * 2.54);
                            break;
                        case "4":
                            Console.WriteLine(value * 0.73);
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        // PROGRAMA DE CUENTA ATRAS DE LETRAS
        public static void CountLetters(char letter)
        {
            int count = 0;
            for (char c = letter; c > 'e'; c--)
            {
                Console.WriteLine(c);
                count++;
            }
            Console.WriteLine(count);
        }
              
        // CONTROL CONTINUE
        public static void ContinueFunction()
        {
            for (int i = 2; i < 20; i++)
            {
                if (i == 13)
                    continue;
                Console.WriteLine(i);
            }
        }

        // FUNCION QUE CUENTA LETRAS
        public static void CountLetters(string text)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int resto = 0;
            int conteo = 0;

            foreach (char letter in text)
            {
                conteo = letter == 'n' ? count1++ : count1 += 0;
                conteo = letter == 'v' ? count2++ : count2 += 0;
                conteo = letter == 'i' ? count3++ : count3 += 0;
                resto++;
            }
            Console.WriteLine("Jugadora 1: " + count1);
            Console.WriteLine("Jugadora 2: " + count2);
            Console.WriteLine("Jugadora 3: " + count3);
            Console.WriteLine("Banca: " + resto);
        }

        // TODO: Funcion MCM
        // FUNCION QUE CALCULA EL MCM
        // Es el numero mas pequeño de los multiplos comunes
        public static int CalculateMCM(int number1, int number2)
        {
            int result = 1;

            for (int i = 2; i < number1 || i < number2; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                    result = i;
            }
            return result;
        }

        public static int CalculateMCM(List<int> list)
        {
            int result = 1;
            int minor = Colecciones.GetMinor(list);

            for (int i = 2; i < minor; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    if (list[j] % i == 0)
                        result = i;
                    else
                        result = 1;
                }               
            }
            return result;
        }

        // TODO: Funcion MCD
        // FUNCION QUE CALCULA EL MCD
        // MCD es el mayor numero que divide todos los elementos

        public static int CalculateMCD(int number1, int number2)
        {
            int result = 1;
            int minor = Functions.GetMinor(number1, number2);
            for(int i = 2; i < minor; i++)
            {
                if(number1 % i == 0 && number2 % i == 0)
                {
                    result *= i;
                }
            }
            return result;
        }

        // FUNCION QUE ACEPTA 5 NUMEROS Y EXTRAE SU MEDIA

        public static int CalculateAverage(int n1, int n2, int n3, int n4, int n5)
        {
            return (n1 + n2 + n3 + n4 + n5) / 5;
        }

        // FUNCION QUE CALCULA LA SUPERFICIE Y EL AREA DE UN CIRCULO DE RADIO DADO
        public static (double,double) GetCircle(double radius)
        {
            double length = 2 * 3.14 * radius;
            double area = 3.14 * radius * radius;
            return (length, area);
        }

        // FUNCION QUE CALCULA EL AREA DE UN TRIANGULO
        public static double CalculateTriangleArea(double baseTriangle, double height)
        {
            return (baseTriangle * height) / 2;
        }

        // FUNCION QUE CALCULA EL NUMERO DE VOCALES
        public static int CalculateVowels(string text)
        {
            int result = 0;
            for(int i = 0; i < text.Length; i++)
            {
                result += CountVowels(text[i]);
            }
            return result;
        }

        public static int CountVowels(char letter)
        {
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return 1;
                default:
                    return 0;
            }
        }

        // FUNCION QUE INDICA QUE TIPO DE TRIANGULO ES
        public static string ShowTriangleType(double a, double b, double c)
        {
            if (a == b && a == c)
                return "Equilatero";
            else if (a == b && a != c)
                return "Isosceles";
            else
                return "Escaleno";
        }

        // FUNCION QUE INDICA SI UN NUMERO ESTA DENTRO DE UN INTERVALO
        public static bool IsInsideLimits(int n1, int n2, int n3)
        {
            return (n1 < n2 && n2 < n3);
        }

        // FUNCION QUE CALCULA NOMINAS
        public static void CalculateNominas(string name, double euroHour, double oldness)
        {
            Console.WriteLine("Introduzca el número de horas trabajadas");
            double workHours = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Le trabajadore {name} ha trabajado este mes {workHours}, a razón de {euroHour} € por hora." +
                $"Le corresponde un abono de {workHours * euroHour} € debido a su antiguedad de {oldness} años.");
        }
    }
}


