namespace DominoPractice
{
    public enum TypePlayer
    {
        IMPULSIVO,
        CONSERVADOR
    }
    public class Player
    {
        private int _id;
        private string _name;
        private List<Piece> _handPieces = new List<Piece>();
        private TypePlayer _typePlayer;

        public int Id => _id;
        public int PiecesCount => _handPieces.Count;
        public int HandPiecesSum => GetTotalSumatory();

        public Player() { }
        public Player(int number)
        {
            _id = number;
            _typePlayer = SetTypePlayer(number);
        }

        public List<Piece> GetListPieces()
        {
            List<Piece> pieces = new List<Piece>();
            for (int i = 0; i < _handPieces.Count; i++)
            {
                pieces.Add(_handPieces[i]);
            }
            return pieces;
        }
        public void SetHandPiece(Piece piece)
        {
            _handPieces.Add(piece);
        }

        public Piece FirstDomino()
        {
            Piece FirstPiece = _handPieces[0];
            _handPieces.RemoveAt(0);
            return FirstPiece;
        }

        public void SimulatePlay(IGame game)
        {
            List<Piece> playingPieces = game.GetPlayingPieceList();
            Piece piece1 = playingPieces[0];
            Piece piece2 = playingPieces[1];
            for (int i = 0; i < _handPieces.Count; i++)
            {
                if (_handPieces[i].Up == piece1.Down)
                {                    
                    game.SetPlayingPiece(_handPieces[i], piece1);
                    _handPieces.RemoveAt(i);
                }
                else if (_handPieces[i].Down == piece2.Up)
                {
                    game.SetPlayingPiece(_handPieces[i], piece2);
                    _handPieces.RemoveAt(i);
                }
            }
        }

        private TypePlayer SetTypePlayer(int number)
        {
            return number % 2 == 0 ? TypePlayer.IMPULSIVO : TypePlayer.CONSERVADOR;
        }
        private int GetTotalSumatory()
        {
            int result = 0;
            for (int i = 0; i < _handPieces.Count; i++)
            {
                if (_handPieces[i].Doble)
                    result += (_handPieces[i].Down + _handPieces[i].Up) * 2;
                else
                    result += _handPieces[i].Down + _handPieces[i].Up;
            }
            return result;
        }
    }
}
