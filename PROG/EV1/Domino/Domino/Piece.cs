namespace Domino
{
    public class Piece
    {
        private int _value1;
        private int _value2;
        private bool _isDouble;

        public Piece()
        {

        }

        public Piece(int value1, int value2, bool isDouble)
        {
            _value1 = value1;
            _value2 = value2;
            _isDouble = isDouble;
        }

        public int GetValue1 => _value1;
        public int GetValue2 => _value2;
    }
}
