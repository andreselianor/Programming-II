namespace Ejercicio02
{
    public class Ecosystem
    {
        private string _name = "EcosPrimary";
        private double _adaptability;

        public double Adaptability => _adaptability;


        public Ecosystem()
        {

        }

        public Ecosystem(string name, int adaptability)
        {
            _name = name;
            _adaptability = adaptability;
        }

        public Ecosystem(double adaptability)
        {
            _adaptability = adaptability;
        }

        public Ecosystem(string name)
        {
            _name = name;
        }

        public virtual void Duel()
        {

        }
    }
}
