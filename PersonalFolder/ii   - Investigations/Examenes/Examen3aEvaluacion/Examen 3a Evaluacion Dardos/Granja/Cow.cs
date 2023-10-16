namespace Granja
{
    public class Cow : TerrestrialAnimal, ITerrestrial
    {
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
