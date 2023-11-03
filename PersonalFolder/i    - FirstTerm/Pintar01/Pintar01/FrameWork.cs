using UDK;

namespace Pintar01
{
    public class FrameWork : IGameDelegate
    {
        double r = 1.0;
        double g = 1.0;
        double b = 1.0;
        double a = 1.0;

        int turn = 0;

        bool loveMeter = false;

        Board board;

        public void OnAnimate(GameDelegateEvent gameEvent)
        {


        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(r, g, b, a);
            canvas.Camera.SetRectangle(-1, -1, 12, 12);



            board.DrawLoveMeter(canvas, loveMeter);

            
                board.DrawBoard(canvas, turn);


        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            if (mouse.Y > 300)
            {
                loveMeter = false;
            }
            if (mouse.Y < 300)
            {
                loveMeter = true;
            }
            if (mouse.IsDown(MouseButton.Button1))
            {
                turn++;
            }

        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            board = new Board();
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
