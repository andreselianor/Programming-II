namespace ExamenBlueprint
{
    public class Point : Shape
    {
        // Javi: Si pones esto private, ..., cómo puedo acceder?
        private Point2D _point = new Point2D();

        public override bool HasArea => false;
        public override double Area => 0.0;
        public override double Perimeter => 0.0;
        public override Point2D Center => _point;

        
        public override void Draw(ICanvas canvas)
        {
            Point2D[] arrayPoint = new Point2D[1];
            arrayPoint[0] = _point;
            canvas.DrawPolygon(arrayPoint);
        }
    }
}