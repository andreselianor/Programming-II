using System.Drawing;

namespace ExamenYvesElianor
{
    public enum ShapeType
    {
        RECTANGULO,
        CIRCULO,
        POLIGONO,
        DEFAULT
    }

    public class CanvasConsole : ICanvas
    {
        // Javi: no lo usas ...
        private Point2D _point = new Point2D();

        private Rect2D _rectangle = new Rect2D();
        private Color _color = new Color();

        // Javi: Esto no lo entiendo
        private ShapeType _shapeType;

        public int Width
        {
            get
            {
                return ((int)_rectangle.RightX - (int)_rectangle.LeftX);
            }
        }

        public int Height
        {
            get
            {
                return ((int)_rectangle.RightY - (int)_rectangle.LeftY);
            }
        }

        public Color CurrentColor => _color;


        public CanvasConsole() { }
        public CanvasConsole(Point2D point)
        {
            _point = point;
        }
        public CanvasConsole(Rect2D rectangle)
        {
            _rectangle = rectangle;
        }

        // Javi: Y cuando llamas a esta función
        public void PrintShape()
        {
            Console.Write($"Pintando una figura de tipo {_shapeType}, ");
            Console.Write($"con el color ({_color.R}, {_color.G}, {_color.B}), ");
            Console.Write($"en el rectangulo({_rectangle.LeftX},{_rectangle.LeftY},{_rectangle.RightX},{_rectangle.RightY})"); 
        }

        // Javi: Estas funciones no son lo que se pide, ...
        public void DrawRectangle(Rect2D rectangle)
        {
            if (rectangle == null)
                return;
            _rectangle = rectangle;
        }
        public void DrawCircle(Rect2D rectangle)
        {
            if (rectangle == null)
                return;
            _rectangle = rectangle;
        }
        public void DrawPolygon(Point2D[] points)
        {
            if (points == null)
                return;
            Point2D[] pointsArray = points;
        }
        public void SetColor(Color color)
        {
            if (color == null)
                return;
            _color = color;
        }
    }
}