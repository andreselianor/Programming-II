using System;
using UDK;

namespace UDK_Test
{
	public class SampleCanvas_SimpleText : IGameDelegate
    {
        UDK.IFontFace? fontFace;
        string? posString;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            double x = 30.0;
            double y = 100.0;

            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(rect2d_f64.FromMinMax(0.0, 0.0, canvas.Width / 10.0, canvas.Height / 10.0), true);

            {
                canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
                canvas.Transform.SetTranslation(x, y);
                canvas.DrawText(new vec2d_f64(0, 0), "21VAVA VAVA", fontFace);
            }
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            fontFace = gameEvent.fontContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/ArialCE.ttf"))?.CreateFontFace(32.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/vl.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/arial2.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/vegan.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/streetwear.regular.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/sr.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/jasmine.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/toscana_script.regular.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/lily.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/TechnoRaceItalic.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/RetrographDemo.ttf"))?.CreateFontFace(64.0);

        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}

