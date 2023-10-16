namespace Ajedrez
{
    public class King : Figure
    {        
        public King(int x, int y, Color color)
        {
            _position.PositionX = x;
            _position.PositionY = y;
            _color = color;
        }
    }
}
