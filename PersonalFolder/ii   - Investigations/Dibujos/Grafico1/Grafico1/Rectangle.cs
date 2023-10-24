namespace Grafico1
{
    public class Rectangle
    {
        private double _x;
        private double _y;

        private double _width;
        private double _height;


        #region Constructores
        public Rectangle()
        {

        }
        public Rectangle(double PositionX, double PositionY, double widthValue, double heightValue)
        {
            _x = PositionX;
            _y = PositionY;
            _width = widthValue;
            _height = heightValue;
        }
        #endregion


        #region Properties
        public double X
        {
            get{ return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Width
        {
            get { return _width; }
        }

        public double Height
        {
            get { return _height; }
        }
        #endregion


        // METODOS
        public void SetWidth(double value)
        {
            _width = value;
        }

        public void SetHeight(double value)
        {
            _height = value;
        }

        public bool IntersectionRectangle(Rectangle rectangle)
        {
            if (this._x > rectangle._x && this._x < rectangle._x + rectangle._width &&
                this._y > rectangle._y && this._y < rectangle._y + rectangle._height) 
            {
                return true;
            }

            return false;                
        }

        public void DeleteActors(double velocity)
        {            
            SetWidth(velocity);            
        }
    }
}
