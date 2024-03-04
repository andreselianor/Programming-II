namespace ExamenBlueprint
{
    public delegate bool FilterDelegate(IShape shape);
    public class Blueprint : IBlueprint
    {
        List<IShape> _shapesList = new List<IShape>();

        public void AddShape(IShape shape)
        {
            _shapesList.Add(shape);
        }

        public void RemoveShapeWithName(string name)
        {
            if (name == null)
                return;

            for(int i = 0; i < _shapesList.Count; i++)
            {
                if (_shapesList[i].Name == name)
                    _shapesList.RemoveAt(i);
                i--;
            }
        }

        public IShape? GetShapeWithName(string name)
        {
            if (name == null)
                return null;

            for(int i = 0; i < _shapesList.Count;i++)
            {
                if(_shapesList[i].Name == name)
                    return _shapesList[i];
            }
            return null;
        }

        public List<IShape> GetShapes(FilterDelegate del)
        {
            List<IShape> filterList = new List<IShape>();
            for(int i = 0; i < _shapesList.Count;i++)
            {
                if (del(_shapesList[i]))
                {
                    filterList.Add(_shapesList[i]);
                }
            }
            return filterList;
        }

        public void Draw(ICanvas canvas)
        {

        }
    }
}
