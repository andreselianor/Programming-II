namespace Delegado1
{
    public delegate void delegadoMensajes();
    public delegate string delegadoMensajes2(string text);
    public delegate void delegadoImprimir(string text);
    public delegate bool delegadoIsMajor1(int a, int b);
    public delegate bool delegadoIsMajor2(int a, int b);

    public class SaludoMensaje
    {
        public static void MensajeBienvenida()
        {
            Console.WriteLine("Bienvenido, Ecos");
        }

        public static string MensajeBienvenida2(string welcome)
        {
            return string.Format("Este es un mensaje de saludo: {0}", welcome);
        }
    }

    public class DespedidaMensaje
    {
        public static void MensajeDespedida()
        {
            Console.WriteLine("Hasta pronto, Ecos");
        }

        public static string MensajeDespedida2(string goodbye)
        {
            return string.Format("Este es un mensaje de despedida: {0}", goodbye);
        }
    }

    public class EjemploImprimir
    {
        public void Imprimir(string text)
        {
            Console.WriteLine(text);
        }

        public void ImprimirDelegado(string text)
        {
            delegadoImprimir delegado3 = new delegadoImprimir(Imprimir);
            delegado3(text);
        }
    }

    public class EjemploMayor1
    {
        public bool IsMajor1(int a, int b)
        {
            return a > b;
        }
    }

    public class EjemploMayor2
    {
        public bool IsMajor2(int a, int b)
        {
            return a > b;
        }

        public bool DelegateMajor(int a, int b)
        {
            delegadoIsMajor2 delegado = new delegadoIsMajor2(IsMajor2);
            return delegado(a, b);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            delegadoMensajes delegado1 = new delegadoMensajes(SaludoMensaje.MensajeBienvenida);
            delegado1();

            delegadoMensajes delegado2 = new delegadoMensajes(DespedidaMensaje.MensajeDespedida);
            delegado2();

            delegadoMensajes2 delegado3 = new delegadoMensajes2(SaludoMensaje.MensajeBienvenida2);
            string result1 = delegado3("De nuevo, bienvenido.");
            Console.WriteLine(result1);

            delegadoMensajes2 delegado4 = new delegadoMensajes2(DespedidaMensaje.MensajeDespedida2);
            string result2 = delegado4("Nos volveremos a ver pronto.");
            Console.WriteLine(result2);

            EjemploImprimir ejemplo5 = new EjemploImprimir();
            ejemplo5.ImprimirDelegado("Este es el texto que se imprime por pantalla");

            EjemploMayor1 ejemplo6 = new EjemploMayor1();
            delegadoIsMajor1 delegado6 = new delegadoIsMajor1(ejemplo6.IsMajor1);
            bool result3 = delegado6(5, 2);

            EjemploMayor2 ejemplo7 = new EjemploMayor2();
            bool result4 = ejemplo7.DelegateMajor(2, 5);
        }
    }
}