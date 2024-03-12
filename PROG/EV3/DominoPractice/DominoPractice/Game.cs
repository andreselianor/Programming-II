namespace DominoPractice
{
    public class Game : IGame
    {
        private List<Player> _playersList;
        private Deck _deck;
        private bool _isWinner;
        private bool _isRoundFinish;
        public List<Piece> _playingPieces;

        public static void RunGame(IGame core)
        {
            Game game = new Game();
            game.InitGame(core);
        }
        public void InitGame(IGame game)
        {
            int numberPlayers = 4;
            CreatePlayers(numberPlayers);

            int shuffleTimes = 50;
            _deck.CreateDeck();
            _deck.ShuffleDeck(shuffleTimes);

            PlayRound(game);
        }

        public void CreatePlayers(int number)
        {
            _playersList = new List<Player>();
            for (int i = 0; i < number; i++)
            {
                _playersList.Add(new Player(i));
            }
        }

        public void PlayRound(IGame game)
        {
            while (!_isRoundFinish)
            {
                GivePiecesToPlayer();
                PlayerPlay(game);

                _isRoundFinish = IsWinner();
            }

            Player loserPlayer = GetLoserPlayer();
            _playersList.Remove(loserPlayer);
        }

        private void GivePiecesToPlayer()
        {
            Piece piece = new Piece();
            while(_deck.Count > 0)
            {
                for(int i = 0; i < _playersList.Count; i++)
                {
                    piece = _deck.GiveTopPiece();
                    _playersList[0].SetHandPiece(piece);
                }   
            }
        }
        private void PlayerPlay(IGame game)
        {
            for(int i = 0; i < _playersList.Count; i++)
            {
                _playersList[i].Play(game);
            }
        }

        public void SetPlayingPiece(Piece updatePiece, Piece removePiece)
        {
            _playingPieces.Add(updatePiece);
            _playingPieces.Remove(removePiece);
        }

        public bool IsWinner()
        {
            for (int i = 0; i < _playersList.Count; i++)
            {
                if (_playersList[i].PiecesCount <= 0)
                    return true;
            }
            return false;
        }

        private Player GetLoserPlayer()
        {
            Player loserPlayer = new Player();
            int totalSum = 0;
            for(int i = 0; i < _playersList.Count; i++)
            {
                int totalPlay = _playersList[i].TotalSum;
                if(totalPlay > totalSum)
                    loserPlayer = _playersList[i];
            }

            return loserPlayer;
        }

        public List<Piece> GetPlayingPieceList()
        {
            List<Piece> pieces = new List<Piece>();
            pieces.Add(_playingPieces[0]);
            pieces.Add(_playingPieces[1]);
            return pieces;
        }
    }
}