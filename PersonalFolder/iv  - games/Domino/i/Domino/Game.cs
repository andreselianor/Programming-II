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
            // CREATE BOARD
            int numberPlayers = 4;
            CreatePlayers(numberPlayers);
            CreatePieces();

            // INITIAL DRAW
            int shuffle = 50;
            ShufflePieces(shuffle);
            InitialDraw();

            // GAME EXECUTE
            Execute();

            // ENDGAME
            FinishingGame();
            Console.WriteLine("El ganador es el jugador {0}", _winner.Id);
        }

        #region CREATE BOARD
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
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
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

        #region INITIAL DRAW
        public void ShufflePieces(int number)
        {
            Random random = new Random();
            Piece pieceAux = new Piece();

            for (int i = 0; i < number; i++)
            {                
                int position = random.Next(0, _listPieces.Count);
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
                    _listPlayers[j].PlayerHand.Add(_listPieces[0]);
                    _listPieces.RemoveAt(0);
                }
            }
        }
        #endregion

        #region GAME EXECUTE
        public void Execute()
        {
            _playPiece = _listPlayers[0].PlayerHand[0];
            _listPlayers[0].PlayerHand.RemoveAt(0);

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
            for (int i = 0; i < player.PlayerHand.Count; i++)
            {
                if (player.PlayerHand[i].GetValue1 == _playPiece.GetValue2)
                {
                    _playPiece = player.PlayerHand[i];
                    player.PlayerHand.RemoveAt(i);
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
                player.PlayerHand.Add(_listPieces[0]);
                _listPieces.RemoveAt(0);
            }
        }

        public bool IsGameFinished()
        {
            return _listPieces.Count == 0;
        }
        #endregion

        #region ENDGAME
        public void FinishingGame()
        {
            for (int i = 0; i < _listPlayers.Count; i++)
            {
                for (int j = 0; j < _listPlayers[i].PlayerHand.Count; j++)
                {
                    int valuePiece1 = _listPlayers[i].PlayerHand[j].GetValue1;
                    int valuePiece2 = _listPlayers[i].PlayerHand[j].GetValue2;

                    _listPlayers[i].SetHandTotalValue(Utils.CalculateSum(valuePiece1, valuePiece2));
                }
            }

            GetWinner1();
        }


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
            List<int> listPuntuation = new List<int>();

            foreach(Player p in _listPlayers)
            {
                listPuntuation.Add(p.TotalValue);
            }

            int index = 0;
            int winnerPuntuation = listPuntuation[index];            

            for(int i = 1; i < listPuntuation.Count; i++)
            {
                if(listPuntuation[i] < winnerPuntuation)
                {
                    index = i;
                    winnerPuntuation = listPuntuation[index];
                }
            }

            _winner = _listPlayers[index];
        }
        #endregion
    }
}
