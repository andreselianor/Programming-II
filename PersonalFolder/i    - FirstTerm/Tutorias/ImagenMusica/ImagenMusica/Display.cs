using UDK;

namespace ImagenMusica
{
    public class Display : IGameDelegate
    {
        

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, 10, 10);
                        
            canvas.FillShader.SetColor(0, 0, 1, 1);
            canvas.DrawRectangle(0, 0, 1, 1);


            UDK.GenericImage image1 = new GenericImage();
            UDK.IImage image2;
            //UDK.ImageDatabase image2 = new ImageDatabase();
            string path = "../../../resources/espinete.png";
            //image1 = gameEvent.canvasContext.LoadImageFromFile(path);
            image2 = gameEvent.canvasContext.LoadImageFromFile(path);
            canvas.DrawImage(image2, 0, 0, 1, 1);
            //canvas.DrawImage(image1, 0, 0, 1, 1);
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            

            



            //UDK.Texture texture = new Texture();
            UDK.SoundPlayer music = new SoundPlayer();
            


        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
