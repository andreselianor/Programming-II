namespace Dardos
{
    public class Game
    {
        private List<Player> _playerList = new List<Player>();
        private List<Player> _playerListGreatThrow = new List<Player>();
        private int _totalBet;
        private bool _winGame;


        // Funcion que crea los jugadores del juego.
        // Se le pasa por parametro el numero de jugadores.
        public void CreatePlayers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Player player = new Player();
                _playerList.Add(player);
            }
        }


        // Funcion que ejecuta el juego
        public void ExecuteGame()
        {
            while (_winGame == false)
            {
                PlayerBet();
                IsGreatThrow();
                PlayerGreatThrow();
                PlayerThrow();
                GetWinnerOneRound();
                LoseGame();
                WinnerGame();
                EndRound();
            }
        }

        public void PlayerBet()
        {
            // Cada jugador apuesta fichas. Se suman a la cantidad total apostada.
            _totalBet = 0;
            for (int i = 0; i < _playerList.Count; i++)
            {
                _totalBet += _playerList[i].BetChips();
            }
        }

        public bool IsGreatThrow()
        {
            for (int i = 0; i < _playerList.Count; i++)
            {
                if (_playerList[i].GreatThrow)
                    return true;
            }
            return false;
        }

        public void PlayerGreatThrow()
        {
            for (int i = 0; i < _playerList.Count; i++)
            {
                if (_playerList[i].GreatThrow)
                {
                    _playerListGreatThrow.Add(_playerList[i]);
                    _playerList.RemoveAt(i);
                }
            }
        }
        public void PlayerThrow()
        {
            // Cada jugador lanza un numero de dardos.
            int numberDarts = 3;
            if (IsGreatThrow())
            {
                for (int i = 0; i < _playerListGreatThrow.Count; i++)
                {
                    _playerListGreatThrow[i].ThrowDarts(numberDarts + 1);
                }

                for (int i = 0; i < _playerList.Count; i++)
                {
                    _playerList[i].ThrowDarts(numberDarts - 1);
                }
            }
            else
            {
                for (int i = 0; i < _playerList.Count; i++)
                {
                    _playerList[i].ThrowDarts(3);
                }
            }
        }


        // Funcion que establece que jugador es el ganador de cada ronda.
        // Se recorre la lista de jugadores comprobando quien tiene la mayor puntuacion.
        // Se retorna el jugador con la mayor puntuacion.
        // Cuidado con los errores de index fuera de limite al recorrer la lista.
        // Se arregla con una condicion if.
        public Player GetWinnerOneRound()
        {
            // Se localiza el ganador de la ronda. Gana la cantidad total apostada.           

            Player winnerRound = _playerList[0];
            
            for(int i = 1; i < _playerList.Count; i++)
            {
                if (_playerList[i].Money > winnerRound.Money)
                {
                    Player valueAux = new Player();
                    winnerRound = valueAux;
                    _playerList[i] = winnerRound;
                }
            }
            winnerRound.Money += _totalBet;
            return winnerRound;
        }

        // Funcion que establece si un jugador ha perdido una ronda.
        // En ese caso, se saca de la lista.
        public void LoseGame()
        {
            // Se recorre la lista de jugadores para comprobar si alguno ha perdido.
            for (int i = 0; i < _playerList.Count; i++)
            {
                if (_playerList[i].Money == 0)
                {
                    _playerList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void WinnerGame()
        {
            // Se recorre la lista de jugadores para comprobar si solo queda un jugador.
            for (int i = 0; i < _playerList.Count; i++)
            {
                if (_playerList.Count == 1)
                {
                    Player winner = _playerList[0];
                    _winGame = true;
                }
            }
        }

        public void EndRound()
        {
            // Funcion que termina la ronda y elimina los jugadores de la lista de grandes tiradas.
            for (int i = 0; i < _playerListGreatThrow.Count; i++)
            {
                _playerList.Add(_playerList[i]);
                _playerListGreatThrow.RemoveAt(i);
            }
        }
    }
}
