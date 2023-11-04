namespace Chess
{
    public class Position
    {
        private int _x;
        private int _y;

        public int X => _x;
        public int Y => _y;

        public void SetPosition(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
