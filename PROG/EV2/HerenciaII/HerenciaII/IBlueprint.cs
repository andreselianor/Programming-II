namespace HerenciaII
{
    public interface IBlueprint
    {
        void AddShape(IShape shape);
        int GetShapeCount();
        IShape? GetShape(int index);
        void RemoveAt(int index);
        double GetArea();
    }
}
