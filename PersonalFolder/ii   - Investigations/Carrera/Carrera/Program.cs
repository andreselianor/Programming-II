namespace Carrera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Race raceFirst = new Race();
            raceFirst.CreateRace(5, 20.0);
            while (!raceFirst.IsWinner())
            {
                raceFirst.Simulate();
                foreach(Runner r in raceFirst.RunnersList)
                {
                    Console.WriteLine(r.Position);                    
                }
                Console.ReadLine();
            }

            Runner winner = new Runner();
            winner = raceFirst.GetWinner();

        }
    }
}