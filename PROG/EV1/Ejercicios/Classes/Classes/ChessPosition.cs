namespace Classes
{
    public class ChessPosition
    {
        private int _x;
        private int _y;

        public int PositionX => _x;
        public int PositionY => _y;

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
