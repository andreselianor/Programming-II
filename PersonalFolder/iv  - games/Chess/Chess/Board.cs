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
                SelectFigure(_figureList);
                MoveFigure(figure);

                SelectFigure(_figureList);
                MoveFigure(figure);
            }
        }
        #endregion

        #region Selecting / Moving Pieces
        public void SelectFigure(List<Figure> listFigure)
        {

        }

        public void MoveFigure(Figure figure)
        {
            figure.MovePawn();
        }
        #endregion

        #region Victory Conditions
        public bool IsWinner()
        {
            return (IsKingDead());
        }

        public bool IsKingDead()
        {
            return false;
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
            Figure f1 = new Rock(1, 2, ColorType.RED, FigureType.ROCK);
            Figure f2 = new Rock(1, 2, ColorType.WHITE, FigureType.ROCK);
            Figure f3 = new Rock(8, 2, ColorType.RED, FigureType.ROCK);
            Figure f4 = new Rock(8, 2, ColorType.WHITE, FigureType.ROCK);
            _figureList.Add(f1);
            _figureList.Add(f2);
            _figureList.Add(f3);
            _figureList.Add(f4);
        }
        public void CreateBishops()
        {

        }

        public void CreateKnights()
        {

        }

        public void CreateQueenKing()
        {

        }
        #endregion
    }
}
