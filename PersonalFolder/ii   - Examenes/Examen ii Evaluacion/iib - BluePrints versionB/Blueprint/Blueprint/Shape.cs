using ExamenBlueprint;

namespace Blueprint
{
    public abstract class Shape : IShape
    {
        protected string _name;
        private ColorCanvas _color;

        public Shape() { }
        public Shape(string name, ColorCanvas color)
        {
            _name = name;
            _color = color;
        }

        public string Name { get; }
        public ColorCanvas Color { get; }

        public abstract bool HasArea { get; }
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public abstract Point2D Center { get; }
        public abstract Rect2D Rect { get; }

        public abstract void Draw(ICanvas canvas);
    }
}