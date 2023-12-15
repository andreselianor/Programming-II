namespace HerenciaII
{
    public class Polyline2D : ShapeWArea
    {
        private List<Point2D> _point2Ds = new List<Point2D>();

        public List<Point2D> GetPolyline()
        {
            return _point2Ds;
        }

        public void AddPolyline(List<Point2D> listPoints)
        {
            if (listPoints == null || listPoints.Count <= 0)
                return;

            _point2Ds = listPoints;
        }

        public int GetPolylineCount()
        {
            return _point2Ds.Count;
        }

        public Point2D GetPointAt(int index)
        {
            if (index < 0 || index >= _point2Ds.Count)
                return null;

            return _point2Ds[index];
        }

        public void SetPointAt(Point2D point2D, int index)
        {
            if (point2D == null || index < 0 || index >= _point2Ds.Count)
                return;

            _point2Ds[index] = point2D;
        }
    }
}
