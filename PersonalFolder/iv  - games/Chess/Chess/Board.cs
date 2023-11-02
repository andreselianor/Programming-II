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

        public void CreatePieces()
        {
            CreatePawns();
            CreateRocks();
            CreateBishops();
            CreateKnights();
            CreateQueenKing();
        }

        public void CreatePawns()
        {
            for(int i = 1; i < 9; i++)
            {                
                Figure f1 = new Pawn(i, 2, ColorType.RED, FigureType.PAWN);
                Figure f2 = new Pawn(i, 2, ColorType.WHITE, FigureType.PAWN);
                _figureList.Add(f1);
                _figureList.Add(f2);
            }            
        }

        public void Execute()
        {

        }

        public bool IsWinner()
        {
            return false;
        }
    }
}
