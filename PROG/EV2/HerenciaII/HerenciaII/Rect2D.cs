namespace HerenciaII
{
    public class Rect2D : ShapeWArea
    {
        private Point2D _min = new Point2D();
        private Point2D _max = new Point2D();

        public Point2D GetRect2D()
        {
            return _min;
        }

        public void SetRect2D(Point2D min, Point2D max)
        {
            _min = min;
            _max = max;
        }

        public Point2D Min => _min;
        public Point2D Max => _max;

    }
}
