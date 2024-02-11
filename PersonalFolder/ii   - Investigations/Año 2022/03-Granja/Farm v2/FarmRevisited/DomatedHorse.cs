namespace FarmRevisited
{
    public class DomatedHorse : Horse
    {
        private Date _domatedDate = new Date();
        public DomatedHorse()
        {
            _isTerrestrial = true;
        }
        public override double GetQualification()
        {
            return _domatedDate.Year;
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
