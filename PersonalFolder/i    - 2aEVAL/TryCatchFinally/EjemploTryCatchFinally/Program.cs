namespace EjemploTryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();
            function.ExecuteFunction();
            function.ExecuteFunctionThrowException();
        }
    }
}