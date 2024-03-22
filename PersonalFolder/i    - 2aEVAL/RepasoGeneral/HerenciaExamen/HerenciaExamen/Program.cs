namespace HerenciaExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICountry country = new Country();
            Core.Launch(country);
        }
    }
}