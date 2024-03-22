namespace RepasoCurso
{
    public class Square
    {
        private double _x;
        private double _y;
        private double _width;
        private double _height;

        public Square()
        {

        }

        public Square(double x, double y, double width, double height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        public double GetDiagonal()
        {
            return Math.Sqrt(_width * _width + _height * _height);
        }

        public double GetArea()
        {
            return _width * _height;
        }

        public double GetPerimeter()
        {
            return _width * 2 + _height * 2;
        }

        public bool IntersectWithSquare(Square square)
        {
            if (square == null)
                return false;

            if(_x + _width > square._x && _x < square._x + square._width)
            {
                return true;
            }
            if (_y + _height > square._y && _y < square._y + square._height)
            {
                return true;
            }
            return false;
        }
    }
}
