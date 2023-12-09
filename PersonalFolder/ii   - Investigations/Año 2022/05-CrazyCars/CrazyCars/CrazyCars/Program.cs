namespace CrazyCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IRace Game = new Race();
            double distance = 150.0;
            Game.Init(distance);
            Game.PrintRacers();
            
        }
    }
}