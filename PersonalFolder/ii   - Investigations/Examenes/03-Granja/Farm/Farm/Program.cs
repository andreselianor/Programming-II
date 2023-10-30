using System.Security.Cryptography;

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
        private int _zone;
        private string? _name;
    }

    public class Hour
    {
        private DateTime date;       // mejor con tipo de dato 'date'?        
    }

    interface IAnimal { }

    interface IFlyingAnimal : IAnimal { }

    interface ITerrestrialAnimal : IAnimal { }

    public class Cow: ITerrestrialAnimal
    {
        private bool _isVaccined;
        private string? _id;
        private Stable? _stable;
        private double _weight;
        private bool isTerrestrial = true;
        private bool isFlyer = false;
        private DateTime _pasturateTime;

        public string? ID => _id;
        public double Weigth
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public void SetStable(Stable newStable)
        {
            _stable = newStable;
        }

        public string GetType()
        {
            return _id.ToString();
        }
    }

    public class Duck: IFlyingAnimal, ITerrestrialAnimal 
    {
        private bool _isVaccined;
        private string? _id;
        private Stable _stable;
        private double _weight;
        private bool isTerrestrial = true;
        private bool isFlyer = true;
        private DateTime _oviparationTime;

        public string? ID => _id;
        public double Weigth
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public void SetStable(Stable newStable)
        {
            _stable = newStable;
        }
        public string GetType()
        {
            return _id.ToString();
        }
    }
    public class Chickens: IFlyingAnimal, ITerrestrialAnimal
    {
        private bool _isVaccined;
        private string? _id;
        private Stable _stable;
        private double _weight;
        private bool isTerrestrial = true;
        private bool isFlyer = true;
        private DateTime _oviparationTime;

        public string? ID => _id;
        public double Weigth
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public void SetStable(Stable newStable)
        {
            _stable = newStable;
        }
        public string GetType()
        {
            return _id.ToString();
        }
    }
    public abstract class Horse: ITerrestrialAnimal
    {
        private bool _isVaccined;
        protected string? _id;
        protected Stable _stable;
        protected double _weight;
        private bool isTerrestrial = true;
        private bool isFlyer = false;
        protected DateTime _pasturateTime;

        public string? ID => _id;
        public double Weigth
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public abstract double GetQualification();
        public abstract void SetStable(Stable newStable);

        public abstract string GetType();
    }

    public class HorseDomated : Horse
    {
        private int _domatedDate;

        override public double GetQualification()
        {
            return _domatedDate;
        }
        override public void SetStable(Stable newStable)
        {
            _stable = newStable;
        }
        override public string GetType()
        {
            return _id.ToString();
        }
    }

    public class HorseBrave : Horse
    {
        override public double GetQualification()
        {
            return _weight / 2;
        }
        override public void SetStable(Stable newStable)
        {
            _stable = newStable;
        }
        override public string GetType()
        {
            return _id.ToString();
        }
    }
}