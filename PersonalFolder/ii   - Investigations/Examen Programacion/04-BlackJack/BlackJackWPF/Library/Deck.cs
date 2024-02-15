using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Deck
    {
        private List<Card> _listCards = new List<Card>();

        public int ListCount => _listCards.Count;


        public void CreateDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; i++)
                {
                    CardType typeCard = (CardType)i;
                    Card card = new Card(typeCard, j);
                    _listCards.Add(card);
                }
            }
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            Card auxCard = new Card();
            for (int i = 0; i < 100; i++)
            {
                int randomPosition = random.Next(_listCards.Count);
                auxCard = _listCards[0];
                _listCards[0] = _listCards[randomPosition];
                _listCards[randomPosition] = auxCard;
            }
        }

        public Card GetFirstCard()
        {
            Card card = _listCards[0];
            _listCards.RemoveAt(0);
            return card;
        }
    }
}
