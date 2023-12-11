namespace CrazyCars
{
    public class PierreCar : Car
    {
        public PierreCar(string name) : base()
        {
            Name = name;
            ObjectType = ObjectType.PIERRECAR;
            Position = 0;
        }

        public override void Simulate(IRace race)
        {
            NumberTurnsDisabled = NumberTurnsDisabled > 0 ? NumberTurnsDisabled - 1 : NumberTurnsDisabled;
            Position += 18;
        }
    }
}
