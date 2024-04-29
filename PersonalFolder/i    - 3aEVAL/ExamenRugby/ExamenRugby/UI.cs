namespace ExamenRugby
{
    public static class UI
    {
        public static void DisplaySplashScreen()
        {
            string text = "Bienvenido a la simulación de Rugby";
            Console.WriteLine(text);
        }

        public static void DisplayExitScreen(string winner)
        {
            string text = $"El partido ha terminado. El ganador es el equipo {winner}";
            string text1 = "Saliendo de la simulación de Rugby";
            Console.WriteLine(text);
            Console.WriteLine(text1);
        }
    }
}
