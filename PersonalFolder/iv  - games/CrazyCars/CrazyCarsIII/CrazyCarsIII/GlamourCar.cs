namespace CrazyCarsIII
{
    public class GlamourCar
    {
        private double _position;

        public double Position => _position;

        public void Simulate()
        {
            _position += 20;
        }
    }
}
