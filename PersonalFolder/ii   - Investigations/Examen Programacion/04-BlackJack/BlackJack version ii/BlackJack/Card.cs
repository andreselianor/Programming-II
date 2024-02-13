namespace BlackJack
{
    public enum CardClass
    {
        PICAS,
        TREBOL,
        ROMBO,
        DIAMANTE
    }

    public class Card
    {
        private int _cardValue;
        private bool _isFigure;
        private bool _isAce;
        private CardClass _cardClass;

        public Card(int cardValue, CardClass cardClass)
        {
            _cardValue = cardValue;
            _cardClass = cardClass;
        }

        public bool IsFigure => _cardValue > 10;
        public bool IsAce => _cardValue == 1;
    }
}
