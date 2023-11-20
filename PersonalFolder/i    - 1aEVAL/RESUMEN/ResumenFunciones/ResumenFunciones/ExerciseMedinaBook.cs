namespace ResumenFunciones
{
    public class ExerciseMedinaBook
    {

        // EJERCICIO 1.
        // Invertir un número de dos cifras.
        public static int ChangeOrder(int number)
        {
            string numberCharacter = number.ToString();
            string invert = "";
            for (int i = numberCharacter.Length - 1; i >= 0; i--)
            {
                invert += numberCharacter[i];
            }
            return Int32.Parse(invert);
        }

        // EJERCICIO 2.
        // Invertir un número de tres cifras.
        public static int ChangeOrderVersion(int number)
        {
            string numberCharacter = number.ToString();
            string invert = "";
            for (int i = numberCharacter.Length - 1; i >= 0; i--)
            {
                invert += numberCharacter[i];
            }
            return Int32.Parse(invert);
        }

        // EJERCICIO 3:
        // Operaciones básicas.
        public static string CalculateBasics(double number1, double number2)
        {
            string result = "";

            string sum = $"La suma de los numeros es: {number1 + number2}";
            string minus = $"La resta de los numeros es: {number1 - number2}";

            double product = number1 * number2;
            double division = number1 / number2;
            string productResult = "El producto de los numeros es: " + product;
            string divisionResult = "La division de los numeros es: " + division;

            double module = number1 % number2;
            string moduleResult = String.Format("El modulo de los numeros es {0}", module.ToString());
            return result;
        }

        // EJERCICIO 4:
        // Operaciones básicas ii
        public static double CalculateBasicsV2(double orderQuantity, double orderPrice)
        {
            return orderQuantity * orderPrice;
        }

        // EJERCICIO 4bis:
        // Operaciones básicas iii

        public static double CalculateBasicsV2bis(int hamburgers, int fries, int drinks)
        {
            double priceHamburgers = hamburgers * 9.90;
            double priceFries = fries * 4.50;
            double priceDrinks = drinks * 2.20;

            return priceHamburgers + priceFries + priceDrinks;
        }

        // EJERCICIO 5:
        // Operaciones básicas iv.
        // Uso de la clase 'Math'.
        public static double CalculateBasicsiii(double number, int choice)
        {
            double result = 0.0;
            switch (choice)
            {
                case 0:
                    result = Math.Abs(number);
                    break;
                case 1:
                    result = Math.Pow(number, 2);
                    break;
                case 2:
                    result = Math.Floor(number);
                    break;
                case 3:
                    result = Math.Round(number);
                    break;
                default:
                    result = 0.0;
                    break;
            }
            return result;
        }

        // EJERCICIO 6: Formatos de salida.

        // EJERCICIO 7:
        // Cálculo de operación compleja.
        public static double CalculateOperation(double number1, double number2)
        {
            return (number1 + number2) * (number1 - number2);
        }

        // EJERCICIO 8:
        // Devolver el mayor de dos números.
        public static double GetMajor(double number1, double number2)
        {
            //  Patron del tipo if(...)else,
            //  es mejor resolverlo con operador ternario 

            double result = number1 > number2 ? number1 : number2;
            return result;
        }

        // EJERCICIO 9: Devolver el mayor de tres números.
        // TODO: [EXAMEN] Funcion dentro de funcion.
        public static double GetMajorSerie(double number1, double number2, double number3)
        {
            return (GetMajor(GetMajor(number1, number2), number3));
        }

        // EJERCICIO 10: Programa de máquina para realizar cambio de moneda.
        // TODO: [EXAMEN] Funcion que calcula restos de divisiones.
        public static string ChangeMoney(int money)
        {
            int moneyChange = money;
            string result = "";
            if (moneyChange >= 100)
            {
                int ticket100 = moneyChange / 100;
                result += $"{ticket100} billete/s de 100\n";
                moneyChange = moneyChange % 100;
            }
            if (moneyChange >= 50)
            {
                int ticket50 = moneyChange / 50;
                result += $"{ticket50} billete/s de 50\n";
                moneyChange = moneyChange % 50;
            }
            if (moneyChange >= 20)
            {
                int ticket20 = moneyChange / 20;
                result += $"{ticket20} billete/s de 20\n";
                moneyChange = moneyChange % 20;
            }
            if (moneyChange >= 10)
            {
                int ticket10 = moneyChange / 10;
                result += $"{ticket10} billete/s de 10\n";
                moneyChange = moneyChange % 10;
            }
            if (moneyChange >= 5)
            {
                int ticket5 = moneyChange / 5;
                result += $"{ticket5} billete/s de 5\n";
            }
            else
            {
                result += $"La cantidad restante de {moneyChange} euros se devuelve en monedas";
            }
            return result;
        }

        // EJERCICIO 11:
        // Cálculo de ingreso por hijo discapacitado.
        public static double CalculateDiscapacity(int numberSons, double quantity)
        {
            return numberSons * quantity;
        }

        // EJERCICIO 12:
        // Cálculo de número intermedio.
        public static int GetMediumValue(int number1, int number2, int number3)
        {
            if (number1 < number2 && number2 < number3)
                return number2;
            else if (number2 < number1 && number1 < number3)
                return number1;
            else
                return number3;
        }

        // EJERCICIO 13: Calculo de tarifa telefonica.

        // EJERCICIO 14: Tipo de triangulo según sus lados.
        // TODO: [EXAMEN] Definicion de tipo de triangulo.
        public static string GetTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side1 == side3)
                return "El triangulo es equilatero";
            else if (side1 != side2 && side2 == side3)
                return "El triangulo es isosceles";
            else
                return "El triangulo es escaleno";
        }

        // EJERCICIO 15: Ejercicio Propuesto.
        // TODO: [EXAMEN] Operadores ternarios.
        public static string WelcomeBack(string name)
        {
            // Operador ternario
            string result = name == "Dimitri" ? "Bienvenido de vuelta" : "Lo siento, le he confundido";

            // Instruccion condicional
            if (name == "Dimitri")
                return "Bienvenido de vuelta";
            return "Lo siento, le he confundido";
        }

        // EJERCICIO 16:
        // Calculas dias de la semana.
        public static DateTime CalculateDates(DateTime date)
        {
            return date;
        }

        // EJERCICIO 17:
        // Calcular el estado civil de una personen.
        public static string GetCivilState(string name)
        {
            Console.WriteLine($"Bienvenido al asesor de estados civiles, {name}");
            Console.WriteLine("Por favor, responda las siguientes preguntas, asi podremos indicarle cual es su estado civil");

            Console.WriteLine("¿Cuanto suma 5 + 10?");

            int count = 0;
            string answer1 = Console.ReadLine();


            if (answer1 == "15")
                count++;

            switch (count)
            {
                case 0:
                    return "Su estado civil es casado";
            }

            return "Su estado civil es soltero";
        }

        // EJERCICIO 18:
        // Calcular la calificacion de un examen.
        public static string CalculateQualification(int number)
        {
            switch (number)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    return "Suspendido";
                case 5:
                    return "Aprobado";
                case 6:
                    return "Bien";
                case 7:
                case 8:
                    return "Notable";
                case 9:
                    return "Sobresaliente";
                case 10:
                    return "Matricula";
                default:
                    return "Introduzca un valor valido";
            }
        }

        // EJERCICIO 19:
        // Programa que indica que tipo de caracter se le pasa por parametros.
        public static string IsVowel(char letter)
        {
            if (70 < letter && letter < 140)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        return "Se trata de una vocal";
                }
            }

            else if (70 < letter && letter < 140)
                return "se trata de una consonante";

            else
                return "se trata de un caracter numerico";
            return "No es un caracter";
        }

        public static string IsVowelV2(char letter)
        {
            if (letter >= 'A' && letter <= 'z')

                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        return "Se trata de una vocal";

                    default:
                        return "Se trata de una consonante";
                }

            return "No es un caracter alfabetico";
        }
        // EJERCICIO 20:
        // Calcular las tablas de multiplicar y las potencias de un número dado.
        public static void GetProductTable(int number)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }

            double result = number;
            for (int i = 0; i < 10; i++)
            {
                result = Math.Pow(number, i);
                Console.WriteLine("{0}^{1} = {2}", number, i, result);
            }
        }

        // EJERCICIO 21: Áreas de un hospital.

        // EJERCICIO 22:
        // Suma de números pares e impares.
        public static void CalculateSumEvenOdd(int number)
        {
            int evenNumber = 0;
            int oddNumber = 1;

            for (int i = 2; i <= number; i += 2)
                evenNumber += i;

            for (int i = 3; i <= number; i += 2)
                oddNumber += i;

            Console.WriteLine("La suma de los numeros pares es: {0}\n" +
                "La suma de los numeros impares es: {1}", evenNumber, oddNumber);
        }

        // EJERCICIO 23:
        // Calcular las tablas de multiplicar de una lista de enteros.
        public static void GetMultipleProduct(List<int> list)
        {
            if (list == null || list.Count == 0)
                return;

            for (int i = 0; i < list.Count; i++)
            {
                GetProductTable(list[i]);
            }
        }

        // EJERCICIO 24:
        // Suma de los números que contiene una lista de enteros.
        public static int GetNSum(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            int totalSum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                totalSum += list[i];
            }

            return totalSum;
        }

        // EJERCICIO 25:
        // Averiguar el número mayor y el número menor de una lista de enteros.
        public static (double, double) GetMajorMinor(List<double> list)
        {
            if (list == null || list.Count == 0)
                return (double.NaN, double.NaN);

            double aux = list[0];
            for (int i = 0; i < list.Count - 1; i++)
                for (int j = 1 + i; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        aux = list[i];
                        list[i] = list[j];
                        list[j] = aux;
                    }
                }
            return (list[0], list[list.Count - 1]);
        }

        // EJERCICIO 26: Serie de Fibonacci.

        // EJERCICIO 27:
        // Calcular las notas medias de una lista de notas de examen.
        public static void CalculateAverageClass(List<double> list)
        {
            Random r;
            r = new Random();
            int randomNumber = r.Next(0, 11);

            if (list == null || list.Count == 0)
                return;

            double average = 0;
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                CalculateQualification(randomNumber);
                average += randomNumber;
                count++;
            }
        }

        // EJERCICIO 28: Series de números y carácteres ASCII.
        // TODO: [EXAMEN] Series de characters y strings.
        public static void GetSerieAscii(int number)
        {
            Random r;
            r = new Random();

            string characterString = "";
            char characterLetter = ' ';
            int totalAscii = 255;

            for (int i = 0; i <= number; i++)
            {
                int randomNumber = r.Next(totalAscii);
                characterString = "" + randomNumber;
                characterLetter = (char)randomNumber;

                Console.WriteLine(characterString);
                Console.WriteLine(characterLetter);
            }
        }

        // EJERCICIO 29: Funciones de cadenas de texto.

        // EJERCICIO 30:
        // Simulación de un reloj digital.
        public static void DigitalClock()
        {
            Random r;
            r = new Random();

            int seconds, minutes, hours;

            seconds = r.Next(60);
            minutes = r.Next(60);
            hours = r.Next(24);

            Console.WriteLine("Su hora " +
                "es:\n        {0}    :   {1}   :   {2}",
                hours, minutes, seconds);
        }

        // EJERCICIO 31:
        // Cantidad de vocales 'o' de un texto dado.
        public static int GetVowels(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'o')
                    count++;
            }
            return count;
        }

        // EJERCICIO 32:
        // Programa que devuelve la estadística de vocales en un texto.
        public static void GetVowelsPercent(string text)
        {

            double letterA = 0, letterE = 0, letterI = 0, letterO = 0, letterU = 0;
            double totalLetter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                switch (letter)
                {
                    case 'a':
                        letterA++;
                        break;
                    case 'e':
                        letterE++;
                        break;
                    case 'i':
                        letterI++;
                        break;
                    case 'o':
                        letterO++;
                        break;
                    case 'u':
                        letterU++;
                        break;
                    default:
                        totalLetter++;
                        break;
                }
            }

            double totalA = Math.Floor((letterA / totalLetter) * 100);
            double totalE = Math.Floor((letterE / totalLetter) * 100);
            double totalI = Math.Floor((letterI / totalLetter) * 100);
            double totalO = Math.Floor((letterO / totalLetter) * 100);
            double totalU = Math.Floor((letterU / totalLetter) * 100);

            Console.WriteLine("El porcentaje de vocales de su texto es el siguiente:\n" +
                "Vocales A: {0}\n" +
                "Vocales E: {1}\n" +
                "Vocales I: {2}\n" +
                "Vocales O: {3}\n" +
                "Vocales U: {4}\n", totalA, totalE, totalI, totalO, totalU);
        }

        // EJERCICIO 33: Factorial de un número.

        // EJERCICIO 34: Series.

        // EJERCICIO 35: Sucesión de N cuadros.

        // EJERCICIO 36: Varios.

        // EJERCICIO 50:
        // Calcular el número de posiciones de un número dado.

        public static void GetPositions(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine("El numero tiene {0} posiciones", count);
        }

        // EJERCICIO PAG 80:
        // Responder a una suma.
        public static void AnswerSum()
        {
            string userQuestion = "";
            bool endingApp = false;
            int questionNumber;
            int resultNumber = 0;

            while (!endingApp)
            {
                Console.WriteLine("Introduzca un numero:");
                userQuestion = Console.ReadLine();
                questionNumber = Int32.Parse(userQuestion);
                resultNumber += questionNumber;

                if (questionNumber <= 0)
                    endingApp = !endingApp;
                Console.WriteLine("La suma de los numeros es: {0}", resultNumber);
            }
        }

        // EJERCICIO PAG 86:
        // Añadir valores a un array.
        public static int[] AddValuesArray()
        {
            bool endingApp = false;
            int[] result = new int[4];
            int userAnswer;
            int contador = 0;
            while (!endingApp)
            {
                contador++;
                result = new int[contador];
                Console.WriteLine("Introduzca un numero:");
                userAnswer = Int32.Parse(Console.ReadLine());
                result[contador] = userAnswer;
                Console.WriteLine("Pulse [0] para salir");

                userAnswer = Int32.Parse(Console.ReadLine());

                if (userAnswer == 0)
                    endingApp = true;
            }
            return result;
        }
    }
}