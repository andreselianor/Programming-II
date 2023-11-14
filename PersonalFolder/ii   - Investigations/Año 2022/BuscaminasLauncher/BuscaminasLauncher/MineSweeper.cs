using Buscaminas;
using OpenTK.Windowing.Common.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace BuscaminasLauncher
{
    public class MineSweeper : IGameDelegate
    {
        #region Atributos
        UDK.IFontFace? fontFace;

        // AQUI SE SELECCIONA EL TIPO DE TABLERO QUE QUEREMOS UTILIZAR:
        // 1. Matriz BIDIMENSIONAL [,]
        // 2. Matriz []
        // 3. Lista de celdas List<Cell>

        IBoard board = new BoardDimensional();        
        // IBoard board = new BoardArray();
        // IBoard board = new BoardList();        

        // Variables que almacenan imagenes
        // UDK.IImage? image1;
        // UDK.IImage? image2;
        List<UDK.IImage> listImages = new List<UDK.IImage>();
        int randomImage = Utils.GetRandom(0, 7);

        // Condiciones de Victoria
        bool lose = false;
        bool win = false;

        // Tamaño del tablero
        int width = 3;
        int height = 3;

        // Numero de bombas
        int bombNumber = 1;

        // Numero de clicks de raton
        int tickCount = 0;

        // Colores del display grafico
        rgba_f64 colorBomb = new rgba_f64(1.0, 0.1, 0.1, 1.0);
        rgba_f64 colorFlag = new rgba_f64(0.8, 0.9, 0.2, 1.0);
        rgba_f64 colorOpen = new rgba_f64(0.5, 0.8, 0.5, 1.0);
        rgba_f64 colorClose = new rgba_f64(0.0, 0.4, 0.8, 1.0);

        rgba_f64 colorWhite = new rgba_f64(1.0, 1.0, 1.0, 1.0);
        rgba_f64 colorBlack = new rgba_f64(0.0, 0.0, 0.0, 1.0);
        rgba_f64 colorWin = new rgba_f64(0.8, 0.5, 0.1, 1.0);
        rgba_f64 colorLose = new rgba_f64(0.8, 0.1, 0.1, 1.0);
        #endregion

        #region Metodos
        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {
            int cellCountWidth = width;
            int cellCountHeight = height;

            var Rect = new rect2d_f64(0.0, 0.0, cellCountWidth + 1, cellCountHeight);

            canvas.Clear(new rgba_f64(0.2, 0.3, 0.3, 1.0));
            canvas.Camera.SetRect(Rect, true);

            canvas.FillShader.SetColor(new rgba_f64(0.0, 0.0, 1.0, 1.0));
            canvas.Transform.SetIdentity();
            canvas.DrawRectangle(Rect);

            // Display grafico
            var instructions = new rect2d_f64(0.1, 0.1, 0.8, 2.8);
            canvas.FillShader.SetColor(colorWhite);
            canvas.Transform.SetTranslation(cellCountWidth, 0);
            canvas.DrawRectangle(instructions);

            #region Leyenda de colores
            // Leyenda de colores
            var leyendaCerradas = new rect2d_f64(0.2, 0.2, 0.6, 0.5);
            var leyendaAbiertas = new rect2d_f64(0.2, 0.2, 0.6, 0.5);
            var leyendaBombas = new rect2d_f64(0.2, 0.2, 0.6, 0.5);
            var leyendaBanderas = new rect2d_f64(0.2, 0.2, 0.6, 0.5);

            // El primer grupo de parametros define el color de la casilla
            canvas.FillShader.SetColor(colorBomb);
            canvas.Transform.SetTranslation(cellCountWidth, 2.1);
            canvas.DrawRectangle(leyendaBombas);

            // el segundo grupo de parametros define el estilo de la fuente
            canvas.FillShader.SetColor(colorBlack);
            canvas.Transform.SetTranslation(cellCountWidth + 0.25, 2.7);
            canvas.DrawText(new vec2d_f64(0.0, 0.0), "Bomb", fontFace, new TextMode() { height = 0.1, bottomCoords = false });

            // Bandera
            canvas.FillShader.SetColor(colorFlag);
            canvas.Transform.SetTranslation(cellCountWidth, 1.4);
            canvas.DrawRectangle(leyendaBanderas);

            var leyendaBanderaPNG = new rect2d_f64(0.0, 0.0, 0.6, 0.6);
            canvas.FillShader.SetImage(listImages[randomImage], new rgba_f64(1, 1, 1, 1.0));
            canvas.Transform.SetTranslation(cellCountWidth + 0.25, 1.5);
            canvas.DrawRectangle(leyendaBanderaPNG);

            canvas.FillShader.SetColor(colorBlack);
            canvas.Transform.SetTranslation(cellCountWidth + 0.25, 2.0);
            canvas.DrawText(new vec2d_f64(0.0, 0.0), "Flag", fontFace, new TextMode() { height = 0.1, bottomCoords = false });

            // Celda abierta
            canvas.FillShader.SetColor(colorOpen);
            canvas.Transform.SetTranslation(cellCountWidth, 0.7);
            canvas.DrawRectangle(leyendaAbiertas);

            canvas.FillShader.SetColor(colorBlack);
            canvas.Transform.SetTranslation(cellCountWidth + 0.25, 1.3);
            canvas.DrawText(new vec2d_f64(0.0, 0.0), "openCell", fontFace, new TextMode() { height = 0.1, bottomCoords = false });

            // Celda cerrada
            canvas.FillShader.SetColor(colorClose);
            canvas.Transform.SetTranslation(cellCountWidth, 0);
            canvas.DrawRectangle(leyendaCerradas);

            canvas.FillShader.SetColor(colorBlack);
            canvas.Transform.SetTranslation(cellCountWidth + 0.25, 0.6);
            canvas.DrawText(new vec2d_f64(0.0, 0.0), "closeCell", fontFace, new TextMode() { height = 0.1, bottomCoords = false });
            #endregion

            // Mostrar jugadas
            paintCells(canvas, cellCountWidth, cellCountHeight);

            // Condiciones de victoria
            win = board.HasWin();
        }

        private void paintCells(ICanvas canvas, int cellCountWidth, int cellCountHeight)
        {
            for (int y = 0; y < cellCountHeight; y++)
            {
                for (int x = 0; x < cellCountWidth; x++)
                {
                    var Rect = new rect2d_f64(0.1, 0.1, 0.8, 0.8);

                    canvas.FillShader.SetColor(colorClose);
                    canvas.Transform.SetTranslation(x, y);
                    canvas.DrawRectangle(Rect);

                    if (board.IsOpen(x, y) && board.IsBombAt(x, y) == false)
                    {
                        // Pinta una casilla abierta
                        canvas.FillShader.SetColor(colorOpen);
                        canvas.Transform.SetTranslation(x, y);
                        canvas.DrawRectangle(Rect);


                        // Pinta el numero de bombas proximas
                        canvas.FillShader.SetColor(colorBlack);
                        canvas.Transform.Translate(0.45, 0.40);
                        canvas.DrawText(new vec2d_f64(0.0, 0.0), Convert.ToString(board.GetCell(x, y)), fontFace, new TextMode() { height = 0.3, bottomCoords = false });

                    }
                    else if (board.IsOpen(x, y) && board.IsBombAt(x, y))
                    {
                        // Pinta una casilla con bomba y pierde la ronda
                        canvas.FillShader.SetColor(colorBomb);
                        canvas.Transform.SetTranslation(x, y);
                        canvas.DrawRectangle(Rect);
                        lose = true;
                    }

                    else if (board.IsFlagAt(x, y))
                    {
                        // Pinta una bandera                        

                        canvas.FillShader.SetColor(colorFlag);
                        canvas.Transform.SetTranslation(x, y);
                        canvas.DrawRectangle(Rect);

                        var RectFlag = new rect2d_f64(0.0, 0.0, 0.7, 0.7);
                        var desfase = 0.2;
                        
                        canvas.FillShader.SetImage(listImages[randomImage], new rgba_f64(1, 1, 1, 1.0));                        
                        canvas.Transform.SetTranslation(x + desfase, y + desfase);
                        canvas.DrawRectangle(RectFlag);

                        /*
                        var dim = image1.View.Size2D;
                        canvas.FillShader.SetImage(image1, new rgba_f64(1, 1, 1, 1.0));
                        canvas.Transform.SetTranslation(x, y);
                        canvas.DrawRectangle(canvas.FitDimensionsToRect(dim, new rect2d_f64(0, 0, 1, 1)));
                        */
                    }
                }
            }

            if (lose == true)
            {
                // Grafico para mostrar una ronda perdida
                canvas.FillShader.SetColor(colorLose);
                canvas.Transform.SetTranslation(0.1, 1.5);
                canvas.DrawText(new vec2d_f64(0, 0), "HAS PERDIDO", fontFace, new TextMode() { height = 0.5, bottomCoords = false });
            }

            else if (win == true)
            {
                // Grafico para mostrar una ronda ganada
                canvas.FillShader.SetColor(colorWin);
                canvas.Transform.SetTranslation(0.1, 1.5);
                canvas.DrawText(new vec2d_f64(0, 0), "HAS GANADO", fontFace, new TextMode() { height = 0.5, bottomCoords = false });
            }
        }

        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            var pos = gameEvent.coordinateConversor.ViewToWorld(mouse.X, mouse.Y);
            if (mouse.IsPressed(MouseButton.Left))
            {
                tickCount++;
                int casillaX = (int)pos.x;
                int casillaY = (int)pos.y;
                
                // el primer Click Inicializa el tablero
                if (tickCount == 1)                
                    board.Init(width, height, bombNumber);                

                // Click izquierdo abre una casilla
                board.RecursiveOpenCell(casillaX, casillaY);                
            }

            if (mouse.IsPressed(MouseButton.Right))
            {
                int casillaX = (int)pos.x;
                int casillaY = (int)pos.y;

                // Click derecho añade una bandera
                board.PutFlagAt(casillaX, casillaY);
            }
        }

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            // Se carga una fontFace para mostrar texto
            fontFace = gameEvent.canvasContext.CreateFont(CODEC.LoadFontFromFiles("resources/ArialCE.ttf"))?.CreateFontFace(64.0);

            // Se carga una imagen PNG para mostrar banderas
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/rusia.png"));
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/alemania.png"));
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/dinamarca.png"));
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/holanda.png"));
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/inglaterra.png"));
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/españa.png"));
            listImages.Add(gameEvent.canvasContext.LoadImageFromFile("resources/italia.png"));

            // Se crea un tablero nuevo
            board.CreateBoard(width, height);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }
        #endregion
    }
}
