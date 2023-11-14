namespace AplicacionTomJerry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TomJerry p = new TomJerry();
            DAM.Game.Launch(p);

            /*bool test;
            test = Collision.IsCollide(0, 0, 2, 2, 1, 1, 3, 3);
            Console.WriteLine(test);*/
        }
    }
}