namespace Genericos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenGenericos<string> almacen1 = new AlmacenGenericos<string>(4);

            almacen1.AddElement("Pepi");
            almacen1.AddElement("Jordi");
            almacen1.AddElement("Minerva");
            almacen1.AddElement("Hipatia");

            string nombre = almacen1.GetElement(2);
            Console.WriteLine(nombre);

            AlmacenGenericos<double> almacen2 = new AlmacenGenericos<double>(4);

            almacen2.AddElement(0.5);
            almacen2.AddElement(1.8);
            almacen2.AddElement(22.4);
            almacen2.AddElement(33.7);

            double numero = almacen2.GetElement(2);
            Console.WriteLine(nombre);
        }
    }
}