namespace Granja
{
    public class BraveHorse : Horse, ITerrestrial
    {
        public override double GetQualification()
        {
            return _weight / 2;
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
