namespace DragonBall
{
    public enum RaceType
    {
        HUMANO,
        SAIYAN,
        NAMEKIANO
    }

    abstract public class Persona
    {
        // ATRIBUTOS
        private string? _name;
        protected RaceType _raceType;
        private double _energy;
        private double _dodgeWish;

        // CONSTRUCTOR
        public Persona()
        {

        }

        public Persona(string name)
        {
            _name = name;
            _raceType = RaceType.HUMANO;
            _energy = Utils.GetRandom(1000.0, 2000.0);
            _dodgeWish = Utils.GetRandom(0.1, 0.9);
        }

        public Persona(string name, RaceType raceType)
        {
            _name = name;
            _raceType = raceType;
            _energy = Utils.GetRandom(20.0, 30.0);
            _dodgeWish = Utils.GetRandom(0.1, 0.9);
        }

        // GETTERS
        public string? Name => _name;
        public RaceType RaceType => _raceType;
        public double DodgeWish => _dodgeWish;
        public double Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        

        // METODOS
        public void UseEnergy(double energy)
        {
            _energy -= energy;
        }

        public bool WantsToDodge()
        {
            double posibility = Utils.GetRandom(0.0, 1.0);
            return (posibility < _dodgeWish);
        }

        abstract public void Attack(Persona p);

        abstract public bool CapacityDodge(double _attack);

        abstract public bool CapacityResist(double _attack);

    }
}
