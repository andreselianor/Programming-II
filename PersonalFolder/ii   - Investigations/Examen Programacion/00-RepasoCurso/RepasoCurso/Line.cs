namespace RepasoCurso
{
    public class Line
    {
        public class Point2D
        {
            private double _x;
            private double _y;

            public double X
            {
                get { return _x; }
                set { _x = value;}
            }

            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }
        }

        private Point2D _pointA;
        private Point2D _pointB;

        public Line()
        {

        }

        public Line(Point2D pointA, Point2D pointB)
        {
            _pointA = pointA;
            _pointB = pointB;
        }

        public void MoveLeft(double distance)
        {
            _pointA.X += distance;
            _pointB.Y += distance;
        }
    }
}