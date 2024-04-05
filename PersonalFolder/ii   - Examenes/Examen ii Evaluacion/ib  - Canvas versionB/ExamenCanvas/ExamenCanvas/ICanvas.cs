namespace ExamenCanvas
{
    public interface ICanvas
    {
        public int Width { get; }
        public int Height { get; }

        public Color CurrentColor { get; }

        public void SetColor(Color color);
        public void DrawRectangle(Rect2D rectangle);
        public void DrawCircle(Rect2D rectangle);
        public void DrawPolygon(Point2D[] points);

    }
}