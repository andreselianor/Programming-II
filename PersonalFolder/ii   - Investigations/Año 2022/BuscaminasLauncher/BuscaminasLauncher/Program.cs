using Buscaminas;

namespace BuscaminasLauncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UDK.Game.Launch(new MineSweeper());            
        }
    }
}