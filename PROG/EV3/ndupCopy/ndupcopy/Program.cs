namespace ndupcopy
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            IUpCopy upCopy = new upCopy();
            Controller.Launch(upCopy, args);
        }
    }
    /* DOCUMENTACION DEL PROGRAMA*/
    // <see href="https://andreselianor.github.io/Documentation/">DOCUMENTACION ONLINE</see>
}