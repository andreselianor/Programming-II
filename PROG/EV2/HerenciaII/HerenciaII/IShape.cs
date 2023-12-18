namespace HerenciaII
{
    public interface IShape
    {
        Point2D GetPosition();
        void SetPosition(Point2D point2D);
        ShapeType GetShapeType();
        string GetName();
        void SetName(string name);
        bool HasArea();
        double GetArea();
    }
}
