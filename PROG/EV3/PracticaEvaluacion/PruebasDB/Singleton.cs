namespace PruebasDB
{
    public class Singleton
    {
        public IDatabase _database = new Database();

        private static Singleton _singleton = new Singleton();

        public static Singleton SingletonGet => _singleton;

        private Singleton() { }
    }
}