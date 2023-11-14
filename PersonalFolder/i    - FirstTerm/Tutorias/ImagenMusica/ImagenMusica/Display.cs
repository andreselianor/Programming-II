using UDK;

namespace ImagenMusica
{
    public class Display : IGameDelegate
    {
        IImage image1, image2, image3;

        double opacity = 0;
        int frameRate = 0;

        // TESTING
        UDK.ISound? sound;
        UDK.IMusic? music;
        UDK.IFontFace? fontFace;
        UDK.IPlayer? player;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            frameRate++;

            if(frameRate > 10)
            {
                opacity += 0.1;
                frameRate = 0;
            }

        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, 10, 10);


            // RECTANGULO
            canvas.FillShader.SetColor(0.5, 0.5, 0.5, opacity);
            rect2d_f64 rect = new rect2d_f64(1, 1, 5, 5);
            canvas.DrawRectangle(rect);


            // IMAGENES
            string path1 = "../../../resources/espinete.png";
            string path2 = "../../../resources/kia.png";
            string path3 = "../../../resources/metallica.png";


            // QUE ES URI?
            image1 = gameEvent.canvasContext.LoadImageFromFile(path1);
            image2 = gameEvent.canvasContext.LoadImageFromFile(path2);
            image3 = gameEvent.canvasContext.LoadImageFromFile(path3);

            
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

            string path = "../../../resources/heygirl.ogg";
            // SOUND
            sound = gameEvent.audioContext.LoadSound(path);

            // MUSIC
            URI uripath = new URI();    // Assembly, path, bool
            music = gameEvent.audioContext.LoadMusic(uripath);
            music = gameEvent.audioContext.LoadMusic(path);

            // PLAYER
            player = gameEvent.audioThread.AcquirePlayer();
            player?.SetSound(music, true, false).Play();

            music.
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
        #endregion
    }
}
