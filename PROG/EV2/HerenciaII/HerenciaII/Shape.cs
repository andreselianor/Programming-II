namespace HerenciaII
{
    public enum ShapeType
    {
        SEGMENT,
        AREA
    }
    public abstract class Shape : IShape
    {
        protected Point2D position = new Point2D();
        private string _name = "";
        protected ShapeType _shapeType;

        public Point2D GetPosition()
        {
            return position;
        }

        public void SetPosition(Point2D point2D)
        {
            this.position = point2D;
        }



        public abstract double GetArea();
        public abstract bool HasArea();



        public ShapeType GetShapeType()
        {
            return _shapeType;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            if (name == null)
                return;

            _name = name;
        }

    }
}
