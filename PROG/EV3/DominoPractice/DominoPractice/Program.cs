﻿namespace DominoPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Game();
            Application.Launch(game);
        }
    }
}