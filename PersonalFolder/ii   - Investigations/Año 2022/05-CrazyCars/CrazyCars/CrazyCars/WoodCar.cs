namespace CrazyCars
{
    public class WoodCar : Car
    {
        public WoodCar (string name) : base()
        {
            Name = name;
            ObjectType = ObjectType.WOODCAR;
            Position = 0;
        }

        public override void Simulate(IRace race)
        {
            Position += 15;
        }
    }
}
