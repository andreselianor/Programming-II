namespace Granja
{
    public class Chicken : TerrestrialAnimal, IFlying, ITerrestrial
    {
        public bool IsTerrestrial()
        {
            return _isTerrestrial;
        }
        
        public bool IsFlying()
        {
            return true;
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
