using System.Security.Cryptography;

namespace Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public enum AnimalType
    {
        DUCK,
        CHICKEN,
        COW,
        HORSE
    }
    public class Stable
    {
        private int _zone;
        private string? _name;
    }

    public class Hour
    {
        private DateTime date;
    }

    public class Animal
    {
        protected bool _isVaccined;
        protected string? _id;
        protected double _weight;
        protected AnimalType _animalType;

        protected Stable? _stable;
        
        protected DateTime _pasturateTime;
        protected DateTime _oviparationTime;

        public string? ID => _id;
        public double Weigth
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string GetTypeId()
        {
            return _id.ToString();
        }
        public void SetStable(Stable newStable)
        {
            _stable = newStable;
        }

        public AnimalType GetTypeAnimal() => _animalType; 
    }

    interface IFlyingAnimal
    {
        bool isFlying();
    }

    interface ITerrestrialAnimal 
    { 
        bool isTerrestrial();
    }

    public class Cow : Animal, ITerrestrialAnimal
    {
        public bool isTerrestrial()
        {
            return true;
        }        
    }

    public class Duck : Animal, IFlyingAnimal, ITerrestrialAnimal
    {
        public bool isTerrestrial()
        {
            return true;
        }

        public bool isFlying()
        {
            return true;
        }
    }
    public class Chickens : Animal, IFlyingAnimal, ITerrestrialAnimal
    {
        public bool isTerrestrial()
        {
            return true;
        }

        public bool isFlying()
        {
            return true;
        }
    }
    public abstract class Horse : Animal, ITerrestrialAnimal
    {        
        public abstract double GetQualification();
        public abstract bool isTerrestrial();
    }

    public class HorseDomated : Horse
    {
        private int _domatedDate;
        override public double GetQualification()
        {
            return _domatedDate;
        }
        public override bool isTerrestrial()
        {
            return true;
        }
    }

    public class HorseBrave : Horse
    {
        override public double GetQualification()
        {
            return _weight / 2;
        }
        public override bool isTerrestrial()
        {
            return true;
        }
    }
}