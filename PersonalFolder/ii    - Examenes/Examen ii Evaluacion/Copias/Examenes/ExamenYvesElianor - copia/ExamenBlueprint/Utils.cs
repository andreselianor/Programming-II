namespace ExamenBlueprint
{
    public static class Utils
    {
        public static double GetDistance(Point2D a, Point2D b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static Rect2D GetBoundingBox(Point2D[] points)
        {
            // El punto mas cercano al origen
            Point2D minorPoint = new Point2D();
            minorPoint = points[0];
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X < minorPoint.X && points[i].Y < minorPoint.Y)
                {
                    minorPoint = points[i];
                }
            }

            // El punto mas alejado del origen
            Point2D majorPoint = new Point2D();
            majorPoint = points[0];
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X > minorPoint.X && points[i].Y > minorPoint.Y)
                {
                    majorPoint = points[i];
                }
            }

            Rect2D rectResult = new Rect2D(minorPoint,majorPoint);
            return rectResult;
        }
    }
}