namespace CacheNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabase db = new Database();
            Controller.Launch(db);
        }
    }
}
