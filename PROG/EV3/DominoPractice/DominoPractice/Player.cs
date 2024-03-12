namespace DominoPractice
{
    public class Player
    {
        private int _id;
        private string _name;
        private List<Piece> _handPieces;

        public int PiecesCount => _handPieces.Count;
        public int TotalSum => GetTotalSumatory();

        public Player() { }
        public Player(int number)
        {
            _id = number;
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

        public void Play(IGame game)
        {
            Piece piece1 = game.GetPlayingPieceList()[0];
            Piece piece2 = game.GetPlayingPieceList()[1];
            for (int i = 0; i < _handPieces.Count; i++)
            {
                if (_handPieces[i].Up == piece1.Down)
                {
                    _handPieces.RemoveAt(i);
                    game.SetPlayingPiece(_handPieces[i], piece1);

                }
                if (_handPieces[i].Down == piece2.Up)
                {
                    _handPieces.RemoveAt(i);
                    game.SetPlayingPiece(_handPieces[i], piece2);
                }
            }
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
