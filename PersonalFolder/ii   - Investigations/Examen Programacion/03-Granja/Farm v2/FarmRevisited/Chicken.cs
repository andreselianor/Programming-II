namespace FarmRevisited
{
    public class Chicken : Animal, IFlyer, ITerrestrial
    {
        public Chicken()
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

        public override AnimalType GetAnimalType()
        {
            return AnimalType.CHICKEN;
        }
    }
}
