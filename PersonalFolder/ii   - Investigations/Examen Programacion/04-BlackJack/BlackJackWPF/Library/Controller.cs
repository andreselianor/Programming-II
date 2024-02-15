using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Controller
    {

        public void PlayingGame(IGame game)
        {
            game.CreatePlayers();
            game.CreateDeck();

            game.DraftACard();

            while(!game.PlayersHavePassed())
            {

            }
        }
    }
}
