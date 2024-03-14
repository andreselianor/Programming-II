namespace DominoPractice
{
    public class Piece
    {
        private int _up;
        private int _down;

        public int Up => _up;
        public int Down => _down;
        public bool Doble => _up == _down;
        public int Value => _up + _down;

        public Piece() { }
        public Piece(int up, int down)
        {
            _up = up;
            _down = down;
        }
    }
}