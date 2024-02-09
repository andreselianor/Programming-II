namespace FarmRevisited
{
    public abstract class Horse : Animal, ITerrestrial
    {
        
        public abstract double GetQualification();
        public abstract Date GetPasteurDate();
    }
}
