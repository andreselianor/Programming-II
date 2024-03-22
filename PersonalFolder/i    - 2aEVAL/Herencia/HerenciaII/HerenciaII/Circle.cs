namespace HerenciaII
{
    public class Circle : ShapeWithArea
    {
        private double _radius;
        private Point2D _center = new Point2D();
        private const double PI = Math.PI;


        public Circle()
        {
            _shapeType = ShapeType.CIRCLE;
        }


        public void SetCircle(Point2D center, double radius)
        {
            _center = center;
            _radius = radius;
        }

        public Point2D GetCircle()
        {
            return _center;
        }

        public double Radius => _radius;
        public Point2D Center => _center;

        public override double GetArea()
        {
            if (_radius <= 0)
                return 0;

            return PI * _radius * _radius;
        }
    }
}
