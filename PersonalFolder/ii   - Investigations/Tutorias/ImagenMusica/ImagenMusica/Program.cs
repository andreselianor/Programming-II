namespace ImagenMusica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            UDK.Game.Launch(display);
        }
    }
}