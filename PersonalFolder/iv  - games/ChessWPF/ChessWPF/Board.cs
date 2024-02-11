using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ChessWPF
{
    public class Board
    {
        private List<Figure> _listfigure = new List<Figure>();

        public void CreateBoard()
        {
            for(int i = 1; i < 9; i++)
            {
                Position pawnWhiteAPos = new Position(7, i);
                Figure pawnWhiteA = new Pawn(pawnWhiteAPos, Color.WHITE);
                _listfigure.Add(pawnWhiteA);

                Position pawnRedAPos = new Position(2, i);
                Figure pawnRedA = new Pawn(pawnRedAPos, Color.RED);
                _listfigure.Add(pawnRedA);
            }            
        }

        public void PaintFigures(Grid grid)
        {
            foreach(Figure figure in _listfigure)
            {
                figure.PaintFigure(grid);
            }
        }
    }
}