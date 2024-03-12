namespace CacheNode
{
    public interface IDatabase
    {
        void CreateDatabase();
        string GetRoot();
        List<string> GetChildren();
        void CreateCache(int numberCache);
        void Display();
    }
}