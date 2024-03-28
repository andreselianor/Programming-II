using System;
using UDK;
using static UDK.ICanvasShader;

namespace UDK_Test
{
    public class CustomShader : ICanvasShader
    {
        public class Values
        {
            public ICanvasShader.IUniform? time;
            public ICanvasShader.ITexture? texture;
            public ICanvasShader.IInterpolator? interpolator;
        }

        public float time;

        public long GetKey()
        {
            return 2;
        }

        public void GenerateShader(long key, ICanvasShader.IBuilder builder)
        {
            var values = new Values()
            {
                texture = builder.CreateTexture("sImage"),
                interpolator = builder.CreateInterpolator("fragCoord"),
                time = builder.CreateUniform("iTime", SampleFormat.Float1),
            };
            builder.Values = values;
            builder.Shader = File.ReadAllText("resources/shader.glsl");
        }

        public void Present(IShaderContext context, long key, object values)
        {
            var v = (Values)values;
            //v.texture?.SetTexture(image);
            v.interpolator?.SetRange(context, -1f, -1f, 1f, 1f);
            v.time?.SetValue(context, time);
            context.HasBlending = true;
        }
    }

    public class SampleCanvas_FullSample : IGameDelegate
    {
        double x = 0.0f;
        double y = 0.0f;
        double time = 0.0;
        UDK.IImage? image1;
        UDK.IImage? image2;
        UDK.ISound? sound;
        UDK.IMusic? music;
        UDK.IFontFace? fontFace;
        UDK.IPlayer? player;
        string? posString;
        CustomShader shader = new CustomShader();
        int starSides = 3;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(rect2d_f64.FromMinMax(-2.0, -2.0, 10.0, 2.0), true);

            canvas.FillShader.SetColor(new rgba_f64(0.0, 0.0, 1.0, 1.0));
            canvas.Transform.SetIdentity();
            canvas.DrawRectangle(new rect2d_f64(-2.0, -2.0, 12.0, 4.0));

            canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
            canvas.Transform.SetTranslation(x, y + 1.0f);
            canvas.Mask.PushRoundedRect(new rect2d_f64(0.0, 0.0, 1.0, 1.0), 0.2, 0.3, 0.4, 0.5);
            canvas.DrawRectangle(new rect2d_f64(0.0, 0.0, 1.0, 1.0));
            canvas.Mask.Pop();

            canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
            canvas.Transform.SetTranslation(x + 1.0f, y + 1.0f);
            canvas.Mask.PushRoundedRect(new rect2d_f64(0.0, 0.0, 1.0, 1.0), RectMode.Default, new ShapeMode() { LineWidth = 0.02 }, 0.2, 0.3, 0.4, 0.5);
            canvas.DrawRectangle(new rect2d_f64(0.0, 0.0, 1.0, 1.0));
            canvas.Mask.Pop();

            {
                canvas.Transform.SetTranslation(x + 2.0f, y);
                canvas.FillShader.SetRadialGradient(new rect2d_f64(0.0, 0.0, 1.0, 1.0), new RectMode(), new rgba_f64(1.0, 0.0, 0.0, 1.0), new rgba_f64(0.0, 1.0, 0.0, 1.0));
                canvas.DrawRectangle(new rect2d_f64(0.0, 0.0, 1.0, 1.0));
            }
            {
                canvas.Transform.SetTranslation(x + 2.0f, y - 1);
                canvas.FillShader.SetRadialGradient(new rect2d_f64(0.0, 0.0, 1.0, 1.0), new RectMode(), new rgba_f64(1.0, 0.0, 0.0, 1.0), new rgba_f64(0.0, 1.0, 0.0, 1.0));
                canvas.Mask.PushRectangle(new rect2d_f64(0.5 + Math.Cos(time) * 0.2, 0.25, 1.0, 0.5));
                canvas.DrawRectangle(new rect2d_f64(0.0, 0.0, 1.0, 1.0));
                canvas.Mask.Pop();
            }

            canvas.Transform.SetTranslation(x + 4.0f, y + 2.0f);
            canvas.FillShader.SetRadialGradient(new rect2d_f64(0.0, 0.0, 1.0, 1.0), new RectMode(), new rgba_f64(1.0, 0.0, 0.0, 1.0), new rgba_f64(0.0, 1.0, 0.0, 1.0));
            canvas.Mask.PushCircle(new rect2d_f64(0.0, 0.0, 1.0, 1.0));
            canvas.DrawRectangle(new rect2d_f64(0.0, 0.0, 1.0, 1.0));
            canvas.Mask.Pop();

            canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 0.0, 1.0));
            canvas.Transform.SetIdentity();
            canvas.Transform.Rotate(1);
            canvas.Transform.Translate(x, y);
            canvas.Mask.PushCircle(new rect2d_f64(0.2, 0.2, 1.0, 1.0));
            canvas.DrawRectangle(new rect2d_f64(0.2, 0.2, 1.0, 1.0));
            canvas.Mask.Pop();

            if (posString != null)
            {
                using (var line = canvas.AcquirePath())
                {
                    line.MoveTo(new vec2d_f64(0.0, 0.0));
                    line.LineTo(new vec2d_f64(10.0, 0.0));

                    canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
                    canvas.Transform.SetTranslation(x + 3.0, y);
                    canvas.StrokeOnePixelLine(line);
                }

                canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
                canvas.Transform.SetTranslation(x + 3.0, y);
                //canvas.DrawText(new vec2d_f64(0, 0), "VAVA", fontFace, new TextMode() { height = 0.3, bottomCoords = false });
                //canvas.DrawText(new vec2d_f64(0, 0), "Ab cde fghi", font, new TextMode() { height = 0.3, bottomCoords = false });
                canvas.DrawText(new vec2d_f64(0, 0), "21VAVA1211 " + posString, fontFace, new TextMode() { height = 0.5, bottomCoords = false });
                //canvas.DrawText(new vec2d_f64(0, 0), "2", fontFace, new TextMode() { height = 0.5, bottomCoords = false });
                //canvas.DrawText(new vec2d_f64(0, 0), "qwertyuiopñlkjhgfdsazxcvbnmQWERTYUIOPÑLKJHGFDSAZXCVBNM,.;", fontFace, new TextMode() { height = 0.5, bottomCoords = false });
            }

            if (image1 != null)
            {
                canvas.FillShader.SetImage(image1, new rect2d_f64(0.5, 0.5, 0.5, 0.5), new rgba_f64(1, 1, 1, 1));
                canvas.Transform.SetTranslation(x, y - 1.0f);
                canvas.Mask.PushCircle(new rect2d_f64(0.2, 0.2, 0.8, 0.8));
                canvas.DrawRectangle(new rect2d_f64(0, 0, 1, 1));
                canvas.Mask.Pop();
            }
            if (image2 != null)
            {
                canvas.Transform.SetTranslation(x, y);
                canvas.DrawImage(image2, new rect2d_f64(0, 0, 1, 1));
            }

            shader.time = (float)gameEvent.animationEngine.Time.Time;
            canvas.FillShader.SetUserShader(1, 0, shader.GetKey(), shader);
            canvas.Transform.SetTranslation(x, y - 2.0f);
            canvas.DrawRectangle(new rect2d_f64(0, 0, 1, 1));


            canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
            canvas.Transform.SetTranslation(x + 1.0f, y - 2.0f);
            canvas.Mask.PushRoundedRect(new rect2d_f64(0.0, 0.0, 1.0, 1.0), 0.3, 0.3, 0.3, 0.3);
            canvas.DrawRectangle(new rect2d_f64(0, 0, 1, 1));
            canvas.Mask.Pop();

            canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
            canvas.Transform.SetTranslation(x + 3.0f, y - 3.0f);
            canvas.Mask.PushStar(new rect2d_f64(0.0, 0.0, 1.0, 1.0), starSides, 0.5);
            canvas.DrawRectangle(new rect2d_f64(0, 0, 1, 1));
            canvas.Mask.Pop();

            using (var line = canvas.AcquirePath())
            {
                line.MoveTo(new vec2d_f64(0.0, 0.0));
                line.LineTo(new vec2d_f64(1.0, 0.0));
                line.LineTo(new vec2d_f64(1.0, 1.0));
                line.LineTo(new vec2d_f64(0.0, 1.0));
                line.Close();

                canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
                canvas.Transform.SetTranslation(x + 2, y + 2);
                canvas.StrokeOnePixelLine(line);
            }

            using (var line = canvas.AcquirePath())
            {
                line.MoveTo(new vec2d_f64(0.0, 0.0));
                line.LineTo(new vec2d_f64(0.0, 1.0));
                line.MoveTo(new vec2d_f64(1.0, 0.0));
                line.LineTo(new vec2d_f64(1.0, 1.0));

                canvas.FillShader.SetColor(new rgba_f64(1.0, 1.0, 1.0, 1.0));
                canvas.Transform.SetTranslation(x + 3.1f, y + 2);
                canvas.StrokeOnePixelLine(line);
            }
            time += 0.01;
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            var pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
            posString = "Hg (" + mouse.X + "," + mouse.Y + ") - (" + pos.x + "," + pos.y + ")";

            if (keyboard.IsKeyPressed(Keys.S))
                player?.Play(sound);

            if (keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();
            if (keyboard.IsKeyDown(Keys.Right))
                x += 0.01f;
            if (keyboard.IsKeyDown(Keys.Left))
                x -= 0.01f;
            if (keyboard.IsKeyDown(Keys.Up))
                y += 0.01f;
            if (keyboard.IsKeyDown(Keys.Down))
                y -= 0.01f;
            if (keyboard.IsKeyDown(Keys.F))
                gameEvent.window.ToggleFullscreen();

            if (keyboard.IsKeyPressed(Keys.R))
                starSides++;

            if (keyboard.IsKeyPressed(Keys.M))
            {
                var st = x;
                gameEvent.animationEngine.Add(new AnimationOptions()
                    {
                        Duration = 5.0
                    },
                    (in AnimationEvent ae, ref AnimationAction action) =>
                    {
                        if (ae.iteration % 2 == 0)
                            x = st + (float)ae.u;
                        else
                            x = st - (float)ae.u;
                        if (action == AnimationAction.PAUSE)
                        {
                            if (ae.pausedU >= 0.5)
                                action = AnimationAction.RESUME;
                        }
                        if (ae.pausedCount == 0 && ae.u >= 0.5)
                            action = AnimationAction.PAUSE;
                        if (ae.iteration < 1 && action == AnimationAction.CANCEL)
                            action = AnimationAction.RESTART;
                    });
            }

            if (keyboard.IsKeyPressed(Keys.P) && player != null)
                player.SetPaused(!player.IsAllPaused);
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            image2 = gameEvent.canvasContext.LoadImageFromFile("resources/david.png");
            image1 = gameEvent.canvasContext.LoadImageFromFile("resources/dices.png");

            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/vl.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/RetrographDemo.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/sr.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/arial2.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/jasmine.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/vegan.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/streetwear.regular.otf"))?.CreateFontFace(64.0);

            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/toscana_script.regular.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/lily.ttf"))?.CreateFontFace(64.0);
            fontFace = gameEvent.fontContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/ArialCE.ttf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/TechnoRaceItalic.otf"))?.CreateFontFace(64.0);
            //fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/fonts/RetrographDemo.ttf"))?.CreateFontFace(64.0);


            sound = gameEvent.audioContext.LoadSoundFromFile("resources/mixkit.wav");
            music = gameEvent.audioContext.LoadMusicFromFile("resources/sample.ogg");

            player = gameEvent.audioThread.AcquirePlayer();
            player?.Play(music);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}

