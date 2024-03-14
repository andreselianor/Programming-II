namespace DominoPractice
{
    public class Deck
    {
        private List<Piece> _listPieces = new List<Piece>();

        public int Count => _listPieces.Count;

        public void CreateDeck()
        {
            Piece piece;
            int count = 0;
            for (int i = 0; i < 7; i++)
            {                
                for (int j = count; j < 7; j++)
                {
                    piece = new Piece(i, j);    // decision consciente, me ahorro los 'setters' de las piezas, asi quedan protegidas. 
                    _listPieces.Add(piece);
                }
                count++;
            }
        }
        public void ShuffleDeck(int number)
        {
            Random random = new Random();
            for(int i = 0; i < number; i++)
            {
                int azar = random.Next(25);
                _listPieces.Add(_listPieces[azar]);
                _listPieces.RemoveAt(azar);
            }
        }

        public Piece TakeTopPiece()
        {
            Piece result = _listPieces[0];
            _listPieces.RemoveAt(0);
            return result;
        }
    }
}