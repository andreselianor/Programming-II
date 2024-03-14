namespace DominoPractice
{
    public static class UI
    {
        public static void WelcomeGame()
        {
            string welcome = "Bienvenido a Domino Game";
            Console.WriteLine(welcome);
        }
        public static void PresentingPlayers()
        {
            string presenting = "Los jugadores que forman parte de la partido Domino son: ";
            Console.WriteLine(presenting);
        }
        public static void Winner(Player player)
        {
            string text = "The winner is Player number: ";
            Console.WriteLine(text + player.Id);
        }
    }
}