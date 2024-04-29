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
                int randomPosition = random.Next(25);
                _listPieces.Add(_listPieces[randomPosition]);
                _listPieces.RemoveAt(randomPosition);
            }
        }
        public Piece TakeTopPiece()
        {
            Piece result = _listPieces[0];
            _listPieces.RemoveAt(0);
            return result;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE DECK.
        Esta clase contiene los funciones de un monto de fichas.
        
        (P) Count 
        Devuelve el numero de piezas del monto.

        + CreateDeck() : void
        Crea un monto de 28 de piezas.

        + ShuffleDeck() : void
        Baraja las piezas.
        
        + TakeTopPiece() : Piece
        Devuelve la primera pieza y la elimina del monto.               
        */
        #endregion
    }
}