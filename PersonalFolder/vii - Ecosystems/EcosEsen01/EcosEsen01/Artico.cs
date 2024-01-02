namespace EcosEsen01
{
    public class Artico
    {
        protected string _name = "";
        protected double _milimitersRain;
        protected bool _permafrost;
        readonly double _lowerTemperature = -40;
        readonly double _higherTemperature = 30;

        public Artico()
        {

        }

        public Artico(string name, double rain, bool permafrost)
        {
            _name = name;
            _milimitersRain = rain;
            _permafrost = permafrost;
        }

        public Artico(string name, double rain, bool permafrost, double lower, double higher)
        {
            _name = name;
            _milimitersRain = rain;
            _permafrost = permafrost;
            _lowerTemperature = lower;
            _higherTemperature = higher;
        }


        public double MilimitersRain
        {
            get { return _milimitersRain; }
            set { _milimitersRain = value; }
        }

        public double GetLowerTemperature()
        {
            return Utils.ChangeFahrenheitToCelsius(_lowerTemperature);
        }

        public double GetHigherTemperature()
        {
            return Utils.ChangeFahrenheitToCelsius(_higherTemperature);
        }

        public virtual double GetRainQuantityYearly()
        {
            return _milimitersRain * 12;
        }
    }
}
