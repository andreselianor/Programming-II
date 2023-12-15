namespace HerenciaII
{
    internal class Segment2D : ShapeWOArea
    {
        private Point2D _from = new Point2D();
        private Point2D _to = new Point2D();

        public Point2D GetSegment()
        {
            return _from;
        }

        public void SetSegment(Point2D pointFrom, Point2D pointTo)
        {
            _from = pointFrom;
            _to = pointTo;
        }

        public Point2D From => _from;
        public Point2D To => _to;
    }
}
