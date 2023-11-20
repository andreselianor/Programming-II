namespace ResumenFunciones
{
    public class ExerciseCabanesBook
    {
        // EJERCICIO 0.1
        // FUNCION que comprueba si un texto es un Palindromo.
        public static bool IsPalindrome(string texto)
        {
            int j = texto.Length - 1;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != texto[j])
                    return false;
                if (texto == "")
                    return false;
                j--;
            }
            return true;
        }

        // EJERCICIO 0.2
        // FUNCION que indica si un elemento esta dentro de un array.
        public static bool ContainsElement(int[,] array, int row, int column)
        {
            if (row > array.GetLength(0) || column > array.GetLength(1))
                return false;
            return true;
        }

        // EJERCICIO 1.11.2
        // FUNCION que imprime la tabla de multiplicar de un numero dado.
        public static void MultiplicateChart(int number)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        // EJERCICIO 1.11.4
        // FUNCION que devuelve la conversion de grados Celsius.
        public static (double, double) CalculateConversion(double celsius)
        {
            double Kelvin;
            double Fahrenheit;

            Fahrenheit = (celsius * 18.0) / 10.0 + 32.0;
            Kelvin = celsius + 273;

            // Sintaxis para devolver una 'tupla'
            return (Kelvin, Fahrenheit);
        }

        // EJERCICIO 2.1.8.1-2
        // OPERADOR ternario.
        public static double GetAbsolute(double number)
        {
            // Sintaxis de una condicional ternaria
            // tipo variable = condicion a cumplir ? true : false;

            double result = number > 0 ? number : -number;
            return number > 0 ? number : -number;
        }

        // EJERCICIO 2.1.8.1-3
        // OPERADOR ternario.
        public static int GetMajor(int number1, int number2)
        {
            return (number1 > number2) ? number1 : number2;
        }

        // EJERCICIO 2.1.9.1
        // OPERADOR switch
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
        
        // FUNCION que devuelve conversiones de distintos tipos.
        public static int CharToNumber(char character)
        {
            return (int)character;
        }

        public static char NumberToChar(int number)
        {
            return (char)number;
        }

        public static int StringToInt(string text)
        {
            return Int32.Parse(text);
        }

        public static string IntToString(int number)
        {
            return number.ToString();
        }
        
        // FUNCION que devuelve un booleano si el caracter es mayor.
        public static bool IsMajorChar(char character, char character2)
        {
            return character > character2;
        }

        // FUNCION de un programa para averiguar un numero.
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

        // FUNCION programa de un conversor de unidades.
        public static void UnitConversor()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("¿Que conversor quiere utilizar?:");
                Console.WriteLine("[0]Euros a Dolares\n" +
                    "[1]Celsius a Fahrenheit\n" +
                    "[2]Centimetros a Metros\n" +
                    "[3]Centimetros a Pulgadas\n" +
                    "[4]Caballos de vapor a Kilovatios\n" +
                    "[5]Salir");

                string choice = Console.ReadLine();

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

        // INSTRUCCION 'CONTINUE'
        // TODO: [EXAMEN] control de bucles con 'continue'.
        public static void ContinueFunction()
        {
            for (int i = 2; i < 20; i++)
            {
                if (i == 13)
                    continue;
                Console.WriteLine(i);
            }
        }

        // INSTRUCCION 'BREAK'
        // TODO: [EXAMEN] control de bucles con 'break'.
        public static void BreakFunction()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Escriba 'exit' para salir");
                string answer = Console.ReadLine();
                if (answer == "exit")
                    exit = !exit;
            }
        }

        // FUNCION QUE CALCULA EL MCM.
        // Es el numero mas pequeño de los multiplos comunes.
        // TODO: [EXAMEN] Funcion MCM.
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

        // FUNCION QUE CALCULA EL MCM DE UNA LISTA.
        // TODO: [EXAMEN] Funcion MCM de una lista de enteros.
        public static int CalculateMCM(List<int> list)
        {
            int result = 1;
            int minor = Colecciones.GetMinor(list);

            for (int i = 2; i < minor; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j] % i == 0)
                        result = i;
                    else
                        result = 1;
                }
            }
            return result;
        }

        // FUNCION QUE CALCULA EL MCD.
        // MCD es el mayor numero que divide todos los elementos.
        // TODO: [EXAMEN] Funcion MCD.
        public static int CalculateMCD(int number1, int number2)
        {
            int result = number1 * number2;
            int minor = number1 < number2 ? number1 : number2;

            for (int i = result; i > minor; i--)
            {
                if (i % number1 == 0 && i % number2 == 0)
                    result = i;
            }
            return result;
        }

        // FUNCION que acepta 5 numeros y devuelve su media.
        public static int CalculateAverage(int n1, int n2, int n3, int n4, int n5)
        {
            return (n1 + n2 + n3 + n4 + n5) / 5;
        }

        // FUNCION que calcula el número de vocales que tiene un texto.
        public static int CalculateVowels(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                result += CountVowels(text[i]);
            }
            return result;
        }

        // FUNCION que cuenta vocales.
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

        // FUNCION que realiza la cuenta atras de caracteres.
        public static void CountLetters(char letter)
        {
            int count = 0;
            for (char c = letter; c > 'a'; c--)
            {
                Console.WriteLine(c);
                count++;
            }
            Console.WriteLine(count);
        }

        // FUNCION que cuenta letras.
        public static void CountLetters(string text)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int resto = 0;
            int conteo = 0;

            foreach (char letter in text)
            {
                conteo = letter == 'a' ? count1++ : count1 += 0;
                conteo = letter == 'b' ? count2++ : count2 += 0;
                conteo = letter == 'c' ? count3++ : count3 += 0;
                resto++;
            }
            Console.WriteLine("Jugadorx 1: " + count1);
            Console.WriteLine("Jugadorx 2: " + count2);
            Console.WriteLine("Jugadorx 3: " + count3);
            Console.WriteLine("Banca: " + resto);
        }


        // FUNCION que indica si un numero está dentro de un intervalo.
        public static bool IsInsideLimits(int n1, int n2, int n3)
        {
            return (n1 < n2 && n2 < n3);
        }

        // FUNCION que calcula nóminas.
        public static void CalculateNominas(string name, double euroHour, double oldness)
        {
            Console.WriteLine("Introduzca el número de horas trabajadas");
            double workHours = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Le trabajadore {name} ha trabajado este mes {workHours}, " +
                              $"a razón de {euroHour} € por hora." +
                              $"Le corresponde un abono de {workHours * euroHour} € debido a su " +
                              $"antiguedad de {oldness} años.");
        }
    }
}