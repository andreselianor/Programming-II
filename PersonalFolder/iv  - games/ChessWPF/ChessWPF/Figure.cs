using System.Windows.Controls;

namespace ChessWPF
{
    public enum FigureType
    {
        PAWN
    }
    public enum Color
    {
        WHITE,
        RED
    }
    public abstract class Figure
    {
        protected Position _position;
        protected FigureType _figureType;
        protected Color _color;

        public abstract void PaintFigure(Grid grid);
    }
}