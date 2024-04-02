using System.Drawing;

namespace ExamenBlueprint
{
    public class Circle : Shape
    {
        private double _radius;
        private Point2D _center = new Point2D();
        private Rect2D _boundingBox = new Rect2D();
        

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public override bool HasArea => _radius > 0;
        public override double Area => Math.PI * _radius * _radius;
        public override double Perimeter => 2 * Math.PI * _radius;
        public override Point2D Center => _center;
        public override Rect2D Rect => _boundingBox;


        public override void Draw(ICanvas canvas)
        {
            SetBoundingBox();
            canvas.DrawCircle(_boundingBox);
        }

        public Circle() { }
        public Circle(Point2D center, double radius)
        {
            _center = center;
            _radius = radius;
        }

        private void SetBoundingBox()
        {
            Rect2D bounding = new Rect2D();

            bounding.MinX = _center.X - (_radius * 0.5);
            bounding.MinY = _center.Y - (_radius * 0.5);

            bounding.MaxX = _center.X + (_radius * 0.5);
            bounding.MaxY = _center.Y + (_radius * 0.5);

            _boundingBox =  bounding;
        }
    }
}