namespace Cards
{
    public enum Palo
    {
        PICA,
        TREBOL,
        CORAZON,
        DIAMANTE
    }

    public enum TypeCard
    {
        COMMON,
        AS,
        JACK,
        QUEEN,
        KING
    }

    public enum TypeColor
    {
        RED,
        BLACK
    }

    public class Card
    {
        private int _number;
        private Palo _palo;

        public Card(int number, Palo palo)
        {
            _number = number;
            _palo = palo;
        }

        public int GetNumber()
        {
            return _number;
        }        

        public Palo GetPalo()
        {
            return _palo;
        }

        public bool IsValid()
        {
            if (_number < 0)
                return false;
            else if (_number > 11)
                return false;
            return true;
        }

        public TypeColor GetColor()
        {
            if(_palo == Palo.PICA || _palo == Palo.CORAZON)
                return TypeColor.RED;
            else
                return TypeColor.BLACK;
        }

        public bool IsFigure()
        {
            return (_number > 7 && _number < 11);
        }

        public TypeCard GetFigureType()
        {
            if (_number == 1)
                return TypeCard.AS;
            if (_number == 8)
                return TypeCard.JACK;
            if (_number == 9)
                return TypeCard.QUEEN;
            if (_number == 10)
                return TypeCard.KING;

            return TypeCard.COMMON;
        }
    }
}
