namespace HerenciaII
{
    internal class Segment2D : ShapeWithoutArea
    {
        private Point2D _from = new Point2D();
        private Point2D _to = new Point2D();


        public Segment2D()
        {
            _shapeType = ShapeType.SEGMENT;
        }


        public void SetSegment(Point2D pointFrom, Point2D pointTo)
        {
            _from = pointFrom;
            _to = pointTo;
        }


        // Dos maneras de acceder a los atributos
        // Getters
        public Point2D GetSegmentFrom()
        {
            return _from;
        }

        public Point2D GetSegmentTo()
        {
            return _to;
        }

        // Properties
        public Point2D From => _from;
        public Point2D To => _to;
    }
}
