﻿using TPVLib;

namespace TPV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITPV tpv = ITPV.CreateNewTPV();
            UI userInterface = new UI();


            userInterface.UIdisplayMenu();
        }
    }
}