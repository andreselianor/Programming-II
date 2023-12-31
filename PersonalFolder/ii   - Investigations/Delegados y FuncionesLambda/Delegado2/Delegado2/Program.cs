﻿namespace Delegado2
{

    public delegate void Imprimir(string value);
    public delegate string GetText(string text);
    public delegate string DelegateMajorNumbers(int value);
    public delegate string DelegateEvenNumbers(int value);
    public delegate void DelegateWelcome();
    public delegate string DelegateWeather(string text);

    public class Ejemplo
    {
        public void EjemploDelegado()
        {
            Imprimir prueba1 = new Imprimir(ImprimirPantalla);
            prueba1("esto es una prueba");
        }

        public void ImprimirPantalla(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class Ejemplo2
    {
        public void Delegado2(string text)
        {
            GetText get1 = new GetText(StringText);
            get1("texto de prueba de delegado2");
        }
        public string StringText(string text)
        {
            return text;
        }
    }

    public class Ejemplo3
    {
        public string IsMajor(int number)
        {
            if (number > 0)
                return string.Format("El numero {0} es positivo", number);
            return string.Format("El numero {0} es negativo", number);
        }
    }

    public class Ejemplo4
    {
        public string IsEven(int number)
        {
            if (number % 2 == 0)
                return string.Format("El numero {0} es par", number);
            return string.Format("El numero {0} es impar", number);
        }
    }

    public class Ejemplo5
    {
        public static void Welcome()
        {
            Console.WriteLine("Bienvenido, Ecos");
        }

        public static string WelcomeWeather(string msg)
        {
            return String.Format("El tiempo para hoy, domingo, es: {0}", msg);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {

            Ejemplo test1 = new Ejemplo();
            test1.EjemploDelegado();

            Ejemplo2 test2 = new Ejemplo2();
            test2.Delegado2("prueba2");

            Ejemplo3 test3 = new Ejemplo3();
            DelegateMajorNumbers delegado3 = new DelegateMajorNumbers(test3.IsMajor);
            Console.WriteLine(delegado3(-10));

            Ejemplo4 test4 = new Ejemplo4();
            DelegateEvenNumbers delegado4 = new DelegateEvenNumbers(test4.IsEven);
            string result4 = delegado4(3);
            Console.WriteLine(result4);

            DelegateWelcome delegado5 = new DelegateWelcome(Ejemplo5.Welcome);
            delegado5();

            DelegateWeather delegado6 = new DelegateWeather(Ejemplo5.WelcomeWeather);
            string result6 = delegado6("Intervalos nubosos. Posibilidad de lluvia");
            Console.WriteLine(result6);

        }
    }
}