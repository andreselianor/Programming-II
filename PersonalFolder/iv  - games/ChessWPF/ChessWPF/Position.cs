namespace ChessWPF
{
    public class Position
    {
        private int _positionX;
        private int _positionY;

        public int X
        {
            get { return _positionX; }
            set { _positionX = value; }
        }

        public int Y
        {
            get { return _positionY; }
            set { _positionY = value; }
        }

        public Position(int positionX, int positionY)
        {
            _positionX = positionX;
            _positionY = positionY;
        }
    }
}