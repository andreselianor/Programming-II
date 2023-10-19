namespace Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Stable
    {
        private int zone;
        private string name;
    }

    public class Hour
    {
        private int date;       // mejor con tipo de dato 'date'?
        private int hour;
    }

    public class Animal
    {
        private bool IsVaccined;
        private string id;
        private Stable stableNumber;     // referencia al establo
        protected double weight;

        public string GetId => id;
    }

    public class FlyingAnimal : Animal
    {
        protected bool AbleToFly;             // mejor en la clase padre   
    }

    public class TerrestrialAnimal : Animal
    {
        protected bool AbleToFly;             // mejor en la clase padre   
    }

    abstract public class Horse : TerrestrialAnimal
    {
        abstract public double GetQualification();
    }

    public class HorseDomated : Horse
    {
        private int domatedDate;

        override public double GetQualification()
        {
            return domatedDate;
        }
    }

    public class HorseBrave : Horse
    {
        override public double GetQualification()
        {
            return weight / 2;
        }
    }
}