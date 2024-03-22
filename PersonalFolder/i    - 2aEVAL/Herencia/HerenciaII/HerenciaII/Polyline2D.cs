namespace HerenciaII
{
    public class Polyline2D : ShapeWithArea
    {
        private List<Point2D> _listPoints2D = new List<Point2D>();
        private bool _isClosed;


        public Polyline2D()
        {
            _shapeType = ShapeType.POLYLINE;
        }


        // Getters
        public List<Point2D> GetPolyline()
        {
            return _listPoints2D;
        }

        public int GetPolylinePointsCount()
        {
            return _listPoints2D.Count;
        }

        public Point2D? GetPointAt(int index)
        {
            if (index < 0 || index >= _listPoints2D.Count)
                return null;

            return _listPoints2D[index];
        }


        // Setters
        public void AddPointToPolyline(Point2D point)
        {
            if (point == null)
                return;

            _listPoints2D.Add(point);
        }

        public void SetPointAt(Point2D point2D, int index)
        {
            if (point2D == null || index < 0 || index >= _listPoints2D.Count)
                return;

            _listPoints2D[index] = point2D;
        }

        public void RemovePointAt(int index)
        {
            if (index < 0 || index >= _listPoints2D.Count)
                return;
            _listPoints2D.RemoveAt(index);
        }


        // Methods
        public void SetClosedPolylineAttribute()
        {
            Point2D initPoint = _listPoints2D[0];
            Point2D finalPoint = _listPoints2D[^1];

            if (initPoint.x == finalPoint.x &&
                initPoint.y == finalPoint.y)
                _isClosed = true;
        }

        public bool IsClosedPolyline()
        {
            return _isClosed;
        }


        public string GetPolylinePointsString()
        {
            string result = "";

            foreach (Point2D point in _listPoints2D)
            {
                result = point.x + " " + point.y;
            }

            return result;
        }

        public override bool HasArea()
        {
            return (_isClosed);
        }

        public override double GetArea()
        {
            if (IsClosedPolyline())
                return TriangulatePolyline();
            return 0;
        }

        public double TriangulatePolyline()
        {
            //TODO
            return -1;
        }
    }
}
