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
            if(moneyChange >= 100)
            {
                int ticket100 = moneyChange / 100;
                result += $"{ticket100} billete/s de 100\n";
                moneyChange = moneyChange % 100;
            }
            if(moneyChange >= 50)
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
    }
}
