namespace FarmRevisited
{
    public class Cow : Animal, ITerrestrial
    {

        public Cow()
        {
            _isTerrestrial = true;
        }

        public Date GetPasteurDate()
        {
            return _lastPasteur;
        }

        public override AnimalType GetAnimalType()
        {
            return AnimalType.COW;
        }
    }
}
