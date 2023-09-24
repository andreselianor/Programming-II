namespace Dolphin01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Echo the Dolphin");

            // Creamos un objeto Dolphin
            Dolphin d1;
            d1 = new Dolphin();

            // Damos Atributos al Objeto d1
            d1.size = 10;
            d1.size = 18 * 4;
            d1.life = 100;
            d1.name = "Lilitetera";
            d1.Color = ColorType.WHITE;

            // Creamos un objeto Dolphin d2
            Dolphin d2;
            d2 = new Dolphin();

            // Damos Atributos al Objeto d2
            d2.size = 18;
            d2.life = 350 / 1.9;
            d2.name = "Cacerolo";
            d2.Color = ColorType.WHITE;
        }
    }
}