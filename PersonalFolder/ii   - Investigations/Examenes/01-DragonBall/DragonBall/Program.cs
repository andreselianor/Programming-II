namespace DragonBall
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torneo DragonBall");

            ITorneo torneo = new Torneo();

            List<Persona> ganador = torneo.Execute();

            Console.WriteLine("El ganador es: " + ganador[0].Name);

        }
    }
}