using System.Collections.Generic;

namespace Ajedrez
{

    public enum Color
    {
        White,
        Black
    }

    public enum FigureType
    {
        Pawn,
        King
    }


    public class Figure : IFigure
    {
        protected Color _color;
        protected Position _position;
        protected FigureType _type;
        protected List<Position> _availablePosition;
        private bool _HasBeenMoved;

        // METODOS
        public Color GetColor()
        {
            return _color;
        }

        FigureType IFigure.GetType()
        {
            return _type;
        }

        public Position GetPosition()
        {
            return _position;
        }
        public void MoveToPosition(Position position)
        {
            _position = position;
        }
        public List<Position> GetAvailablePosition()
        {
            return _availablePosition;
        }

        public bool HasBeenMoved()
        {
            return _HasBeenMoved;
        }
    }
}
