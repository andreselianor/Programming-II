namespace JuegoOca
{
    public class Player
    {
        private int _idName;
        private int _cellNumber;
        private bool _ableToMove;
        private int _haltTurns;

        // Properties
        public int CellNumber => _cellNumber;
        public bool AbletoMove
        {
            get { return _ableToMove; }
            set { _ableToMove = value; }
        }

        public int HaltTurns
        {
            get { return _haltTurns; }
            set { _haltTurns = value; }
        }

        // Funciones
        public void SetCell(int casilla)
        {
            _cellNumber = casilla;
        }

        public int PlayerMove()
        {
            return Utils.GetRandom();
        }

        public void AbleToMove()
        {
            if(_haltTurns <= 0)
            {
                _ableToMove = true;
            }            
        }
    }
}
