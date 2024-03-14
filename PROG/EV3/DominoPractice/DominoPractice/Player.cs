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
            _typePlayer = SetTypePlayer();
        }

        #region FUNCIONES PUBLICAS
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
            if (_typePlayer == TypePlayer.IMPULSIVO)
                SimulateImpulsivo(game);
            else
                SimulateConservador(game);
        }
        #endregion

        #region FUNCIONES PRIVADAS
        // public abstract void SimulateImpulsivo(IGame game)
        // public abstract void SimulateConservador(IGame game)
        // Me he dado cuenta tarde que se pedia la herencia de jugadores impulsivos y conservadores.
        // La clase Player seria abstracta y estos metodos se implementaria en cada una de las clase dedicadas 'Conservative' y 'Impulsive'
        // Aqui hay otra manera de hacer funcionar el domino mediante un enum que establece que tipo de jugador es cada uno.

        private void SimulateImpulsivo(IGame game)
        {
            List<Piece> playingPieces = game.GetPlayingPieceList();
            Piece piece1 = playingPieces[0];
            Piece piece2 = playingPieces[1];

            List<Piece> selectedPieces = SortImpulsive(_handPieces);

            for (int i = 0; i < selectedPieces.Count; i++)
            {
                if (selectedPieces[i].Up == piece1.Down)
                {
                    game.SetPlayingPiece(selectedPieces[i], piece1);
                    selectedPieces.RemoveAt(i--);
                }
                else if (selectedPieces[i].Down == piece2.Up)
                {
                    game.SetPlayingPiece(selectedPieces[i], piece2);
                    selectedPieces.RemoveAt(i--);
                }
            }
        }

        private void SimulateConservador(IGame game)
        {
            List<Piece> playingPieces = game.GetPlayingPieceList();
            Piece piece1 = playingPieces[0];
            Piece piece2 = playingPieces[1];

            List<Piece> selectedPieces = SortConservative(_handPieces);

            for (int i = 0; i < selectedPieces.Count; i++)
            {
                if (selectedPieces[i].Up == piece1.Down)
                {
                    game.SetPlayingPiece(selectedPieces[i], piece1);
                    selectedPieces.RemoveAt(i--);
                }
                else if (selectedPieces[i].Down == piece2.Up)
                {
                    game.SetPlayingPiece(selectedPieces[i], piece2);
                    selectedPieces.RemoveAt(i--);
                }
            }
        }

        private List<Piece> SortImpulsive(List<Piece> hand)
        {
            List<Piece> result = new List<Piece>();
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].Doble)
                    result.Add(hand[i]);
            }
            for (int i = 0; i < hand.Count; i++)
            {
                result.Add(hand[i]);
            }
            return result;
        }

        private List<Piece> SortConservative(List<Piece> hand)
        {
            List<Piece> result = new List<Piece>();
            int valuePiece = 13;
            Piece aux;
            for (int i = 0; i < hand.Count; i++)
            {
                for (int j = i + 1; j < hand.Count - 1; j++)
                {
                    if (hand[j].Value < valuePiece)
                    {
                        aux = hand[j];
                        hand[j] = hand[j + 1];
                        hand[j + 1] = aux;
                    }
                }
            }
            return result;
        }
        private TypePlayer SetTypePlayer()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            return randomNumber > 0.5 ? TypePlayer.IMPULSIVO : TypePlayer.CONSERVADOR;
        }
        private int GetTotalSumatory()
        {
            int result = 0;
            for (int i = 0; i < _handPieces.Count; i++)
            {
                if (_handPieces[i].Doble)
                    result += (_handPieces[i].Down + _handPieces[i].Up) * 2;
                else
                    result += _handPieces[i].Value;
            }
            return result;
        }
        #endregion

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE PLAYER.
        Esta clase contiene los funciones del jugador dentro del game.
        
        |#| Player() {}
        |#| Player(number) {_id = number; _typePlayer = SetTypePlayer()}

        + GetListPieces() : List<Piece>
        Devuelve una copia de la lista de piezas del jugador.

        + SetHandPiece(Piece) : void
        Añade una pieza a la mano del jugador.
        
        + FirstDomino() : Piece 
        Funcion que añade al juego la primera pieza de la partida. 

        + SimulatePlay(IGame game) : 
        Funcion que simula la decision de tirar las piezas de cada jugador.
        Se basa en jugadores 'impulsivos' y jugadores 'conservadores'

        + SimulateImpulsivo(IGame game) : void
        Simula el juego de un personaje impulsivo.
        Primero tirara las piezas que sean dobles.

        + SimulateConservador(IGame game) : void
        Simula el juego de un personaje conservador.
        Primero tirara las piezas de mayor valor.
                
        -SortImpulsive(List<Piece> hand) : List<Piece> 
        Ordena la mano de fichas del jugador de manera que primero se encuentran las fichas dobles.

        -SortCompulsive(List<Piece> hand) : List<Piece> 
        Primero se encuentran las fichas de mayor valor.

        - SetTypePlayer() : TypePlayer
        Establece el tipo de jugador mediante un random entre 0.0 y 1.0.

        - GetTotalSumatory() : int
        Devuelve el valor de todas las fichas que componen la mano del jugador.

        */
        #endregion
    }
}
