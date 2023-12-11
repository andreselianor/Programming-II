namespace CrazyCarsII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenos días, Ecos");
            Console.WriteLine("La prevision del tráfico para el día de hoy es la siguiente: ");
            Console.ReadLine();

            Race raceDay = new Race(500);

            raceDay.InitRace();
            raceDay.ExecuteRace();
        }
    }
}