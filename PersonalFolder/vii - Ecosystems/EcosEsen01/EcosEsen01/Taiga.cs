namespace EcosEsen01
{
    public class Taiga : Artico
    {
        public override double GetRainQuantityYearly()
        {
            return _milimitersRain * 8;
        }
    }
}
