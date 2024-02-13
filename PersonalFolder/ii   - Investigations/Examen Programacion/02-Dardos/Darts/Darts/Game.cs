namespace Darts
{
    public class Game
    {
        // ATRIBUTOS
        private List<Player> _listPlayer = new List<Player>();
        private int _totalBet;
        Player? activePlayer;
        private bool _winner = false;
        int playerCount = 4;
        List<string> listNames = new List<string>() 
        { 
            "Horacio", 
            "Sempronio", 
            "Jacinto", 
            "Elegia" 
        };

        // FUNCION DEL MAIN
        public void ExecuteGame()
        {
            CreatePlayers(playerCount, listNames);

            while (!_winner)
            {
                Betting();
                Throwing();
                RemovingLosers();
                _winner = IsWinner();
            }
            Winner();            
        }


        #region Metodos de Objeto
        public void CreatePlayers(int playerNumber, List<string> listNames)
        {
            for (int i = 0; i < playerNumber; i++)
            {
                Player playerOn;
                playerOn = new Player(listNames[i], listNames.Count);
                _listPlayer.Add(playerOn);
            }
        }

        public void Betting()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                activePlayer = _listPlayer[i];

                activePlayer.BetChips();
                _totalBet += activePlayer.BetChips();
            }
        }

        public void Throwing()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                activePlayer = _listPlayer[i];

                activePlayer.ThrowDarts();
            }
        }

        public void RemovingLosers()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                if (_listPlayer[i].Chips <= 0)
                    _listPlayer.RemoveAt(i);
            }
        }

        public bool IsWinner()
        {
            return _listPlayer.Count == 1;
        }

        public string Winner()
        {            
            string winner = _listPlayer[0].Name;            
            return string.Format("El Ganador de la partida es: {0}", winner);
            
            // Console.WriteLine("El Ganador de la partida es: {0}", winner);
        }
        #endregion
    }
}
