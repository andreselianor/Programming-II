﻿namespace Darts
{
    public class Player
    {
        private string _name = "";
        private int _playerNumber;
        private int _chips;

        public Player()
        {

        }

        public Player(string name, int playerNumber)
        {
            _name = name;
            _playerNumber = playerNumber;
            _chips = 100;
        }

        public int Chips
        {
            get { return _chips; }
            set { _chips = value; }
        }
    }
}