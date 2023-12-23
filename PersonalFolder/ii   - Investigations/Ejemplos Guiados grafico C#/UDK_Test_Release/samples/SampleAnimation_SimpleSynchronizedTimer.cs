using System;
using UDK;

namespace UDK_Test
{
    // Create a simple synchronized timer
    public class SampleAnimation_SimpleSynchronizedTimer : IGameDelegate
    {
        IAnimationObject? timer;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            if (timer != null && timer.Event.triggered)
            {
                Console.WriteLine("Trigger");
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
            timer = gameEvent.animationEngine.AddAnimation(new AnimationOptions()
            {
                Duration = double.PositiveInfinity,
                Interval = 2.0
            });
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}

