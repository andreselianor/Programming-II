using System.Windows.Documents;
using System.Collections.Generic;

namespace BlackJack
{
    public class Game : IGame
    {
        private Deck _deck = new Deck();
        private List<Player> _listPlayers = new List<Player>();
        private bool _arePlayersPlaying;

        public Game()
        {

        }

        public void CreateGame()
        {
            CreatePlayers();
            _deck.CreateDeck();
            
        }

        private void CreatePlayers()
        {
            for (int i = 0; i < 4; i++)
            {
                Player player = new Player(i);
                _listPlayers.Add(player);
            }
        }

    }
}
