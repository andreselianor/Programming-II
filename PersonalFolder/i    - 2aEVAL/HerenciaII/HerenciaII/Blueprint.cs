namespace HerenciaII
{
    public class Blueprint : IBlueprint
    {
        private List<IShape> _listShapes = new List<IShape>();

        public void AddShape(IShape shape)      //DUDA QUE ENLAZA CON PROGRAM
        {
            if (shape == null)
                return;

            _listShapes.Add(shape);
        }

        public IShape? GetShapeAt(int index)
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

        public double GetArea()
        {
            return this.GetArea();
        }
    }
}
