namespace CacheNode
{
    public class Cache
    {
        private List<string> _listCache = new List<string>();

        public void DisplayNodes()
        {
            foreach(string s in _listCache)
            {
                Console.WriteLine(s);
            }
        }

        public void SetCache(List<string> list)
        {
            _listCache = list;
        }
    }
}
