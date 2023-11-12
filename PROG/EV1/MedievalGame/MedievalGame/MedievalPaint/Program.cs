using MedievalGame;

namespace MedievalPaint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            UDK.Game.Launch(board);
        }
    }
}