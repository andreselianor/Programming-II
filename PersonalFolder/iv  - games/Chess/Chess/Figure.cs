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
        private int _x;
        private int _y;
        private ColorType _color;
        private FigureType _type;
        private int _movementCount;


        public Figure(int x, int y, ColorType color, FigureType type)
        {
            _x = x;
            _y = y;
            _color = color;
            _type = type;
        }
    }
}
