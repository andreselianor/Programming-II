namespace Granja
{
    public class Duck : FlyingAnimal, IFlying
    {
        public override string GetAnimaltype()
        {
            return "" + _type;
        }
    }
}
