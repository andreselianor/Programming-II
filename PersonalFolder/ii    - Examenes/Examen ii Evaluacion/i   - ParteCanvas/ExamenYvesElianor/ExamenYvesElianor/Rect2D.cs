namespace ExamenYvesElianor
{
    public class Rect2D
    {
        private double _leftX;
        private double _leftY;

        private double _rightX;
        private double _rightY;

        public double LeftX => _leftX;
        public double LeftY => _leftY;
        public double RightX => _rightX;
        public double RightY => _rightY;

        public Rect2D() { }
        public Rect2D(double leftX, double leftY, double rightX, double rightY)
        {
            _leftX = leftX;
            _leftY = leftY;

            _rightX = rightX;
            _rightY = rightY;
        }
    }
}