using UDK;
using Chess;

namespace ChessPaint
{
    public class Visuals : IGameDelegate
    {
        Board board = new Board();

        #region OnAnimate
        public void OnAnimate(GameDelegateEvent gameEvent)
        {

        }
        #endregion

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            canvas.Clear(1, 1, 1, 1);
            canvas.Camera.SetRectangle(0, 0, 10, 10);

            board.BoardPaint(canvas);

            // PINTAR PIEZAS
            UDK.IImage? imageBlackPawn;
            UDK.IImage? imageWhitePawn;
            UDK.IImage? imageRedPawn;

            string pathBlack = "../../../resources/blackPawn.png";
            string pathRed = "../../../resources/redPawn.png";
            string pathWhite = "../../../resources/whitePawn.png";

            imageBlackPawn = gameEvent.canvasContext.LoadImageFromFile(pathBlack);
            imageRedPawn = gameEvent.canvasContext.LoadImageFromFile(pathRed);
            imageWhitePawn = gameEvent.canvasContext.LoadImageFromFile(pathWhite);

            canvas.DrawImage(imageBlackPawn, 4, 2, 1, 1);
            canvas.DrawImage(imageBlackPawn, 3, 2, 1, 1);
            canvas.DrawImage(imageRedPawn, 5, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn, 5, 7, 1, 1);
            canvas.DrawImage(imageWhitePawn, 4, 7, 1, 1);
        }

        #region OnKeyboard
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {

        }
        #endregion

        #region OnLoad / OnUnload
        public void OnLoad(GameDelegateEvent gameEvent)
        {

        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }
        #endregion
    }
}
