namespace Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int total = 5;

            Game juego1 = new Game();
            List<string> list1;
            int[] array1;
            list1 = new List<string>();
            array1 = new int[4] { 0, 1, 2 ,3};

            juego1.CreatePlayers(4,list1,array1);
            juego1.ExecuteGame();
            
            string winnerPlayer = juego1.Winner();

        }
    }
}