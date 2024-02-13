using System.Windows.Documents;
using System.Collections.Generic;

namespace BlackJack
{
    public class Player
    {
        private string _name = "";
        private int _id;
        private List<Card> _listCards = new List<Card>();

        public bool IsBanca => _id == 0;

        public Player()
        {

        }

        public Player(int ID)
        {
            _id = ID;
        }

        public Player(int ID, string name)
        {
            _id = ID;
            _name = name;
        }
    }
}
