using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Game : IGame
    {
        private List<Player> _listPlayers = new List<Player>();
        private Deck _deck = new Deck();
        private bool _roundHasFinished;


        public void CreatePlayers()
        {
            for (int i = 0; i < 5; i++)
            {
                Player player = new Player(i);
                _listPlayers.Add(player);
            }
        }

        public void CreateDeck()
        {
            _deck.CreateDeck();
            _deck.ShuffleDeck();
        }

        public void DraftACard()
        {
            for (int i = 0; i < _listPlayers.Count; i++)
            {
                Card card = _deck.GetFirstCard();
                _listPlayers[i].GetACard(card);
            }
        }

        public bool PlayersHavePassed()
        {
            for (int i = 0; i < 5; i++)
            {
                if (_listPlayers[i].IsPlaying)
                    return false;
            }

            _roundHasFinished = true;
            return true;
        }
    }
}
