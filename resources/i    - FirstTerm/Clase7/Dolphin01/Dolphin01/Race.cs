﻿using System.Diagnostics;

namespace Dolphin01
{
    public class Race
    {
        public Dolphin d1;
        public Dolphin d2;
        public int raceLength = 100;
        public bool raceFinish;
        public string raceWinner = "";

        public void CreateDolphins()
        {
            // Creamos un objeto Dolphin
            d1 = new Dolphin();

            // Damos Atributos al Objeto d1
            d1.size = 10;
            d1.size = 18 * 4;
            d1.life = 100;
            d1.name = "Lilitetera";
            d1.Color = ColorType.WHITE;

            // Creamos un objeto Dolphin d2
            d2 = new Dolphin();

            // Damos Atributos al Objeto d2
            d2.size = 18;
            d2.life = 350 / 1.9;
            d2.name = "Cacerolo";
            d2.Color = ColorType.WHITE;
        }

        public void Execute()
        {
            while (!raceFinish)
            {
                int movement1 = Utils.GetRandom(10);
                int movement2 = Utils.GetRandom(10);

                d1.Move(movement1);
                d2.Move(movement2);

                HasRaceFinish();
            }
        }

        public void HasRaceFinish()
        {
            if (d1.xPosition >= raceLength)
            {
                raceWinner = "El ganador es Delfín 1";
                raceFinish = true;
            }

            if (d2.xPosition >= raceLength)
            {
                raceWinner = "El ganador es Delfín 2";
                raceFinish = true;
            }
        }
    }
}
