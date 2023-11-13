namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datetime datetime = new Datetime(1,3,5);

            Datetime datetime2;
            datetime2 = datetime.Clone();
            datetime2 = Datetime.Clone(datetime);

            Console.WriteLine(datetime.ToString());
        }
    }
}