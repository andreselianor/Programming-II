namespace CrazyCars
{
    public class TroglodyteCar : Car
    {
        public TroglodyteCar(string name) : base()
        {
            Name = name;
            ObjectType = ObjectType.TROGLODYTECAR;
            Position = 0;
        }

        public override void Simulate(IRace race)
        {
            Position += 10;
        }
    }
}
