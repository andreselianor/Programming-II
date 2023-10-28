namespace Domino
{
    public class Game
    {
        private List<Piece> _listPieces = new List<Piece>();
        private List<Player> _listPlayers = new List<Player>();
        private Piece? _playPiece;
        private Player? _winner;

        private Dictionary<int, Player> _DictionaryWinner;

        public void Play()
        {
            int numberPlayers = 4;
            CreatePlayers(numberPlayers);
            CreatePieces();

            int shuffle = 50;
            ShufflePieces(shuffle);
            InitialDraw();

            Execute();
            FinishingGame();

            Console.WriteLine("El ganador es el jugador {0}", _winner.Id);
        }

        #region CreateBoard
        public void CreatePlayers(int playerNumber)
        {
            for (int i = 1; i <= playerNumber; i++)
            {
                Player Player = new Player(i);
                _listPlayers.Add(Player);
            }
        }

        public void CreatePieces()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == j)
                    {
                        Piece pieceDouble = new Piece(i, j, true);
                        _listPieces.Add(pieceDouble);
                    }

                    else
                    {
                        Piece piece = new Piece(i, j, false);
                        _listPieces.Add(piece);
                    }
                }
            }
        }
        #endregion

        #region InitGame
        public void ShufflePieces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                int position = random.Next(0, _listPieces.Count);
                Piece pieceAux = new Piece();

                pieceAux = _listPieces[position];
                _listPieces.RemoveAt(position);
                _listPieces.Add(pieceAux);
            }
        }

        public void InitialDraw()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < _listPlayers.Count; j++)
                {
                    _listPlayers[j].Hand.Add(_listPieces[0]);
                    _listPieces.RemoveAt(0);
                }
            }
        }
        #endregion

        #region PlayGame
        public void Execute()
        {
            _playPiece = _listPlayers[0].Hand[0];

            while (!IsGameFinished())
            {
                for (int i = 0; i < _listPlayers.Count; i++)
                {
                    PlayPiece(_listPlayers[i]);
                }
                IsGameFinished();
            }
        }


        public void PlayPiece(Player player)
        {
            for (int i = 0; i < player.Hand.Count; i++)
            {
                if (player.Hand[i].GetValue1 == _playPiece.GetValue2)
                {
                    _playPiece = player.Hand[i];
                    player.Hand.RemoveAt(i);
                }
                else
                {
                    DrawPieces(player);
                }
            }
        }

        public void DrawPieces(Player player)
        {
            if (_listPieces.Count > 0)
            {
                player.Hand.Add(_listPieces[0]);
                _listPieces.RemoveAt(0);
            }
        }
        #endregion

        #region EndGame
        public bool IsGameFinished()
        {
            return _listPieces.Count == 0;
        }

        public void FinishingGame()
        {
            for (int i = 0; i < _listPlayers.Count; i++)
            {
                for (int j = 0; j < _listPlayers[i].Hand.Count; j++)
                {
                    _listPlayers[i].SetTotalValue(Utils.SumValue(_listPlayers[i].Hand[j].GetValue1,
                                                                 _listPlayers[i].Hand[j].GetValue2));
                }
            }

            GetWinner2();
        }
        #endregion

        public void GetWinner1()
        {
            Player playerAux;
            for (int i = 0; i < _listPlayers.Count - 1; i++)
            {
                for (int j = i + 1; j < _listPlayers.Count; j++)
                {

                    if (_listPlayers[i].TotalValue > _listPlayers[j].TotalValue)
                    {
                        playerAux = _listPlayers[i];
                        _listPlayers[i] = _listPlayers[j];
                        _listPlayers[j] = playerAux;
                    }
                }
            }
            _winner = _listPlayers[0];
        }
        public void GetWinner2()
        {
            _DictionaryWinner = new Dictionary<int, Player>();

            for (int i = 0; i < _listPlayers.Count; i++)
            {
                _DictionaryWinner.Add(_listPlayers[i].TotalValue, _listPlayers[i]);
            }

            KeyValuePair<int, Player> winner = _DictionaryWinner.ElementAt(0);
            foreach (KeyValuePair<int, Player> value in _DictionaryWinner)
            {
                if (value.Key < winner.Key)
                {
                    _winner = value.Value;
                }
            }
        }
        public void GetWinner3()
        {

        }
    }
}
