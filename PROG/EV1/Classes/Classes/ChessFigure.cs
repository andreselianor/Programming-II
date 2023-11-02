namespace Classes
{  
    public class ChessFigure
    {
        private int _x;
        private int _y;
        private FigureType _figureType;
        private ColorType _color;
        private int _movementCount;

        public enum FigureType
        {
            PAWN,
            KNIGHT,
            BISHOP,
            ROCK,
            QUEEN,
            KING
        }

        public enum ColorType
        {
            RED,
            WHITE
        }

        public ChessFigure(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X => _x;
        public int Y => _y;


        public bool IsValid()
        {
            return (X > 0 && X < 9 && Y > 0 || Y < 9);
        }

        public int GetMovementCount()
        {
            return _movementCount;
        }

        public bool HasBeenMoved()
        {
            return _movementCount > 0;
        }

        internal void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Promote()
        {
            _figureType = FigureType.QUEEN;
        }

        public void GetRectangle()
        {
            PaintBoardRectangles();
        }

        public void PaintBoardRectangles()
        {

        }
    }
}
