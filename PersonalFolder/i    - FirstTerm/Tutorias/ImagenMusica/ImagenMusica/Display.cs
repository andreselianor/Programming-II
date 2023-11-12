using UDK;

namespace ImagenMusica
{
    public class Display : IGameDelegate
    {
        IImage image1, image2, image3;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, 10, 10);
            
            string path1 = "../../../resources/espinete.png";
            string path2 = "../../../resources/kia.png";
            string path3 = "../../../resources/metallica.png";

            image1 = gameEvent.canvasContext.LoadImageFromFile(path1);
            image2 = gameEvent.canvasContext.LoadImageFromFile(path2);
            image3 = gameEvent.canvasContext.LoadImageFromFile(path3);

            //rect2d_f32
            // cambiar opacidad para realizar fundidos
            canvas.DrawImage(image1, 0, 7, 3, 3);
            canvas.DrawImage(image2, 5, 5, 3, 3);
            canvas.DrawImage(image3, 7, 0, 3, 3);
        }

        #region OnLoad / OnKeyboard
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {            
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
        #endregion
    }
}
