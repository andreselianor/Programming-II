﻿namespace Darts
{
    public class Game
    {
        private List<Player> _listPlayer = new List<Player>();
        private int _totalBet;

        public void CreatePlayers(int playerNumber, List<string> listNames, int[] arrayNumber)
        {
            for (int i = 0; i < playerNumber; i++)
            {
                Player playerOn;
                playerOn = new Player(listNames[i], arrayNumber[i]);
                _listPlayer.Add(playerOn);
            }
        }

        public void ExecuteGame()
        {
            for(int i = 0; i < _listPlayer.Count; i++)
            {
                BetChips(_listPlayer[i]);
            }
            
        }

        public string Winner()
        {
            return "";
        }

        public void BetChips(Player p)
        {
            int maxBet;
            int minBet;

            if(p.Chips < 5)
            {
                maxBet = p.Chips;
                minBet = 0;
            }
            else
            {
                maxBet = p.Chips;
                minBet = 5;
            }

            int bet = Utils.GetRandom(minBet, maxBet);

            _totalBet += bet;
            p.Chips -= bet;
        }
    }
}