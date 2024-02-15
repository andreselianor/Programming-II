using System;

namespace Library
{
    public enum CardType
    {
        PICAS,
        TREBOLES,
        ROMBOS,
        CORAZONES
    }
    public class Card
    {
        private int _cardValue;
        private CardType _cardType;

        public bool IsFigure => _cardValue > 10;
        public bool IsAce => _cardValue == 1;
        

        public Card()
        {

        }

        public Card(CardType cardType, int cardValue)
        {
            _cardType = cardType;
            _cardValue = cardValue;
        }

        public int ValueCard()
        {
            if (_cardValue < 11)
                return _cardValue;
            else
                return 10;
        }
    }
}
