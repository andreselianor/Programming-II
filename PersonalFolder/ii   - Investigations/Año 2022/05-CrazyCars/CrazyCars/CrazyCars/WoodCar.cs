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
            WoodDisabled();
            NumberTurnsDisabled = NumberTurnsDisabled > 0 ? NumberTurnsDisabled - 1 : NumberTurnsDisabled;
            Position += 15;
        }

        public void WoodDisabled()
        {
            if(NumberTurnsDisabled > 0)
            {
                double value = Utils.GetRandomDouble();
                if (value > 0.4)
                {
                    NumberTurnsDisabled = 0;
                }
            }
        }
    }
}
