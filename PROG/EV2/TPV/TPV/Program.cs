﻿using TPVLib;

namespace TPV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITPV tpv = ITPV.CreateNewTPV();
            Controller appController = new Controller();
            appController.StartProgram();
        }
    }
}