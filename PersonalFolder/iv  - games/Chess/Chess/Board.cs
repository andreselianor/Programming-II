using OpenTK.Core;
using System.Diagnostics.Metrics;
using UDK;

namespace Chess
{
    public class Board
    {
        private int _xCell;
        private int _yCell;

        private List<Figure> _figureList = new List<Figure>();

        public Board()
        {
            _xCell = 8;
            _yCell = 8;
        }

        #region Game
        public void CreatePieces()
        {
            CreatePawns();
            CreateRocks();
            CreateBishops();
            CreateKnights();
            CreateQueenKing();
        }

        public void Execute()
        {
            while (true)
            {
                Figure figure = new Figure(1, 1, ColorType.RED, FigureType.PAWN);
                SelectFigure(5, 5);
                MoveFigure(figure);

                SelectFigure(5, 5);
                MoveFigure(figure);
            }
        }
        #endregion

        #region Selecting / Moving Pieces
        public Figure? SelectFigure(int x, int y)
        {
            for (int i = 0; i < _figureList.Count; i++)
            {
                if (_figureList[i].Position.X == x && _figureList[i].Position.Y == y)
                    return _figureList[i];
            }
            return null;
        }

        public void MoveFigure(Figure figure)
        {
            figure.MoveFigure();
        }
        #endregion

        #region Victory Conditions
        public ColorType IsWinner()
        {
            Figure winner = null;
            for (int i = 0; i < _figureList.Count; i++)
            {
                if (_figureList[i].FigureType == FigureType.KING)
                    winner = _figureList[i];
            }
            return winner.ColorType;
        }

        public bool IsKingDead()
        {
            int counter = 0;
            for (int i = 0; i < _figureList.Count; i++)
            {
                if (_figureList[i].FigureType == FigureType.KING)
                    counter++;
            }

            return (counter == 2);
        }
        #endregion

        #region Creating Pieces
        public void CreatePawns()
        {
            for (int i = 1; i < 9; i++)
            {
                Figure f1 = new Pawn(i, 2, ColorType.RED, FigureType.PAWN);
                Figure f2 = new Pawn(i, 2, ColorType.WHITE, FigureType.PAWN);
                _figureList.Add(f1);
                _figureList.Add(f2);
            }
        }
        public void CreateRocks()
        {
            Figure f1 = new Rock(1, 1, ColorType.RED, FigureType.ROCK);
            Figure f2 = new Rock(1, 1, ColorType.WHITE, FigureType.ROCK);
            Figure f3 = new Rock(8, 1, ColorType.RED, FigureType.ROCK);
            Figure f4 = new Rock(8, 1, ColorType.WHITE, FigureType.ROCK);
            _figureList.Add(f1);
            _figureList.Add(f2);
            _figureList.Add(f3);
            _figureList.Add(f4);
        }
        public void CreateBishops()
        {
            Figure f1 = new Bishop(3, 1, ColorType.RED, FigureType.BISHOP);
            Figure f2 = new Bishop(3, 1, ColorType.WHITE, FigureType.BISHOP);
            Figure f3 = new Bishop(6, 1, ColorType.RED, FigureType.BISHOP);
            Figure f4 = new Bishop(6, 1, ColorType.WHITE, FigureType.BISHOP);
            _figureList.Add(f1);
            _figureList.Add(f2);
            _figureList.Add(f3);
            _figureList.Add(f4);
        }

        public void CreateKnights()
        {
            Figure f1 = new Knight(2, 1, ColorType.RED, FigureType.KNIGHT);
            Figure f2 = new Knight(2, 1, ColorType.WHITE, FigureType.KNIGHT);
            Figure f3 = new Knight(7, 1, ColorType.RED, FigureType.KNIGHT);
            Figure f4 = new Knight(7, 1, ColorType.WHITE, FigureType.KNIGHT);
            _figureList.Add(f1);
            _figureList.Add(f2);
            _figureList.Add(f3);
            _figureList.Add(f4);
        }

        public void CreateQueenKing()
        {
            Figure f1 = new Queen(4, 1, ColorType.RED, FigureType.QUEEN);
            Figure f2 = new Queen(4, 1, ColorType.WHITE, FigureType.QUEEN);
            Figure f3 = new King(5, 1, ColorType.RED, FigureType.KING);
            Figure f4 = new King(5, 1, ColorType.WHITE, FigureType.KING);
            _figureList.Add(f1);
            _figureList.Add(f2);
            _figureList.Add(f3);
            _figureList.Add(f4);
        }
        #endregion

        #region Visuals
        public void BoardPaint(ICanvas canvas)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (Utils.IsEven(i + j))
                    {
                        canvas.FillShader.SetColor(0, 0, 0, 1);
                        canvas.DrawRectangle(i, j, 1, 1);
                    }

                    else
                    {
                        canvas.FillShader.SetColor(1, 1, 1, 1);
                        canvas.DrawRectangle(i, j, 1, 1);
                    }
                }
            }
        }
        #endregion
    }
}
