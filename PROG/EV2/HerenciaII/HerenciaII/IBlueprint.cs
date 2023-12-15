namespace HerenciaII
{
    public interface IBlueprint
    {
        void AddShape(Shape shape);
        int GetShapeCount();
        IShape GetShape(int index);
        void RemoveAt(int index);
        double GetArea();
    }
}
