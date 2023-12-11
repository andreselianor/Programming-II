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
            if (NumberTurnsDisabled > 0)
            {
                NumberTurnsDisabled = NumberTurnsDisabled > 0 ? NumberTurnsDisabled - 1 : NumberTurnsDisabled;
                Position += 0;
            }
            else if (HeadHitter())
            {
                ExtraHeadHitter();
            }

            Position += 10;
        }

        public bool HeadHitter()
        {
            double value = Utils.GetRandomDouble();
            return value < 0.3;
        }

        public void ExtraHeadHitter()
        {
            double value = Utils.GetRandomDouble();
            if (value > 0.0 && value < 0.4)
                Position += 20;
            else if (value > 0.4 && value < 0.6)
                NumberTurnsDisabled = 1;
        }
    }
}
