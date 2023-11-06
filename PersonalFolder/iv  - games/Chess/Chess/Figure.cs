namespace Chess
{
    public enum ColorType
    {
        RED,
        WHITE
    }
    
    public enum FigureType
    {
        PAWN,
        ROCK,
        BISHOP,
        KNIGHT,
        QUEEN,
        KING
    }

    public class Figure
    {
        protected Position _position = new Position();
        private ColorType _color;
        private FigureType _type;
        private int _movementCount;


        public Figure(int x, int y, ColorType color, FigureType type)
        {
            _position.SetPosition(x, y);
            _color = color;
            _type = type;
        }

        public virtual void MoveFigure()
        {
            _movementCount++;
        }

        public Position Position => _position;
        public FigureType FigureType => _type;
        public ColorType ColorType => _color;
    }
}