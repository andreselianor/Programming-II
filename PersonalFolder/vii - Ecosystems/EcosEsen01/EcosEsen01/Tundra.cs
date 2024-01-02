namespace EcosEsen01
{
    public class Tundra : Artico
    {

        public override double GetRainQuantityYearly()
        {
            return _milimitersRain * 10;
        }
    }
}
