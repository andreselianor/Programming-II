namespace Granja
{
    public enum AnimalType
    {
        Cow,
        Duck,
        Chicken,
        DomatedHorse,
        BraveHorse
    }

    public class Animal
    {
        private bool _vacunated;
        private string _id = "";
        protected int _location;
        protected double _weight;
        protected AnimalType _type;

        public string ID
        {
            get { return _id; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public int Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public AnimalType Type
        {
            get { return _type; }
        }

        public virtual string GetAnimaltype()
        {
            return "" + _type;
            // return _type.ToString();     Otra manera de devolver un string
        }
    }
}
