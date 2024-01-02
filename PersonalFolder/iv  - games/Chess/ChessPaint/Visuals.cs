using UDK;
using Chess;

namespace ChessPaint
{
    public class Visuals : IGameDelegate
    {
        Board board = new Board();

        // PINTAR PIEZAS
        UDK.IImage? imageRedPawn1;
        UDK.IImage? imageRedPawn2;
        UDK.IImage? imageRedPawn3;
        UDK.IImage? imageRedPawn4;
        UDK.IImage? imageRedPawn5;
        UDK.IImage? imageRedPawn6;
        UDK.IImage? imageRedPawn7;
        UDK.IImage? imageRedPawn8;

        UDK.IImage? imageRedRookLeft;
        UDK.IImage? imageRedKnightLeft;
        UDK.IImage? imageRedKnightRight;
        UDK.IImage? imageRedBishopLeft;
        UDK.IImage? imageRedBishopRight;
        UDK.IImage? imageRedRookRight;
        UDK.IImage? imageRedQueen;
        UDK.IImage? imageRedKing;

        UDK.IImage? imageWhitePawn1;
        UDK.IImage? imageWhitePawn2;
        UDK.IImage? imageWhitePawn3;
        UDK.IImage? imageWhitePawn4;
        UDK.IImage? imageWhitePawn5;
        UDK.IImage? imageWhitePawn6;
        UDK.IImage? imageWhitePawn7;
        UDK.IImage? imageWhitePawn8;

        UDK.IImage? imageWhiteRookLeft;
        UDK.IImage? imageWhiteKnightLeft;
        UDK.IImage? imageWhiteKnightRight;
        UDK.IImage? imageWhiteBishopLeft;
        UDK.IImage? imageWhiteBishopRight;
        UDK.IImage? imageWhiteRookRight;
        UDK.IImage? imageWhiteQueen;
        UDK.IImage? imageWhiteKing;

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

            canvas.DrawImage(imageRedPawn1, 1, 7, 1, 1);
            canvas.DrawImage(imageRedPawn2, 2, 7, 1, 1);
            canvas.DrawImage(imageRedPawn3, 3, 7, 1, 1);
            canvas.DrawImage(imageRedPawn4, 4, 7, 1, 1);
            canvas.DrawImage(imageRedPawn5, 5, 7, 1, 1);
            canvas.DrawImage(imageRedPawn6, 6, 7, 1, 1);
            canvas.DrawImage(imageRedPawn7, 7, 7, 1, 1);
            canvas.DrawImage(imageRedPawn8, 8, 7, 1, 1);

            canvas.DrawImage(imageRedRookLeft, 1, 8, 1, 1);
            canvas.DrawImage(imageRedRookRight, 8, 8, 1, 1);

            canvas.DrawImage(imageRedKnightLeft, 2, 8, 1, 1);
            canvas.DrawImage(imageRedKnightRight, 7, 8, 1, 1);

            canvas.DrawImage(imageRedBishopLeft, 3, 8, 1, 1);
            canvas.DrawImage(imageRedBishopRight, 6, 8, 1, 1);

            canvas.DrawImage(imageRedQueen, 4, 8, 1, 1);
            canvas.DrawImage(imageRedKing, 5, 8, 1, 1);


            canvas.DrawImage(imageWhitePawn1, 1, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 2, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 3, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 4, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 5, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 6, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 7, 2, 1, 1);
            canvas.DrawImage(imageWhitePawn1, 8, 2, 1, 1);

            canvas.DrawImage(imageWhiteRookLeft, 1, 1, 1, 1);
            canvas.DrawImage(imageWhiteRookRight, 8, 1, 1, 1);

            canvas.DrawImage(imageWhiteKnightLeft, 2, 1, 1, 1);
            canvas.DrawImage(imageWhiteKnightRight, 7, 1, 1, 1);

            canvas.DrawImage(imageWhiteBishopLeft, 3, 1, 1, 1);
            canvas.DrawImage(imageWhiteBishopRight, 6, 1, 1, 1);

            canvas.DrawImage(imageWhiteQueen, 4, 1, 1, 1);
            canvas.DrawImage(imageWhiteKing, 5, 1, 1, 1);

        }

        #region OnKeyboard
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            // NUEVO IMPORTANTE
            if (mouse.IsDown(MouseButton.Left))
            {
                var pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
                double position1 = pos.x;
                double position2 = pos.y;
            }
        }
        #endregion

        #region OnLoad / OnUnload
        public void OnLoad(GameDelegateEvent gameEvent)
        {
            /*
            string pathBlack = "../../../resources/blackPawn.png";
            string pathRed = "../../../resources/redPawn.png";
            string pathWhite = "../../../resources/whitePawn.png";

            imageBlackPawn = gameEvent.canvasContext.LoadImageFromFile(pathBlack);
            imageRedPawn = gameEvent.canvasContext.LoadImageFromFile(pathRed);
            imageWhitePawn = gameEvent.canvasContext.LoadImageFromFile(pathWhite);
            */


            // RED TEAM
            string pathPawnRed = "../../../resources/redPawn.png";
            imageRedPawn1 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn2 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn3 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn4 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn5 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn6 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn7 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);
            imageRedPawn8 = gameEvent.canvasContext.LoadImageFromFile(pathPawnRed);

            string pathRookRed = "../../../resources/redRook.png";
            imageRedRookLeft = gameEvent.canvasContext.LoadImageFromFile(pathRookRed);
            imageRedRookRight = gameEvent.canvasContext.LoadImageFromFile(pathRookRed);

            string pathBishopRed = "../../../resources/redBishop.png";
            imageRedBishopLeft = gameEvent.canvasContext.LoadImageFromFile(pathBishopRed);
            imageRedBishopRight = gameEvent.canvasContext.LoadImageFromFile(pathBishopRed);

            string pathKnightRedLeft = "../../../resources/redKnightLeft.png";
            imageRedKnightLeft = gameEvent.canvasContext.LoadImageFromFile(pathKnightRedLeft);
            string pathKnightRedRight = "../../../resources/redKnightRight.png";
            imageRedKnightRight = gameEvent.canvasContext.LoadImageFromFile(pathKnightRedRight);

            string pathQueenRed = "../../../resources/redQueen.png";
            imageRedQueen = gameEvent.canvasContext.LoadImageFromFile(pathQueenRed);

            string pathKingRed = "../../../resources/redKing.png";
            imageRedKing = gameEvent.canvasContext.LoadImageFromFile(pathKingRed);



            // WHITE TEAM
            string pathPawnWhite = "../../../resources/whitePawn.png";
            imageWhitePawn1 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn2 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn3 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn4 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn5 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn6 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn7 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);
            imageWhitePawn8 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);

            string pathRookWhite = "../../../resources/whiteRook.png";
            imageWhiteRookLeft = gameEvent.canvasContext.LoadImageFromFile(pathRookWhite);
            imageWhiteRookRight = gameEvent.canvasContext.LoadImageFromFile(pathRookWhite);

            string pathBishopWhite = "../../../resources/whiteBishop.png";
            imageWhiteBishopLeft = gameEvent.canvasContext.LoadImageFromFile(pathBishopWhite);
            imageWhiteBishopRight = gameEvent.canvasContext.LoadImageFromFile(pathBishopWhite);

            string pathKnightWhiteLeft = "../../../resources/whiteKnightLeft.png";
            imageWhiteKnightLeft = gameEvent.canvasContext.LoadImageFromFile(pathKnightWhiteLeft);
            string pathKnightWhiteRight = "../../../resources/whiteKnightRight.png";
            imageWhiteKnightRight = gameEvent.canvasContext.LoadImageFromFile(pathKnightWhiteRight);

            string pathQueenWhite = "../../../resources/whiteQueen.png";
            imageWhiteQueen = gameEvent.canvasContext.LoadImageFromFile(pathQueenWhite);

            string pathKingWhite = "../../../resources/whiteKing.png";
            imageWhiteKing = gameEvent.canvasContext.LoadImageFromFile(pathKingWhite);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }
        #endregion
    }
}
