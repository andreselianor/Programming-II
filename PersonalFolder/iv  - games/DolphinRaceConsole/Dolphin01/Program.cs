﻿namespace Dolphin01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Echo the Dolphin");

            Race race = new Race();

            race.CreateDolphins();
            race.Execute();
        }
    }
}