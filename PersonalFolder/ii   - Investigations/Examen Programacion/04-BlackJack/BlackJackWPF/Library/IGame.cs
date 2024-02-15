using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IGame
    {
        void CreatePlayers();
        void CreateDeck();
        void DraftACard();
        bool PlayersHavePassed();

    }
}
