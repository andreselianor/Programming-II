using UDK;
using Chess;

namespace ChessPaint
{
    public class VisualsSample : IGameDelegate
    {
        Board board = new Board();

        // PINTAR PIEZAS
        UDK.IImage? imageWhitePawn1;
        
		public void OnLoad(GameDelegateEvent gameEvent)
        {            
			// Aqui va la ruta de la imagen .png que utilizas para pintar la pieza
            string pathPawnWhite = "../../../resources/whitePawn.png";
			
			// Funcion que carga la imagen del path de arriba dentro de la variable de tipo IImage -> imageWhitePawn1
            imageWhitePawn1 = gameEvent.canvasContext.LoadImageFromFile(pathPawnWhite);           
        }
		
		
        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
			// Esto pinta el canvas
            canvas.Clear(1, 1, 1, 1);
            canvas.Camera.SetRectangle(0, 0, 10, 10);

			// Esto pinta el tablero
            board.BoardPaint(canvas);

			// Esto pinta una figura, el peon blanco
            canvas.DrawImage(imageWhitePawn1, 1, 2, 1, 1);
        }		
		
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
        }
		
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {			
        }		
		
        public void OnUnload(GameDelegateEvent gameEvent)
        {
        }
    }
}
