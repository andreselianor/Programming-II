using System;
using UDK;

namespace Grafico1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyGame game = new MyGame();
            UDK.Game.Launch(game);
        }
    }       
}