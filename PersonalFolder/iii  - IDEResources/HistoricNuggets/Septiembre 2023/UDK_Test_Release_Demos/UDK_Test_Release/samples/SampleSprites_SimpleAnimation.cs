using UDK;

namespace UDK_Test
{
    public class SampleSprites_SimpleAnimation : IGameDelegate
    {
        enum ZeldaStates
        {
            STAY_FRONT, STAY_BACK, STAY_LEFT, STAY_RIGHT,
            MOVE_FRONT, MOVE_BACK, MOVE_LEFT, MOVE_RIGHT
        }

        ImageDatabase? database;
        SpriteSet? spriteSet;
        SpriteInstance? zelda;

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            if (zelda == null)
                return;

            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(rect2d_f64.FromMinMax(-4.0, -4.0, 4.0, 4.0));
            zelda?.Draw(canvas, 0.0, 0.0, 1.0, 1.0);
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();

            if (keyboard.IsKeyPressed(Keys.Space))
                zelda?.SetSequence((int)ZeldaStates.STAY_FRONT);
            if (keyboard.IsKeyPressed(Keys.Down))
                zelda?.SetSequence((int)ZeldaStates.MOVE_FRONT);
            if (keyboard.IsKeyPressed(Keys.Right))
                zelda?.SetSequence((int)ZeldaStates.MOVE_RIGHT);
            if (keyboard.IsKeyPressed(Keys.Left))
                zelda?.SetSequence(new SpriteSequenceSelector((int)ZeldaStates.MOVE_LEFT)
                {
                    EndId = (int)ZeldaStates.STAY_FRONT
                });
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            database = new ImageDatabase(gameEvent.canvasContext);
            spriteSet = SpriteLoaderUtils.LoadSpriteSetFromFile("resources/zelda/movement_set.json", database, typeof(ZeldaStates));
            zelda = new SpriteInstance(spriteSet, (int)ZeldaStates.STAY_FRONT, 0, -1);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            zelda?.Animate(gameEvent.animationEngine);
        }
    }
}
