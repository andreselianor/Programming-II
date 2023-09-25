using System.Diagnostics;

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

        public void RaceFinish()
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
