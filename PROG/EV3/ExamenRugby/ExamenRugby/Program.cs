namespace ExamenRugby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMatch match = new Match();
            Controller.Launch(match);
        }
    }
}