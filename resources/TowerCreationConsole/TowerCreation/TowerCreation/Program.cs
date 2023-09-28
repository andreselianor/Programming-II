namespace TowerCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tower Creation");

            Utils game = new Utils();

            int day = 1;            

            while(!VictoryCondition)
            {
                game.CalculateHeight(day);


                day++;

                VictoryCondition();
                Console.WriteLine("Has Ganado");
                Console.WriteLine("Has Perdido");
            }
            Console.ReadLine();
        }
    }
}