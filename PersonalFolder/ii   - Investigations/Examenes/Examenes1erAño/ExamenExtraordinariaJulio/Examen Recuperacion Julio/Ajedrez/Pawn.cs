using System.Collections.Generic;

namespace Ajedrez
{
    public class Pawn : Figure
    {
        public Pawn(int x, int y, Color color)
        {
            _position.PositionX = x;
            _position.PositionY = y;
            _color = color;
        }

        public void SetAvailablePositions()
        {
            
            Position availablePosition = new Position();
            availablePosition.PositionX = _position.PositionX;
            availablePosition.PositionY = _position.PositionY + 1;

            _availablePosition.Add(availablePosition);
        }

        public List<Position> MovePawn()
        {
            return _availablePosition;
        }
    }
}
