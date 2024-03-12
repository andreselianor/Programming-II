namespace CacheNode
{
    public class Database : IDatabase
    {
        private List<List<string>> _nodeList = new List<List<string>>();
        private string _root = "Visitantes";
        private Cache _cachelist = new Cache();

        public void CreateDatabase()
        {
            _nodeList.Add(new List<string> { "Pedro", "Juan", "Ana" });
            _nodeList.Add(new List<string> { "Coche", "Casa", "Arbol" });
            _nodeList.Add(new List<string> { "Fontanero", "Surfista", "Molinero" });
        }
        public string GetRoot()
        {
            return _root;
        }
        public List<string> GetChildren()
        {
            return new List<string>() { "Nombres", "Pertenencias", "Oficios" };
        }

        public void CreateCache(int numberCache)
        {
            _cachelist.SetCache(_nodeList[numberCache]);
        }

        public void Display()
        {
            _cachelist.DisplayNodes();
        }
    }
}