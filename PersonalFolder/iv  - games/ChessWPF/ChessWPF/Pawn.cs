using System.Windows.Documents;
using System.Collections.Generic;

namespace ChessWPF.resources
{
    public class Pawn
    {
        public int _xPosition;
        public int _yPosition;

        public Pawn(int xPosition, int yPosition)
        {
            _xPosition = xPosition;
            _yPosition = yPosition;
        }

        public List<int> PrintAvailableMovements()
        {
            List<int> list = new List<int>();
            list.Add(5);
            return list;
        }
    }
}
