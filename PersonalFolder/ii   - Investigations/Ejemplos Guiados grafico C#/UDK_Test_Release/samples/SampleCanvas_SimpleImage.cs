using UDK;

namespace UDK_Test
{
    public class SampleCanvas_SimpleImage : IGameDelegate
    {
        UDK.IImage? image1;
        UDK.IImage? image2;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(rect2d_f64.FromMinMax(-2.0, -2.0, 10.0, 2.0), true);

            if (image1 != null)
            {
                canvas.FillShader.SetImage(image1, new rect2d_f64(0.5, 0.5, 0.5, 0.5), new rgba_f64(1, 1, 1, 1));
                canvas.Transform.SetTranslation(0.0, -1.0f);
                canvas.Mask.PushCircle(new rect2d_f64(0.2, 0.2, 0.8, 0.8));
                canvas.DrawRectangle(new rect2d_f64(0, 0, 1, 1));
                canvas.Mask.Pop();
            }
            if (image2 != null)
            {
                canvas.Transform.SetTranslation(0.0, 0.0);
                canvas.DrawImage(image2, new rect2d_f64(0, 0, 1, 1));
            }

        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            image2 = gameEvent.canvasContext.LoadImageFromFile("resources/david.png");
            image1 = gameEvent.canvasContext.LoadImageFromFile("resources/dices.png");
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}

