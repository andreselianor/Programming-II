namespace ExamenBlueprint
{
    public class Segment : Shape
    {
        private Point2D pointA = new Point2D();
        private Point2D pointB = new Point2D();

        public override bool HasArea => false;
        public override double Area => 0.0;
        public override double Perimeter => Utils.GetDistance(pointA, pointB);
        public override Point2D Center => GetMidPoint();
        public override Rect2D Rect => GetBoundingBox();
        public override void Draw(ICanvas canvas)
        {
            Point2D[] array = new Point2D[2];
            array[0] = pointA;
            array[1] = pointB;
            canvas.DrawPolygon(array);
        }


        private Point2D GetMidPoint()
        {
            Point2D midPoint = new Point2D();
            midPoint.X = (pointA.X - pointB.X) * 0.5;
            midPoint.Y = (pointA.Y - pointB.Y) * 0.5;

            return midPoint;
        }
        private Rect2D GetBoundingBox()
        {
            // Javi: No es exáctamente así
            Rect2D bounding = new Rect2D(pointA,pointB);
            return bounding;
        }
    }
}