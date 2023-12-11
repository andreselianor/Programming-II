namespace CrazyCarsII
{
    public class Car
    {
        private double _position;

        public double Position
        {
            get { return _position; }
            set {  _position = value; }
        }

        public virtual void Execute()
        {

        }

        public virtual void Report()
        {

        }

    }
}
