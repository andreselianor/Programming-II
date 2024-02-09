namespace CrazyCarsIII
{
    public class PierreCar
    {
        private double _position;

        public double Position => _position;

        public void Simulate()
        {
            _position += 18;
        }
    }
}

