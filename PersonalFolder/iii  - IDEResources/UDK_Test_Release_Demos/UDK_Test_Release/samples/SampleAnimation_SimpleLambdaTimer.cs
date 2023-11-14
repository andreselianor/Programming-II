using System;
using UDK;

namespace UDK_Test
{
    // Create a simple timer using a delegate
    public class SampleAnimation_SimpleLambdaTimer : IGameDelegate
    {
        IAnimationObject? timer;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {
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
            timer.Delegate = (obj) =>
            {
                Console.WriteLine("Trigger");
            };
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}

