namespace CrazyCarsII
{
    public class WoodCar : Car
    {
        public override void Execute()
        {
            Position += 50;
        }
        public override void Report()
        {
            Console.WriteLine("Herr Weisse de WoodCar:");
            int report = Utils.SelectReport();
            switch (report)
            {
                case 0:
                    Console.WriteLine("Me desplazo en mi sedán azul a 50 km/h.");
                    Console.WriteLine("");
                    break;
                case 1:
                    Console.WriteLine("Espero que el semáforo cambie a color verde.");
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("Respeto los pasos de peatones.");
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Debo detenerme completamente cuando llego al STOP.");
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("No invado los cruces de doble sentido.");
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine("Cedo el paso a una mujer agradable que circula en su cochecito rosa. Es una belleza.");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
