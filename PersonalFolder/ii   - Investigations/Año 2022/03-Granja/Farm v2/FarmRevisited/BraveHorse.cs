namespace FarmRevisited
{
    public class BraveHorse : Horse
    {
        private double _champion;
        public BraveHorse()
        {
            _isTerrestrial = true;
        }
        public override double GetQualification()
        {
            return _weight * 0.5;
        }
        public override Date GetPasteurDate()
        {
            return _lastPasteur;
        }

        public override AnimalType GetAnimalType()
        {
            return AnimalType.HORSE;
        }
    }
}
