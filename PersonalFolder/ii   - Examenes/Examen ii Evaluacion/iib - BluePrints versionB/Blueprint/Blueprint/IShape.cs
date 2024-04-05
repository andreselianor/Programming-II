using ExamenBlueprint;
using System.Drawing;

namespace Blueprint
{
    public interface IShape
    {
        string Name { get; }
        ColorCanvas Color { get; }
        bool HasArea{ get; }
        double Area { get; }
        double Perimeter { get; }
        Point2D Center { get; }
        Rect2D Rect { get; }

        void Draw(ICanvas canvas);
    }
}
