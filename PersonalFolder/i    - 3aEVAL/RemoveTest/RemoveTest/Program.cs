namespace RemoveTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Test t1 = CrearPrueba())
            {
                t1.SayHello();
            }
                
            //t1.Dispose();
        }


        public static Test CrearPrueba()
        {
            return new Test();
        }
    }

    public class Test : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

    }
}