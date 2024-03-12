namespace DominoPractice
{
    public class Deck
    {
        private List<Piece> _deck;

        public int Count => _deck.Count;

        public void CreateDeck()
        {
            Piece piece;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    piece = new Piece(i, j);    // decision consciente, me ahorro los 'setters' de las piezas, asi quedan protegidas. 
                    _deck.Add(piece);
                }
            }
        }
        public void ShuffleDeck(int number)
        {
            Random random = new Random();
            for(int i = 0; i < number; i++)
            {
                int azar = random.Next(Count);
                _deck.Add(_deck[azar]);
                _deck.RemoveAt(azar);
            }
        }

        public Piece GiveTopPiece()
        {
            Piece result = _deck[0];
            _deck.RemoveAt(0);
            return result;
        }
    }
}
