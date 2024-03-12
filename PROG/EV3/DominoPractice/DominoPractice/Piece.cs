namespace DominoPractice
{
    public class Piece
    {
        private int _up;
        private int _down;
        private bool _IsDoble;

        public int Up
        {
            get => _up;
            //set => _up = value;
        }
        public int Down
        {
            get => _down;
            //set => _down = value;
        }
        public bool Doble => IsDoble();
        public Piece() { }
        public Piece(int up, int down)
        {
            _up = up;
            _down = down;
        }

        private bool IsDoble()
        {
            return _up == _down;
        }
    }
}
