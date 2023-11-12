namespace ChessPaint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visuals gameBoard = new Visuals();
            UDK.Game.Launch(gameBoard);
        }
    }
}