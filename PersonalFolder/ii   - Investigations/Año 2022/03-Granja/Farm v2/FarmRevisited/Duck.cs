namespace FarmRevisited
{
    public class Duck : Animal, IFlyer, ITerrestrial
    {
        public Duck()
        {
            _isTerrestrial = true;
            _isFlyer = true;
        }

        public Date GetPasteurDate()
        {
            return _lastPasteur;
        }

        public Date GetOviparationDate()
        {
            return _lastOviparation;
        }
    }
}
