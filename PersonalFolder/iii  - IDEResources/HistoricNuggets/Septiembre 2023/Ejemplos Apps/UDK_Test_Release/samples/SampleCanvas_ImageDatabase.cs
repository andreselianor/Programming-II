using UDK;

namespace UDK_Test
{
    public class SampleCanvas_ImageDatabase : IGameDelegate
    {
        ImageDatabase? database;
        double x = 0.0f;
        double y = 0.0f;

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(rect2d_f64.FromMinMax(-2.0, -2.0, 10.0, 2.0), true);

            var image = database.LoadImage("resources/map/world.png");
            canvas.FillShader.SetImage(image, new rect2d_f64(0.5, 0.5, 0.5, 0.5), new rgba_f64(1, 1, 1, 1));
            canvas.Transform.SetTranslation(x, y - 1.0f);
            canvas.Mask.PushCircle(new rect2d_f64(0.2, 0.2, 0.8, 0.8));
            canvas.DrawRectangle(new rect2d_f64(0, 0, 1, 1));
            canvas.Mask.Pop();
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {

        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            database = new ImageDatabase(gameEvent.canvasContext);
            database.LoadImage("resources/map/world.png");
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }
    }
}
