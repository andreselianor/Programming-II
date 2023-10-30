namespace DominoVersion2
{
    public class DominoDeck
    {
        private List<DominoPiece> _listPieces = new List<DominoPiece>();

        public void ExtractPiece(int index)
        {
            _listPieces.RemoveAt(index);
        }

        public void ExtractPiece()
        {
            int random = Utils.getRandomInt(0, _listPieces.Count);
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
            
            while(numberShuffle > 0)
            {
                aux = Utils.getRandomInt(0, _listPieces.Count);
                auxPiece = _listPieces[aux];
                _listPieces.RemoveAt(aux);
                _listPieces.Add(auxPiece);
            }
        }
    }
}
