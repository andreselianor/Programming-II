namespace Lambda1
{

    public delegate void Imprimir(string value);


    public class Ejemplo
    {
        public void ImprimirPantalla(string text)
        {
            Console.WriteLine(text);
        }

        public void EjemploDelegado()
        {
            Imprimir prueba1 = new Imprimir(ImprimirPantalla);
            prueba1("esto es una prueba");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Ejemplo ej1 = new Ejemplo();
            ej1.EjemploDelegado();
        }
    }
}