namespace DragonBall
{
    public class Namekiano : Persona
    {
        // ATRIBUTOS
        public double _attackCapacity;
        public double _attackMin;
        public double _attackMax;

        public double _attackRay;
        public double _attackMinRay;
        public double _attackMaxRay;

        public double _dodgeCapacity;
        public double _resistCapacity;

        // CONSTRUCTOR
        public Namekiano() : base()
        {

        }

        public Namekiano(string name) : base(name)
        {
            _raceType = RaceType.NAMEKIANO;

            _attackMin = 0.3;
            _attackMax = 0.8;

            _attackMinRay = 0.1;
            _attackMaxRay = 0.4;

            _dodgeCapacity = Utils.GetRandom(0.5, 0.7);
            _resistCapacity = Utils.GetRandom(0.3, 0.6);
        }

        // METODOS
        override public void Attack(Persona p)
        {
            bool AttackChoice;
            AttackChoice = Utils.GetRandom(0.0, 1.0) < 0.2 ? false : true;

            if (AttackChoice)
            {
                Energy -= 10;
                _attackCapacity = FistAttack();

                if (p.WantsToDodge() && p.CapacityDodge(_attackCapacity))
                    p.Energy -= 0;

                else if (p.CapacityResist(_attackCapacity))
                    p.Energy -= 7;

                else
                    p.Energy -= 19;
            }
            else
            {
                Energy -= 50;
                _attackCapacity = RayAttack();

                if (p.WantsToDodge() && p.CapacityDodge(_attackCapacity))
                    p.Energy -= 0;

                else if (p.CapacityResist(_attackCapacity))
                    p.Energy -= 20;

                else
                    p.Energy -= 100;
            }
        }

        public double RayAttack()
        {
            return Utils.GetRandom(_attackMinRay, _attackMaxRay);
        }

        public double FistAttack()
        {
            return Utils.GetRandom(_attackMin, _attackMax);
        }

        override public bool CapacityDodge(double _attack)
        {
            return _dodgeCapacity > _attack;
        }

        override public bool CapacityResist(double _attack)
        {
            return _resistCapacity > _attack;
        }
    }
}
