namespace ExamenYvesElianor
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point2D() { }
        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}