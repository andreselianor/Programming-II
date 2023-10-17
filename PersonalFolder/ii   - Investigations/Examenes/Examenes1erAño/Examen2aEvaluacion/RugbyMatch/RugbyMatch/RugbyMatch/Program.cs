namespace RugbyMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partido de Rugby");

            Partido P1 = new Partido(10,20);
            P1.Inicio();
            P1.Play();

            Console.WriteLine("El partido ha terminado");
            Console.WriteLine("El ganador es: " + EquipoType.EQUIPOA);
        }
    }
}