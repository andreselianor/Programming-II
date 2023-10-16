using System.Collections.Generic;

namespace Ajedrez
{
    public interface IFigure
    {
        Color GetColor();
        FigureType GetType();
        Position GetPosition();
        void MoveToPosition(Position position);
        List<Position> GetAvailablePosition();
        bool HasBeenMoved();
    }
}
