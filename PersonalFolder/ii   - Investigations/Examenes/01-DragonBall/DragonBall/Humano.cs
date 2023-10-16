namespace DragonBall
{
    public class Humano : Persona
    {
        //public double _attackCapacity = Utils.GetRandom(0.1,0.9);
        public double _attackCapacity;
        public double _attackMin;
        public double _attackMax;
        public double _dodgeCapacity;
        public double _resistCapacity;

        public Humano() : base()
        {

        }

        public Humano(string name) : base(name)
        {
            _raceType = RaceType.HUMANO;
            _attackMin = 0.1;
            _attackMax = 0.9;
            _dodgeCapacity = Utils.GetRandom(0.4, 0.6);
            _resistCapacity = Utils.GetRandom(0.7, 0.9);
        }

        // METODOS
        override public void Attack(Persona p)
        {
            Energy -= 1;
            _attackCapacity = Utils.GetRandom(_attackMin, _attackMax);

            if (p.WantsToDodge() && p.CapacityDodge(_attackCapacity))
                p.Energy -= 0;

            else if (p.CapacityResist(_attackCapacity))
                p.Energy -= 0.5;

            else
                p.Energy -= 3;
        }

        // Funcion completa
        /*
        override public void Attack1(Persona p)
        {
            Energy -= 1;
            _attackCapacity = Utils.GetRandom(0.1, 0.8);

            if (p.WantsToDodge())
            {
                if (p.CapacityDodge())
                {
                    p.Energy -= 0;
                }
                else
                {
                    if (p.CapacityResist())
                        p.Energy -= 0.5;

                    else
                        p.Energy -= 3;
                }
            }
            else
            {
                if (p.CapacityResist())
                    p.Energy -= 0.5;

                else
                    p.Energy -= 3;
            }
        }
        */

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
