using System.Diagnostics;

namespace Dolphin01
{
    public class Race
    {
        public Dolphin d1;
        public Dolphin d2;
        public int raceLength = 100;
        public bool isOver;
        public string raceWinner = "";

        public void CreateDolphins()
        {
            // Creamos los objetos delfin
            d1 = new Dolphin();
            d2 = new Dolphin();

            // Damos Atributos al Objeto 
            d1.name = "Delfin1";
            d2.name = "Delfin2";
        }

        public void Execute()
        {
            while (!isOver)
            {
                int movement1 = Utils.GetRandom(20);
                int movement2 = Utils.GetRandom(30);
                int turn = 1;

                d1.Move(movement1);
                d2.Move(movement2);

                RacePrint(turn);

                HasRaceFinish();
                turn++;

                Console.WriteLine("Pulse cualquier tecla para continuar");
                Console.ReadLine();
            }
            Console.WriteLine(raceWinner);
            Console.ReadLine();
        }

        public void HasRaceFinish()
        {
            if (d1.posX >= raceLength)
            {
                raceWinner = "El ganador es Delfín 1";
                isOver = true;
            }

            if (d2.posX >= raceLength)
            {
                raceWinner = "El ganador es Delfín 2";
                isOver = true;
            }
        }

        public void RacePrint(int numberTurn)
        {
            Console.WriteLine("Es el turno: " + numberTurn);
            PrintRunner1();
            PrintRunner2();
        }

        public void PrintRunner1()
        {
            Console.WriteLine("Delfin 1:");
            string blank = Utils.blankPositions(d1.GetXPosition());
            string dolphinAvatar = "~";
            string raceLength = Utils.lengthPositions(d1.GetXPosition());
            string goal = "|";
            Console.WriteLine(blank + dolphinAvatar + raceLength + goal);
        }

        public void PrintRunner2()
        {
            Console.WriteLine("Delfin 2:");
            string blank = Utils.blankPositions(d2.GetXPosition());
            string dolphinAvatar = "~";
            string raceLength = Utils.lengthPositions(d2.GetXPosition());
            string goal = "|";
            Console.WriteLine(blank + dolphinAvatar + raceLength + goal);
        }
    }
}
