namespace HerenciaII

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(0, 0);
            Point2D point2 = new Point2D(4, 3);
            IShape prueba = new Rect2D(point1, point2);

            bool result = prueba.HasArea();
            double result2 = prueba.GetArea();
        }
    }
}