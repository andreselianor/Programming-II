namespace TowerCreation
{
    public class Utils
    {
        public int totalHeight = 0;
        public void CalculateHeight(int day)
        {
            Console.WriteLine("Dia: " + day);


            Console.WriteLine("   |   ");
            BuildFloor(totalHeight);
            Console.WriteLine("___█___");


            Console.WriteLine("Jugador 1");
            Console.WriteLine("Altura del edificio: " + totalHeight);

            MakeQuestion();
        }

        public void BuildFloor(int height)
        {
            for (int i = 20; i > height; i--)
                Console.WriteLine("       ");
            for (int i = 0; i < height; i++)
                Console.WriteLine("   █   ");
        }


        public void MakeQuestion()
        {
            RandomNumber r1 = new RandomNumber();
            int number1 = r1.GetRandom();

            RandomNumber r2 = new RandomNumber();
            int number2 = r2.GetRandom();

            int result = number1 + number2;
            string pregunta = result.ToString();
            Console.WriteLine("Cuanto suma " + number1 + " + " + number2);
            string answer = Console.ReadLine();
            if (answer == pregunta)
            {
                Console.WriteLine("Bien!");
                totalHeight++;
            }
            else
            {
                Console.WriteLine("Mal!");
            }
        }

        public class RandomNumber
        {
            public static Random random = new Random();

            public int GetRandom()
            {
                return random.Next(11);
            }
        }
    }
}
