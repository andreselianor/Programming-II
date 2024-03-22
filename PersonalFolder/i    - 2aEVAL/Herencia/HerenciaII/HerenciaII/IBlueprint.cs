namespace HerenciaII
{
    public interface IBlueprint
    {
        void AddShape(IShape shape);
        int GetShapeCount();
        IShape? GetShapeAt(int index);
        void RemoveAt(int index);
        double GetArea();
    }
}
