namespace CrazyCarsIII
{
    public class TroglodyteCar
    {
        private double _position;

        public double Position => _position;

        public void Simulate()
        {
            _position += 10;
        }
    }
}
