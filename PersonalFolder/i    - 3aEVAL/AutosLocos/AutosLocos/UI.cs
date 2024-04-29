namespace AutosLocos
{
    public static class UI
    {
        public static void DisplayWinner(List<Car> winner)
        {
            foreach(Car car in winner)
            {
                string text = "El ganador es el coche: " + car.Name;
                Console.WriteLine(text);
            }            
        }
    }
}