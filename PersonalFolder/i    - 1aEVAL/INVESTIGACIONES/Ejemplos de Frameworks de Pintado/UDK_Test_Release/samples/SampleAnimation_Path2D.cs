using System;
using UDK;

namespace UDK_Test
{
    public class SampleAnimation_Path2D : IGameDelegate
    {
        Path2DAnimation? pathAnimation;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            if (pathAnimation != null)
            {
                var p = pathAnimation.Position;
                Console.WriteLine(p.x + "-" + p.y);
                if (pathAnimation.Finished)
                {
                    pathAnimation.Dispose();
                    pathAnimation = null;
                }
            }
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            vec2d_f64[] poses = new vec2d_f64[]
            {
                new vec2d_f64(0, 0),
                new vec2d_f64(1, 1),
                new vec2d_f64(2, 0),
                new vec2d_f64(3, -1)
            };
            pathAnimation = new Path2DAnimation(gameEvent.animationEngine, poses, 0.1);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}

