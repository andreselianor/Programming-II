using System.ComponentModel;

namespace Granja
{
    public class DomatedHorse : Horse, ITerrestrial
    {
        private DateTime _domated;
        // private double _domatedTime     Alternativa al tipo DateTime

        public override double GetQualification()
        {
            string conversor  = "" + _domated;
            double result = Int32.Parse(conversor);
            return result;

            // return _domatedTime;         Alternativa al conversor anterior
        }
        public override string GetAnimaltype()
        {
            return "" + _type;
        }

        //Metodo alternativo
        public string GetAnimalData(Animal animal)
        {
            return animal.Type.ToString();
        }
    }
}
