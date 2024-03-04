namespace ExamenBlueprint
{
    public class Segment : Shape
    {
        private Point2D pointA = new Point2D();
        private Point2D pointB = new Point2D();

        public override bool HasArea => false;
        public override double Area => 0.0;
        public override double Perimeter => Utils.GetDistance(pointA, pointB);
        public override void Draw(ICanvas canvas)
        {
            Point2D[] array = new Point2D[2];
            array[0] = pointA;
            array[1] = pointB;
            canvas.DrawPolygon(array);
        }
    }
}