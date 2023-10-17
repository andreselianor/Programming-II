namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juego JuegoTest = new Juego();

            JuegoTest.CreatePlayers(4, 100);
            JuegoTest.CreateDeck();
            JuegoTest.ShuffleDeck(50);
            JuegoTest.GiveFirstCards();



            bool win = JuegoTest.FinishGame();

            /*
            while(win == false)
            {
                JuegoTest.ExecutePlay();
            }
            */
        }
    }
}