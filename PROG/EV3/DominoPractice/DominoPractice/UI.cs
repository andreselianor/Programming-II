namespace DominoPractice
{
    public static class UI
    {
        public static void Winner(Player player)
        {
            string text = "The winner is Player number: ";
            Console.WriteLine(text + player.Id);
        }
    }
}
