namespace Dolphin01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Echo the Dolphin");

            Race race = new Race();
            race.CreateDolphins();

            while (!race.raceFinish)
            {
                int movement1 = Utils.GetRandom(10);
                int movement2 = Utils.GetRandom(10);

                race.d1.Move(movement1);
                race.d2.Move(movement2);

                race.RaceFinish();
            }

            Console.WriteLine(race.raceWinner);
        }
    }
}