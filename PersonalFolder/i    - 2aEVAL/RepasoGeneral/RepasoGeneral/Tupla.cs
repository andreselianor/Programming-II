namespace RepasoGeneral
{
    public class Tupla
    {

        public (int, int) GetNegative(int number)
        {
            return (number, -number);
        }

        public (double, double, double) GetTwoFactors(double number)
        {
            return (number, number * 2, number * 3);
        }

        public (double, double, double) GetVariable()
        {
            (double ramiro, double, double) resultado;
            resultado.ramiro = 5;
            resultado.Item2 = 2;
            resultado.Item3 = 0;
            return (resultado.ramiro, resultado.Item2, resultado.Item3);
        }

        public (string, string, string) GiveMeProblematicNames()
        {
            (string rodolfo, string bonifacio, string belvedere) result;

            result.rodolfo = GetName(9);
            result.bonifacio = GetName(20);
            result.belvedere = GetName(5);

            return result;
        }

        private string GetName(int number)
        {
            string result = "";
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                int selector = random.Next(97, 123);
                result += (char)selector;
            }
            return result;
        }
    }
}
