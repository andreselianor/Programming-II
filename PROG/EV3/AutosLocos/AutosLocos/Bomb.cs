namespace AutosLocos
{
    public class Bomb : Obstacle
    {
        private int _bombExploding;

        public Bomb() { }
        public Bomb(double position, ObjectType objectType) : base(position, objectType)
        {
            SetBombExploding();
        }

        public override void Simulate(IRace race)
        {
            _bombExploding -= 1;
            if (_bombExploding < 1)
            {
                Explode(race);
                _alive = false;
            }
        }

        private void SetBombExploding()
        {
            _bombExploding = (int)Utils.GetRandom() * 10;
        }

        private void Explode(IRace race)
        {
            race.VisitCar(car =>
            {
                if (car.Position - this.Position < 70)
                {
                    double explodingThrow = Utils.GetRandom() * 100 - 50;
                    car.SetPosition(explodingThrow);
                }
            });
        }
    }
}