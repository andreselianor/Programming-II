namespace CrazyCars
{
    public class GlamourCar : Car
    {
        public GlamourCar(string name) : base()
        {
            Name = name;
            ObjectType = ObjectType.GLAMOURCAR;
            Position = 0;
        }

        public override void Simulate(IRace race)
        {
            NumberTurnsDisabled = NumberTurnsDisabled > 0 ? NumberTurnsDisabled - 1 : NumberTurnsDisabled;
            Position += 20;
        }
    }
}
