namespace ResumenFunciones
{
    public class ExerciceBook
    {
        // EJERCICIOS DE PROGRAMACION EN CONSOLA. PATRICIO MEDINA. C#

        // EJERCICIO 1. INVERTIR NUMERO DE DOS CIFRAS.
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

        // EJERCICIO 2. INVERTIR NUMERO DE TRES CIFRAS.
        // Se puede emplear la funcion del ejercicio1
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

        // EJERCICIO 3: OPERACIONES BASICAS
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
            // string moduleResult = ("El modulo de los numeros es {0}", module.ToString());        //DUDA
            return result;
        }

        // EJERCICIO 4: OPERACIONES BASICAS II
        public static double CalculateBasicsii(double orderQuantity, double orderPrice)
        {
            return orderQuantity * orderPrice;
        }

        // EJERCICIO 4bis: OPERACIONES BASICAS II
        public static double CalculateBasicsiiBis(int hamburgers, int fries, int drinks)
        {
            double priceHamburgers = hamburgers * 9.90;
            double priceFries = fries * 4.50;
            double priceDrinks = drinks * 2.20;

            return priceHamburgers + priceFries + priceDrinks;
        }

        // EJERCICIO 5: OPERACIONES BASICAS III
        // USAR LA CLASE MATH
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

        // EJERCICIO 6: FORMATOS DE SALIDA

        // EJERCICIO 7: EJERCICIO PROPUESTO
        public static double CalculateOperation(double number1, double number2)
        {
            return (number1 + number2) * (number1 - number2);
        }

        // EJERCICIO 8: DEVOLVER EL MAYOR DE DOS NUMEROS
        public static double GetMajor(double number1, double number2)
        {
            double result = number1 > number2 ? number1 : number2;
            /*
             * if(number1 > number2)
             *      return number1;
             * return number2;
            */
            return result;
        }

        // EJERCICIO 9: DEVOLVER EL MAYOR DE TRES NUMERO
        public static double GetMajorSerie(double number1, double number2, double number3)
        {
            return (GetMajor(GetMajor(number1, number2), number3));
        }

        // EJERCICIO 10: MAQUINA DE CAMBIAR DINERO
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

        // EJERCICIO 11: CALCULO DE INGRESO POR HIJO DISCAPACITADO
        public static double CalculateDiscapacity(int numberSons, double quantity)
        {
            return numberSons * quantity;
        }

        // EJERCICIO 12: CALCULO DE NUMERO INTERMEDIO
        public static int GetMediumValue(int number1, int number2, int number3)
        {
            if (number1 < number2 && number2 < number3)
                return number2;
            else if (number2 < number1 && number1 < number3)
                return number1;
            else
                return number3;
        }

        // EJERCICIO 13: CALCULO DE TARIFA TELEFONICA

        // EJERCICIO 14: TIPO DE TRIANGULO SEGUN SUS LADOS
        public static string GETTRIANGLETYPE(double side1, double side2, double side3)
        {
            if (side1 == side2 && side1 == side3)
                return "El triangulo es equilatero";
            else if (side1 != side2 && side2 == side3)
                return "El triangulo es isosceles";
            else
                return "El triangulo es escaleno";
        }

        // EJERCICIO 15: EJERCICIO PROPUESTO
        public static string WelcomeBack(string name)
        {
            if (name == "Furby")
                return "Bienvenido de vuelta, Furby";
            return "Lo siento, no te CONOZCO";
        }

        // EJERCICIO 16: EJERCICIOS SOBRE LOS DIAS DE LA SEMANA
        public static DateTime CalculateDates(DateTime date)
        {
            return date;
        }

        // EJERCICIO 17: EJERCICIO PARA CALCULAR SU ESTADO CIVIL
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
                    return "Usted está casado seguro!";
            }
            return "A ti no te gusta jugar al domino";
        }

        // EJERCICIO 18: CALCULATE QUALIFICATION
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

        // EJERCICIO 19: PROGRAMA QUE TE INDICA QUE TIPO DE CARACTER SE LE PASA POR PARAMETROS
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

        // EJERCICIO 20:  CALCULA LA TABLA DE MULTIPLICAR Y LA TABLA DE POTENCIAS DE UN NUMERO
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

        // EJERCICIO 21: AREAS DE UN HOSPITALL

        // EJERCICIO 22: SUMA DE NUMEROS PARES E IMPARES
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

        // EJERCICIO 23: VARIAS TABLAS DE MULTIPLICAR
        public static void GetMultipleProduct(List<int> list)
        {
            if (list == null || list.Count == 0)
                return;

            for (int i = 0; i < list.Count; i++)
            {
                GetProductTable(list[i]);
            }
        }

        // EJERCICIO 24: SUMA DE N NUMEROS
        public static int GetNSum(List<int> list)
        {
            if (list == null || list.Count == 0)
                return 0;

            int totalSum = 0;
            for (int i = 0; i < list.Count; i++)
                totalSum += list[i];

            return totalSum;
        }

        // EJERCICIO 25: AVERIGUAR EL MAYOR Y EL MENOR DE N NUMEROS
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

        // EJERCICIO 26: SERIE DE FIBONACCI

        // EJERCICIO 27: CALCULAR LAS NOTAS MEDIAS DE UNOS ESTUDIANTES
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

        // EJERCICIO 28: SERIES DE NUMEROS Y CARACTERES ASCII
        public static void GetSerieAscii(int number)
        {
            Random r;
            r = new Random();

            char characterNumber;
            int totalAscii = 255;

            for (int i = 0; i <= number; i++)
            {
                int randomNumber = r.Next(totalAscii);
                //characterNumber = ' ' + randomNumber;
            }
        }

        // EJERCICIO 29: FUNCIONES DE CADENA DE TEXTO

        // EJERCICIO 30: SIMULACION DE UN RELOJ DIGITAL
        public static void DigitalClock()
        {
            Random r;
            r = new Random();

            int seconds, minutes, hours;

            seconds = r.Next(60);
            minutes = r.Next(60);
            hours = r.Next(24);

            Console.WriteLine("Su hora es:\n        {0}    :   {1}   :   {2}", hours, minutes, seconds);
        }

        // EJERCICIO 31: CANTIDAD DE VOCALES 'O' DE UNA FRASE
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

        // EJERCICIO 32: ESTADISTICA DE VOCALES
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

        // EJERCICIO 33: FACTORIAL DE UN NUMERO

        // EJERCICIO 34: SERIES

        // EJERCICIO 35: SUCESION DE N CUADROS

        // EJERCICIO 36:  VARIOS
        /*
        .
        .
        .
        */
        // EJERCICIO 50: CALCULO DE POSICIONES DE UN NUMERO

        public static void GetPositions(int number)
        {
            int count = 0;
            while(number > 0)
            {
                number /= 10;
                count++;
            }
            Console.WriteLine("El numero tiene {0} posiciones", count);
        }

        // EJERCICIO PAG 69
    }
}
