namespace CardsAndDomino
{
    public class DominoPiece
    {
        private int _value1;
        private int _value2;

        private DominoPiece(int value1, int value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public static DominoPiece? CreateDominoPiece(int value1, int value2)
        {
            if (value1 < 0 || value1 > 7)
                return null;
            if (value2 < 0 || value2 > 7)
                return null;
            else
                return new DominoPiece(value1, value2);
        }

        public int GetValue1 => _value1;
        public int GetValue2 => _value2;

        public bool IsDouble()
        {
            return _value1 == _value2;
        }
    }
}

