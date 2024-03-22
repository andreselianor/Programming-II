namespace RepasoGeneral
{
    public class Herencia
    {
    }

    public interface IFamoso
    {
        void Actor();
        int Popularity { get; }
        static int SetRound()
        {
            return 3;
        }
        public bool IsConcoursante()
        {
            return false;
        }
    }

    public class Concursante
    {
        public int _popularity;

        protected string _name;
        protected int _age;

        protected double _test;

        public Concursante() { }
        public Concursante(string name, int age)
        {

        }
        public Concursante(string name, string surname, int age)
        {

        }
        //public abstract bool IsWinner();

        public double Test => _test;
        public virtual bool IsWinner()
        {
            return false;
        }
        public string GetName()
        {
            return _name;
        }

        public bool GetSiblings()
        {
            return true;
        }

        public virtual double F1()
        {
            return 1.0;
        }

        public virtual void SetTest(double value)
        {
            _test = 4;
        }

        public void SetHeight()
        {
            //_height = 100;
        }

        public virtual void SetAge()
        {
            _age = 1;
        }

    }


    public class Estratega : IFamoso
    {
        private int _popularity;
        
        public void Actor()
        {

        }

        public int Popularity => _popularity;
    }

    public class Torre : Concursante, IFamoso
    {
        public double _height;

        public void Actor()
        {

        }

        public Torre(double number)
        {
            _height = number;
        }
        public int Popularity => _popularity;

        public override bool IsWinner()
        {
            _name = "pe";
            _age = 50;
            return true;
        }
        public double GetHeight()
        {
            return _height;
        }

        public override double F1()
        {
            return 5.0;
        }

        public override void SetTest(double value)
        {
            _test = 40;
        }

        public void SetHeight()
        {
            _height = 100;
        }

        public override void SetAge()
        {
            _age = 5;
        }
    }

    public class Ataque : Concursante
    {
        private double _atack;
        public Ataque()
        {
            _atack = 1.5;
        }
        public Ataque(string Nombre, int edad) : base(Nombre, edad)
        {
            _atack = 1.5;
        }
        public Ataque(double value1, double value2, string value3, int value4)
        {

        }

        public Ataque(string value1, string value2) : this("pedro", 24)
        {

        }

        public override bool IsWinner()
        {
            return true;
        }
    }
}
