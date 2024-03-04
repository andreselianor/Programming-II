namespace ExamenBlueprint
{
    public class Rectangle : Shape
    {
        Rect2D rectangle = new Rect2D();

        public override bool HasArea => rectangle.Area > 0;
        public override double Area => rectangle.Area;
        public override double Perimeter => (rectangle.MinX - rectangle.MaxX) * 2 + (rectangle.MinY - rectangle.MaxY) * 2;
        public override Point2D Center => rectangle.GetCenterPoint();

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRectangle(rectangle);
        }

        public Point2D GetPointAtIndex(int index)
        {
            if (index < 0 || index > 3)
                return null;

            Point2D pointResult = new Point2D();

            switch (index)
            {
                case 0:
                    pointResult.X = rectangle.MinX;
                    pointResult.Y = rectangle.MinY;
                    break;
                case 1:
                    pointResult.X = rectangle.MaxX;
                    pointResult.Y = rectangle.MinY;
                    break;
                case 2:
                    pointResult.X = rectangle.MinX;
                    pointResult.Y = rectangle.MinY;
                    break;
                case 3:
                    pointResult.X = rectangle.MaxX;
                    pointResult.Y = rectangle.MaxY;
                    break;
            }
            return pointResult;
        }
    }
}