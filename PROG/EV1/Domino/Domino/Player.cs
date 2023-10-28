namespace Domino
{
    public class Player
    {
        private string _name = "";
        private int _id;
        private List<Piece> _hand = new List<Piece>();
        private int _totalValue;

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
        public List<Piece> Hand => _hand;

        public int TotalValue => _totalValue;
        public void SetTotalValue (int value)
        {
            _totalValue += value;
        }
    }
}
