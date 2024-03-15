namespace DominoPractice
{
    public class Game : IGame
    {
        private List<Player> _playersList;
        private Deck _deck;

        private bool _isRoundTerminated;

        public List<Piece> _playingPieces = new List<Piece>();


        #region FUNCIONES PUBLICAS
        public void InitGame()
        {
            int numberPlayers = 4;
            CreatePlayers(numberPlayers);
        }

        public void InitRound(IGame game)
        {
            CreateDeck();
            ShuffleDeck();
            ClearPlayer();
            PlayRound(game);
        }

        public void PlayRound(IGame game)
        {
            GivePiecesToPlayer();
            SetFirstDomino();
            while (!_isRoundTerminated)
            {
                Play(game);
                _isRoundTerminated = IsWinner();
            }

            Player loserPlayer = GetLoserPlayer();
            RemoveLoserPlayer(loserPlayer);
        }

        public void SetFirstDomino()
        {
            Random random = new Random();
            int players = _playersList.Count;
            int playerTurn = random.Next(players);
            Piece firstDomino = _playersList[playerTurn].FirstDomino();
            _playingPieces.Add(firstDomino);
            _playingPieces.Add(firstDomino);
        }
        public void SetPlayingPiece(Piece updatePiece, Piece removePiece)
        {
            _playingPieces.Add(updatePiece);
            _playingPieces.Remove(removePiece);
        }

        public List<Piece> GetPlayingPieceList()
        {
            return _playingPieces;
        }

        public bool IsWinner()
        {
            for (int i = 0; i < _playersList.Count; i++)
            {
                if (_playersList[i].PiecesCount < 1)
                    return true;
            }
            return false;
        }

        public bool ArePlayersPlaying()
        {
            return _playersList.Count > 1;
        }

        public Player WinnerPlayer()
        {
            return _playersList[0];
        }
        #endregion


        #region FUNCIONES PRIVADAS
        private void CreatePlayers(int number)
        {
            _playersList = new List<Player>();
            for (int i = 0; i < number; i++)
            {
                if(i % 2 == 0)
                {
                    _playersList.Add(new Conservative(i));
                }
                else
                {
                    _playersList.Add(new Impulsive(i));
                }
            }
        }

        private void CreateDeck()
        {
            _deck = new Deck();
            _deck.CreateDeck();
        }

        private void ShuffleDeck(int number = 100)
        {
            _deck.ShuffleDeck(number);
        }

        private void GivePiecesToPlayer()
        {
            Piece piece = new Piece();

            if (_deck.Count > 0)
            {
                for (int i = 0; i < _playersList.Count; i++)
                {
                    piece = _deck.TakeTopPiece();
                    _playersList[i].SetHandPiece(piece);
                }
            }
        }

        private void ClearPlayer()
        {
            for(int i = 0; i < _playersList.Count; i++)
            {
                _playersList[i].Clear();
            }
        }

        private void Play(IGame game)
        {
            for (int i = 0; i < _playersList.Count; i++)
            {
                _playersList[i].Simulate(game);
            }
        }

        private Player GetLoserPlayer()
        {
            int roundResult = 0;
            int playerValue;
            int playerId = 0;
            for (int i = 0; i < _playersList.Count; i++)
            {
                playerValue = _playersList[i].HandPiecesSum;
                if (playerValue > roundResult)
                    playerId = i;
            }
            return _playersList[playerId];
        }

        private void RemoveLoserPlayer(Player loserPlayer)
        {
            _playersList.Remove(loserPlayer);
        }
        #endregion


        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE GAME.
        Esta clase contiene todas las funciones para simular una ronda de domino.
        
        + InitGame(IGame game) : void
        Inicia un juego nuevo de domino. Puedes indicar el numero de jugadores gracias a la variable 'numberPlayers'.

        + InitRound(IGame game) : void
        Inicia una ronda nueva de domino. Crea el monto de piezas, las baraja y las reparte entre los jugadores.
        
        + PlayRound(IGame game) : void
        Se juega una partida de domino. Se juegan las fichas hasta que un jugador se queda sin fichas. 

        + SetPlayingPiece(Piece updatePiece, Piece removePiece) : void
        Se añade una ficha de domino de un jugador a la mesa de juego.

        + GetPlayingPieceList() : List<Piece>
        Devuelve las fichas que llevan el juego de la mesa.

        + GetPlayingPieceList() : List<Piece>
        GetPlayingPieceList()

        + IsWinner() : bool
        Devuelve verdadero si un jugador se queda sin fichas en la mano.

         + IsWinner() : bool
        Devuelve verdadero si un jugador se queda sin fichas en la mano.

        - CreatePlayers(int number) : void
        Crea el numero de jugadores que se le pasa por parametros.

        - CreateDeck() : void
        Crea el monto de fichas.

        - ShuffleDeck : void
        Baraja el monto de fichas.

        - GivePiecesToPlayer() : void
        Reparte la primera ficha del monto a la mano del jugador.

        - Play(IGame game) : void
        Llama a la funcion del jugador para jugar una ficha o pasar.

        - GetLoserPlayer() : Player
        Devuelve el jugador que ha perdido la ronda.

        - GetLoserPlayer(Player) : void
        Se elimina el jugador de la lista de jugadores.
        */
        #endregion
    }
}