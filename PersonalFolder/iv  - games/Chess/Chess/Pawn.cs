namespace Chess
{
    public class Pawn : Figure
    {
        private List<Position> _availableMovements = new List<Position>();

        public Pawn(int x, int y, ColorType color, FigureType figure) : base(x,y,color,figure)
        {
            
        }

        public void AvailableMovement()
        {
            _availableMovements.Clear();
        }

        public override void MovePawn()
        {

        }
    }
}
