using UDK;

namespace Grafico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGame game = new MyGame();
            UDK.Game.Launch(game);
        }
    }

    public class MyGame : UDK.IGameDelegate
    {
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(0.0, 0.0, 0.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, 10, 10);
            canvas.FillShader.SetColor(1.0, 0.0, 0.0, 1.0);
            canvas.DrawRectangle(1, 1, 2, 2);
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}