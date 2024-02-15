using System;
using System.Windows.Documents;
using System.Collections.Generic;

namespace Library
{
    public enum PlayState
    {
        PLAYING,
        PASSING
    }

    public class Player
    {
        private int _playerNumber;
        private string _name = "";
        private int _chips = 10;
        private PlayState _playState;
        private List<Card> _listCards = new List<Card>();

        public bool IsBanca => _playerNumber == 0;
        public bool IsPassing => _playState == PlayState.PASSING;
        public bool IsPlaying => _playState == PlayState.PLAYING;


        public Player(int PlayerNumber)
        {
            _playerNumber = PlayerNumber;
        }

        public void GetACard(Card card)
        {
            _listCards.Add(card);
        }

        public int CountCards()
        {
            int result = 0;
            for (int i = 0; i < _listCards.Count; i++)
            {
                result += _listCards[i].ValueCard();
            }
            return result;
        }

        public void DecisionToPlay()
        {
            double cardCounting = CountCards() * 0.01;

            Random random = new Random();
            double randomPlay = random.NextDouble() - cardCounting;

            if (randomPlay < 0.5)
                _playState = PlayState.PASSING;
            else
                _playState = PlayState.PLAYING;
        }

        public void BettingChips()
        {
            _chips -= 1;
        }

        public void WinningChips(int number)
        {
            _chips += number;
        }
    }
}
