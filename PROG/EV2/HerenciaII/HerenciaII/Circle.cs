namespace HerenciaII
{
    public class Circle
    {
        private double _radius;
        private Point2D _center = new Point2D();

        public Point2D GetCircle()
        {
            return _center;
        }

        public void SetCircle(Point2D center, double radius)
        {
            _center = center;
            _radius = radius;
        }

        public double Radius => _radius;
        public Point2D Center => _center;   
    }
}
