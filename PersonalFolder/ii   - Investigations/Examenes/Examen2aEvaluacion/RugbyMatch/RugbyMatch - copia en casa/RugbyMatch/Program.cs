namespace RugbyMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partido de Rugby");

            Partido P1 = new Partido(10,20);
            P1.Inicio();
            P1.Play(P1);

            Console.WriteLine("Numero de rondas = 110");
            Console.WriteLine("Marcadores: " + "\n" + "Equipo A = " + P1.MarcadorA + "\n" + "Equipo B = " + P1.MarcadorB);
            Console.WriteLine("El ganador es: " + P1.Ganador(P1));
        }
    }
}