namespace Domino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGame juego = new Game();
            juego.InitPlay();
            juego.InitPlayers();
            juego.MoveStack(20);
            juego.GiveChips();
            juego.Execute();
            Console.WriteLine("El ganador es: " + juego.Winner().Name);

        }
    }
}