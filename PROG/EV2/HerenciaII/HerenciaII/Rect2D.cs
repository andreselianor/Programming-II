namespace HerenciaII
{
    public class Rect2D : ShapeWArea
    {
        private Point2D _min = new Point2D();
        private Point2D _max = new Point2D();

        public Rect2D()
        {

        }

        public Rect2D(Point2D min, Point2D max)
        {
            _min = min;
            _max = max;
        }


        public void SetRect2D(Point2D min, Point2D max)
        {
            _min = min;
            _max = max;
        }

        public Point2D GetRect2DMin()
        {
            return _min;
        }

        public Point2D GetRect2DMax()
        {
            return _max;
        }

        public Point2D Min => _min;
        public Point2D Max => _max;


        public double GetHeight()
        {
            double result = _min.y - _max.y;

            return result >= 0 ? result : -result;
        }

        public double GetWidth()
        {
            return Math.Abs((_min.x - _max.x));
        }
        public override double GetArea()
        {
            double width, height;
            width = GetWidth();
            height = GetHeight();

            return width * height;
        }
    }
}
