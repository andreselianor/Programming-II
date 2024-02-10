namespace RepasoCurso
{

    public class Line
    {
        //Debuggear privacidad
        private class Point2D
        {
            public double _x;
            public double _y;
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
            _pointA._x += distance;
            _pointB._y += distance;
        }
    }
}
