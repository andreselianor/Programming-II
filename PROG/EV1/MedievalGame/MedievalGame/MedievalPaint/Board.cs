using UDK;
using MedievalGame;

namespace MedievalPaint
{
    public class Board : IGameDelegate
    {
        Warzone warzone = new Warzone();

        #region OnAnimate
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }
        #endregion

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(1.0, 1.0, 1.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, 10, 10);

            warzone.PaintWarzone(canvas);
            warzone.PaintWarriors(canvas);

        }

        #region OnKeyboard / OnLoad / OnUnload
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
        #endregion
    }
}
