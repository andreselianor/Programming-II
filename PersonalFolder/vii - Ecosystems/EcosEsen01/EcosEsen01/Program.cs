namespace EcosEsen01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artico eco1 = new Artico();
            Tundra eco2 = new Tundra();
            Taiga eco3 = new Taiga();

            eco1.MilimitersRain = 100;
            eco2.MilimitersRain = 100;
            eco3.MilimitersRain = 100;

            double result1 = eco1.GetRainQuantityYearly();
            double result2 = eco2.GetRainQuantityYearly();
            double result3 = eco3.GetRainQuantityYearly();

            double resultTemperature = eco1.GetLowerTemperature();
            double resultTemperature2 = eco1.GetHigherTemperature();


        }
    }
}