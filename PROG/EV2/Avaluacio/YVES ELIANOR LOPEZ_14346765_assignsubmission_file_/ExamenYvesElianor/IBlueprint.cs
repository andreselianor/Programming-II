namespace ExamenBlueprint
{
    public interface IBlueprint
    {        
        void AddShape(IShape shape);
        void RemoveShapeWithName(string name);
        IShape GetShapeWithName(string name);
        List<IShape> GetShapes(FilterDelegate del);
        void Draw(ICanvas canvas);
    }
}