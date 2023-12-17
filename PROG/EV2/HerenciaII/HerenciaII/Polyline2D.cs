namespace HerenciaII
{
    public class Polyline2D : ShapeWArea
    {
        private List<Point2D> _listPoints2D = new List<Point2D>();
        private bool _isClosed;

        // Getters
        public List<Point2D> GetPolyline()
        {
            return _listPoints2D;
        }

        public int GetPolylineCount()
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
        public void AddPolylinePoint(Point2D pointPolyline)
        {
            if (pointPolyline == null)
                return;

            _listPoints2D.Add(pointPolyline);
        }

        public void AddListPoints(List<Point2D> listPoints)
        {
            if (listPoints == null || listPoints.Count <= 0)
                return;

            _listPoints2D = listPoints;
        }

        public void SetPointAt(Point2D point2D, int index)
        {
            if (point2D == null || index < 0 || index >= _listPoints2D.Count)
                return;

            _listPoints2D[index] = point2D;
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


        public string GetPolylinePointsPrint()
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
