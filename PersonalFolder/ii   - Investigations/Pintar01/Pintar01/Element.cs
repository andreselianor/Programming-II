using UDK;

namespace Pintar01
{
    public class Element
    {
        public rect2d_f64 rectangle;
        public RectMode mode1;
        public ShapeMode shape1;


        public Element(double posX, double posY, double width)
        {
            rectangle = new rect2d_f64(posX, posY, width, width);
            mode1 = new RectMode();
            shape1 = new ShapeMode();
        }
        public void DrawElements(ICanvas canvas, double r, double g, double b)
        {
            canvas.FillShader.SetColor(r, g, b, 1);
            canvas.Mask.PushCircle(rectangle, mode1, shape1);
            canvas.DrawRectangle(rectangle);
            canvas.Mask.Pop();
        }
        /*
        public void DrawElementsShade(ICanvas canvas, double r, double g, double b)
        {
            canvas.FillShader.SetColor(r, g, b, 1);
            canvas.Mask.PushCircle(rectangle, mode1, shape1);
            canvas.DrawRectangle(rectangle);
            canvas.Mask.Pop();
        }
        */
    }
}
