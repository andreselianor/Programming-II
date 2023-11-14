using UDK;

namespace UDK_Test
{
    /// <summary>
    /// Press the A key
    /// </summary>
    public class SampleSprites_SimpleFollowPath : IGameDelegate
    {
        enum ZeldaStates
        {
            STAY_FRONT, STAY_BACK, STAY_LEFT, STAY_RIGHT,
            MOVE_FRONT, MOVE_BACK, MOVE_LEFT, MOVE_RIGHT
        }

        ImageDatabase? database;
        SpriteSet? spriteSet;
        SpriteInstance? zelda;
        vec2d_f64 zeldaPosition;

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            if (zelda == null)
                return;

            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(rect2d_f64.FromMinMax(-4.0, -4.0, 4.0, 4.0));
            zelda?.Draw(canvas, zeldaPosition.x, zeldaPosition.y, 1.0, 1.0);
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();

            if (keyboard.IsKeyPressed(Keys.A) && !gameEvent.animationEngine.IsTargetAnimated(zelda))
            {
                vec2d_f64[] poses = new vec2d_f64[]
                {
                    new vec2d_f64(0, 0),
                    new vec2d_f64(1, 0),
                    new vec2d_f64(1, 1),
                    new vec2d_f64(0, 1),
                    new vec2d_f64(0, 0)
                };

                gameEvent.animationEngine.Add(new AnimationOptions()
                    {
                        Duration = 5.0,
                        Factor = Path2DAnimation.GetLength(poses),
                        Target = zelda
                    },
                    (in AnimationEvent ae, ref AnimationAction action) =>
                    {
                        var d = ae.u * ae.factor;
                        var p = Path2DAnimation.GetPosition(poses, d);
                        Console.WriteLine(p.x + "-" + p.y);
                        var delta = p - zeldaPosition;
                        // You can use delta to select the animation sequence
                        zeldaPosition = p;
                        if (action == AnimationAction.CANCEL)
                            zelda?.SetSequence((int)ZeldaStates.STAY_FRONT);
                        else
                            zelda?.SetSequence((int)ZeldaStates.MOVE_FRONT);
                    });
            }
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
