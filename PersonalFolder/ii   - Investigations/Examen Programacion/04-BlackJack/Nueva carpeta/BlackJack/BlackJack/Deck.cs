using System.Windows.Documents;
using System.Collections.Generic;
using System;

namespace BlackJack
{
    public class Deck
    {
        private List<Card> _listCards = new List<Card>();

        public void CreateDeck()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 14; i++)
                {
                    Card card = new Card(i, (CardClass)j);
                    _listCards.Add(card);
                }
            }
        }
    }
}
