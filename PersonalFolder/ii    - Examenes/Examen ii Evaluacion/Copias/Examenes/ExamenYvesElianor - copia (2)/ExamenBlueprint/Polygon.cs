namespace ExamenBlueprint
{
    public class Polygon : Shape
    {
        private Point2D[] _points;
        private bool _isClosed;

        public int PointCount => _points.Length;

        public void Clear()
        {
            _points = new Point2D[0];
        }

        public void Close()
        {
            _isClosed = true;
        }

        public void AddPoint(Point2D point)
        {
            if (point == null)
                return;

            int count = _points.Length;
            Point2D[] result = new Point2D[count + 1];

            for (int i = 0; i < count; i++)
            {
                result[i] = _points[i];

            }
            result[count] = point;
            _points = result;
        }

        public Point2D GetPointAt(int index)
        {
            return _points[index];
        }
        public override void Draw(ICanvas canvas)
        {
        }
    }
}
