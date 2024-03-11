namespace ExamenBlueprint
{
    public static class Utils
    {
        public static double GetDistance(Point2D a, Point2D b)
        {
            if (a == null || b == null)
                return 0.0;
            // Javi: Podrías optimizar los cálculos
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static Rect2D GetBoundingBox(Point2D[] points)
        {
            if (points == null)
                return null;

            // Javi: MUY BIEN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (!ArrayIsValid(points))
                return null;

            // El punto mas cercano al origen
            Point2D minorPoint = new Point2D(); // Javi: Esta linea no tiene sentido
            minorPoint = points[0];
            for (int i = 0; i < points.Length; i++)
            {
                // Javi: Mal
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

            Rect2D rectResult = new Rect2D(minorPoint, majorPoint);
            return rectResult;
        }

        public static double GetArea(Point2D[] points)
        {
            if (points == null)
                return 0.0;

            if (!ArrayIsValid(points))
                return 0.0;

            double areaPartial = 0.0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                areaPartial += CalculatePartialLength(points[i], points[i + 1]);
            }
            // Javi: Te falta un cálculo
            return 0.5 * areaPartial;
        }

        public static double GetPerimeter(Point2D[] points)
        {
            if (points == null)
                return 0.0;

            if (!ArrayIsValid(points))
                return 0.0;

            double result = 0.0;

            for (int i = 0; i < points.Length - 1; ++i)
            {
                result += GetDistance(points[i], points[i + 1]);
            }
            // Javi: No falta una distancia?
            return result;
        }

        // Funciones de uso personal.
        private static double CalculatePartialLength(Point2D p1, Point2D p2)
        {
            return (p1.Y + p2.Y) * (p1.X - p2.X);
        }

        private static bool ArrayIsValid(Point2D[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] == null)
                {
                    return false;
                }                
            }
            return true;                
        }
    }
}