namespace Domino
{
    public class Player
    {
        private string _name = "";
        private int _id;
        private List<Piece> _playerHand = new List<Piece>();
        private int _totalPieceValue;

        public Player()
        {

        }

        public Player(int id)
        {
            _id = id;
        }

        public Player(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public int Id => _id;
        public string Name => _name;
        public List<Piece> PlayerHand => _playerHand;
        public int TotalValue => _totalPieceValue;


        public void SetHandTotalValue (int value)
        {
            _totalPieceValue += value;
        }
    }
}
