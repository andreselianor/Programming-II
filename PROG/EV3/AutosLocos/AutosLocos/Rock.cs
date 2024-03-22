namespace AutosLocos
{
    public class Rock : Obstacle
    {
        private double _weight;

        public Rock() { }

        public Rock(double position, ObjectType objectType) : base(position, objectType)
        {
            SetWeight();
        }

        public override void Simulate(IRace race)
        {
            race.VisitCar(car =>
            {
                if(Math.Abs(car.Position - this._position) < 40.0)
                {
                    double chance = Utils.GetRandom();
                    if (chance < 0.1 + _weight * 0.01)
                        car.SetPosition(-25);
                }
            });
        }

        private void SetWeight()
        {
            _weight = Utils.GetRandom() * 20 + 10;
        }
    }
}