using ExamenBlueprint;

namespace Blueprint
{
    public class Circle : Shape
    {
        public override bool HasArea => throw new NotImplementedException();

        public override double Area => throw new NotImplementedException();

        public override double Perimeter => throw new NotImplementedException();

        public override Point2D Center => throw new NotImplementedException();

        public override Rect2D Rect => throw new NotImplementedException();

        public override void Draw(ICanvas canvas)
        {
            throw new NotImplementedException();
        }
    }
}
