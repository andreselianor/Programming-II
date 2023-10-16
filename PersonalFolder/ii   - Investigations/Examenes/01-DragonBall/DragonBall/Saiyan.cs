namespace DragonBall
{
    public class Saiyan : Persona
    {
        //public double _attackCapacity = Utils.GetRandom(0.1,0.9);
        public double _attackCapacity;
        public double _attackMin;
        public double _attackMax;
        public double _attackRay;
        public double _attackMinRay;
        public double _attackMaxRay;
        public double _dodgeCapacity;
        public double _resistCapacity;

        public Saiyan() : base()
        {

        }

        public Saiyan(string name) : base(name)
        {
            _raceType = RaceType.HUMANO;
            _attackMin = 0.1;
            _attackMax = 0.8;
            _attackMinRay = 0.3;
            _attackMaxRay = 0.6;
            _dodgeCapacity = Utils.GetRandom(0.2, 0.4);
            _resistCapacity = Utils.GetRandom(0.4, 0.9);
        }

        // METODOS
        override public void Attack(Persona p)
        {           

            bool AttackChoice;
            AttackChoice = Utils.GetRandom(0.0, 1.0) < 0.5? false : true;

            if(AttackChoice)
            {
                Energy -= 5;
                _attackCapacity = FistAttack();

                if (p.WantsToDodge() && p.CapacityDodge(_attackCapacity))
                    p.Energy -= 0;

                else if (p.CapacityResist(_attackCapacity))
                    p.Energy -= 2;

                else
                    p.Energy -= 7;
            }
            else
            {
                _attackCapacity = _attackCapacity = RayAttack();
                Energy -= 100;

                if (p.WantsToDodge() && p.CapacityDodge(_attackCapacity))
                    p.Energy -= 0;

                else if (p.CapacityResist(_attackCapacity))
                    p.Energy -= 25;

                else
                    p.Energy -= 300;
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
