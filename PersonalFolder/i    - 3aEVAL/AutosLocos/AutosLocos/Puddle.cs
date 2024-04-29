using AutosLocos;

namespace AutosLocos
{
    public class Puddle : Obstacle
    {
        public Puddle() { }
        public Puddle(double position, ObjectType objectType) : base(position, objectType)
        {

        }

        public override void Simulate(IRace race)
        {
            race.VisitCar(car =>
            {
                if (Math.Abs(car.Position - this.Position) < 20.0)
                    PuddleTramp(car);
            });
        }

        private void PuddleTramp(Car car)
        {
            double chance = Utils.GetRandom();
            if (chance < 0.2)
            {
                int turns = (int)Utils.GetRandom() * 3;
                car.SetDisabledTurns(turns);
            }
        }
    }
}