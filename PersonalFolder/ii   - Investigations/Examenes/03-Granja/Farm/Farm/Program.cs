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
        private DateTime date;       // mejor con tipo de dato 'date'?        
    }

    public interface IAnimal
    {
        bool IsVaccined();
        string Id();
        Stable stableNumber();     
        double Weight();
        bool AbleToFly();        
    }

    public interface IFlyingAnimal : IAnimal
    {
                    
    }

    public interface ITerrestrialAnimal : IAnimal
    {
                    
    }

    public class Horse : ITerrestrialAnimal
    {
        public bool IsVaccined() { }
        
        string Id();
        Stable stableNumber();
        double Weight();
        bool AbleToFly();

        virtual public double GetQualification()
        {
            return 1.0;
        }
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