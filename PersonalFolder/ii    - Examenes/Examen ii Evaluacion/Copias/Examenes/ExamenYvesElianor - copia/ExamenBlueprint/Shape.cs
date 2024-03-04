namespace ExamenBlueprint
{
    public class Shape : IShape
    {
        protected string _name;
        private Color _color;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public virtual bool HasArea => true;
        public virtual double Area => 0.0;
        public virtual double Perimeter => 0.0;
        public virtual Point2D Center => new Point2D();
        public virtual Rect2D Rect => new Rect2D();
        public virtual void Draw(ICanvas canvas)
        {
            canvas.SetColor(_color);
        }

        public Shape() { }

        public Shape(string name, Color color)
        {
            _name = name;
            _color = color;
        }
    }
}
