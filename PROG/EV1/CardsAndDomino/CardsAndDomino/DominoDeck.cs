namespace CardsAndDomino
{
    public class DominoDeck
    {
        private List<DominoPiece> _listPieces = new List<DominoPiece>();

        public DominoPiece? ExtractPiece(int index)
        {
            if (index < 0 || index >= _listPieces.Count)
                return null;

            DominoPiece piece = _listPieces[index];
            _listPieces.RemoveAt(index);
            return piece;
        }

        public void ExtractPiece()
        {
            int random = Utils.GetRandomInt(0, _listPieces.Count);
            ExtractPiece(random);
        }

        public int GetPieceCount()
        {
            return _listPieces.Count;
        }

        public DominoPiece GetPieceAt(int index)
        {
            return _listPieces[index];
        }

        public void AddPiece(DominoPiece Piece)
        {
            _listPieces.Add(Piece);
        }

        public void Shuffle(int numberShuffle)
        {
            int aux;
            DominoPiece auxPiece;

            while (numberShuffle > 0)
            {
                aux = Utils.GetRandomInt(0, _listPieces.Count);
                auxPiece = _listPieces[aux];
                _listPieces.RemoveAt(aux);
                _listPieces.Add(auxPiece);
            }
        }
    }
}
