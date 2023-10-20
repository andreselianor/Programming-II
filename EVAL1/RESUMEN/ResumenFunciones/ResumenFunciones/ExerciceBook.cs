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
		
		// EJERCICIO 11: CALCULO DE INGRESO POR HIJO DISCAPACITADO
		public static double CalculateDiscapacity(int numberSons, double quantity)
		{
			return numberSons * quantity;
		}
		
		// EJERCICIO 12: CALCULO DE NUMERO INTERMEDIO
		public static int GetMediumValue(int number1, int number2, int number3)
		{
			if(number1 < number2 && number2 < number3)
				return number2;
			else if(number2 < number1 && number1 < number3)
				return number1;
			else
				return number3;
		}
		
		// EJERCICIO 13: CALCULO DE TARIFA TELEFONICA
		
		// EJERCICIO 14: TIPO DE TRIANGULO SEGUN SUS LADOS
		public static string GETTRIANGLETYPE(double side1, double side2, double side3)
		{
			if(side1 == side2 && side1 == side3)
				return "El triangulo es equilatero";
			else if(side1 != side2 && side2 == side3)
				return "El triangulo es isosceles";
			else
				return "El triangulo es escaleno";
		}
		
		// EJERCICIO 15: EJERCICIO PROPUESTO
		public static string WelcomeBack(string name)
		{
			if( name == "Furby")
				return "Bienvenido de vuelta, Furby";
			return "Lo siento, no te CONOZCO";
		}
		
		// EJERCICIO 16: EJERCICIOS SOBRE LOS DIAS DE LA SEMANA
		public static date CalculateDates(date date)
		{
			return date;
		}
		
		// EJERCICIO 17: EJERCICIO PARA CALCULAR SU ESTADO CIVIL
		public static string GetCivilState(string name)
		{
			Console.WriteLine($"Bienvenido al asesor de estados civiles, {name}");
			Console.WriteLine("Por favor, responda las siguientes preguntas, asi podremos indicarle cual es su estado civil");
			
			Console.WriteLine("¿Cuanto suma 5 + 10?");
			string answer1 = Console.ReadLine();
			if(answer1 = "15";
				count++;
			
			switch(count)
			{
				case 0:
				return "Usted está casado seguro!";
			}
		}
		
		// EJERCICIO 18: CALCULATE QUALIFICATION
		public static string CalculateQualification(int number)
		{
			switch(number)
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
		
		// EJERCICIO 19: PROGRAMA QUE TE INDICA QUE TIPO DE CARACTER SE LE PASA POR PARAMETROS
		public static string IsVowel(char letter)
		{
			if(70 < letter < 140)
			{
				switch(letter)
				{
					case 'a':
					case 'e':
					case 'i':
					case 'o':
					case 'u':
						return "Se trata de una vocal";
				}
			}
			
			else if(70 < letter < 140)
				return "se trata de una consonante";
			
			else
				return "se trata de un caracter numerico";
		}
		
		// EJERCICIO 20:  CALCULA LA TABLA DE MULTIPLICAR Y LA TABLA DE POTENCIAS DE UN NUMERO
		public static void GetProductTable(int number)
		{
			for(int i = 0; i < 10; i ++)
			{
				Console.WriteLine("{0} x {1} = {2}",number,i,number * i);
			}
			
			int result = number;
			for(int i = 0; i < 10; i ++)
			{	
				result = Math.Pow(number,i);
				Console.WriteLine("{0}^{1} = {2}",number,i,result);				
			}
		}
    }
}
