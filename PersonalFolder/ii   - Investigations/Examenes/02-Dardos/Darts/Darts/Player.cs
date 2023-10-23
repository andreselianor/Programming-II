namespace Darts
{
    public class Player
    {
        private string _name = "";
        private int _playerNumber;
        private int _chips;
        private int _puntuationRound;

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

        public int PuntuationRound
        {
            get { return _puntuationRound; }
            set { _puntuationRound = value; }
        }

        public string Name => _name;

        public int BetChips()
        {
            int maxBet;
            int minBet;

            if (Chips < 5)
            {
                maxBet = Chips;
                minBet = 0;
            }
            else
            {
                maxBet = Chips;
                minBet = 5;
            }

            int bet = Utils.GetRandom(minBet, maxBet);            
            Chips -= bet;
            return bet;
        }

        public void ThrowDarts()
        {
            int dartsNumber = 3;
            double ability = Utils.GetRandom(0, 6) * Utils.ThrowAbility();

            _puntuationRound = 0;
            for (int i = 0; i < dartsNumber; i++)
            {
                _puntuationRound += Utils.CalculatePuntuation(ability);
            }
        }
    }
}
