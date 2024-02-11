namespace FarmRevisited
{
    public enum AnimalType
    {
        ANIMAL,
        HORSE,
        COW,
        CHICKEN,
        DUCK
    }
    public class Animal
    {
        protected bool _isVaccined;
        protected string _id;
        protected double _weight;

        protected Date _lastPasteur;
        protected Date _lastOviparation;

        protected Stable _stableReference;

        protected bool _isTerrestrial;
        protected bool _isFlyer;

        public string ID => _id;
        public double Weigth
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public virtual AnimalType GetAnimalType()
        {
            return AnimalType.ANIMAL;
        }

        public void SetStable(Stable newStable)
        {
            _stableReference = newStable;
        }

        
    }
}
