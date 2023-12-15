namespace HerenciaII
{
    public class Blueprint : IBlueprint
    {
        private List<IShape> _listShapes = new List<IShape>();

        public void AddShape(Shape shape)
        {
            if (shape == null)
                return;

            _listShapes.Add(shape);
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public IShape? GetShape(int index)
        {
            if (index < 0 || index >= _listShapes.Count)
                return null;

            return _listShapes[index];
        }

        public int GetShapeCount()
        {
            return _listShapes.Count;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _listShapes.Count)
                return;
            _listShapes.RemoveAt(index);
        }
    }
}
