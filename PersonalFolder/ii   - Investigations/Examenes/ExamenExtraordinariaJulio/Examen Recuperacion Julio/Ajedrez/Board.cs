using System.Collections.Generic;

namespace Ajedrez
{
    public class Board
    {
        private List<IFigure> _listFigure = new List<IFigure>();

        public Board()
        {
            for(int i = 0; i < 8; i++)
            {
                Figure whitePawn = new Pawn(i, 6, Color.White);
                Figure blackPawn = new Pawn(i, 1, Color.Black);
            }

            Figure whiteKing = new King(4, 7, Color.White);
            Figure blackKing = new King(4, 0, Color.Black);
        }

        public void RemoveFigure (Position position)
        {
            for(int i = 0; i < _listFigure.Count; i++)
            {
                if (_listFigure[i].GetPosition() == position)
                {
                    _listFigure.RemoveAt(i);
                    i--;
                }
            }
        }

        public IFigure GetFigureAt(Position position)
        {
            IFigure result = new Figure();
            for(int i = 0; i< _listFigure.Count; i++)
            {
                if(_listFigure[i].GetPosition() == position)
                    result = _listFigure[i];
            }
            return result;
        }
    }
}
