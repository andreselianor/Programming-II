namespace HerenciaII

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D point1 = new Point2D(0, 0);
            Point2D point2 = new Point2D(4, 3);
            Point2D point3 = new Point2D(0, 0);

            IShape shape1 = new Polyline2D();
            shape1.SetName("forma1");
            shape1.SetPosition(point1);

            //(Polyline2D)shape1.AddPosition(point1);     // NO COMPILA
            // NO PUEDO MANEJAR POLYLINE DE TIPO ISHAPE



            Polyline2D shape2 = new Polyline2D();            
            shape2.AddPointToPolyline(point1);
            shape2.AddPointToPolyline(point2);
            shape2.AddPointToPolyline(point3);
            shape2.SetPosition(point1);
            shape2.GetPolylinePointsCount();
            shape2.GetPointAt(2);
            shape2.GetPolylinePointsString();
            shape2.SetClosedPolylineAttribute();
            shape2.HasArea();


            Blueprint blueprint = new Blueprint();
            blueprint.AddShape(shape2);                     // DUDA QUE ENLAZA CON BLUEPRINT
            blueprint.GetShapeAt(0);

            Segment2D segmento1 = new Segment2D();
            segmento1.GetArea();
        }
    }
}