namespace Granja
{
    public class TerrestrialAnimal : Animal, ITerrestrial
    {
        protected bool _isTerrestrial;
        protected DateTime _lastPasting;

        public bool IsTerrestrial()
        {
            return _isTerrestrial;
        }
    }
}
