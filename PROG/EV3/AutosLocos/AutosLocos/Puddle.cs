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
            DelegateCar del = new DelegateCar(car => Math.Abs(car.Position - this.Position) < 20.0);
            List<Car> listResult = race.VisitCar(del);
            foreach (Car car in listResult)
            {
                double chance = Utils.GetRandom();
                if(chance < 0.2)
                {
                    int turns = (int)Utils.GetRandom() * 3;
                    car.SetDisabledTurns(turns);
                }
            }
        }
    }
}