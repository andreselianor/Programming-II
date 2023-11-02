namespace Classes
{
    public class ChessUtils
    {

        public static bool CanKnightMoveTo(ChessFigure figure, List<ChessFigure> list, int targetX, int targetY)
        {
            return true;
        }

        public static bool IsFigureAt(int x, int y, List<ChessFigure> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                return (list[i].X == x && list[i].Y == y);
            }
            return false;
        }

        public static ChessFigure? GetFigureAt(int x, int y, List<ChessFigure> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (IsFigureAt(x, y, list))
                {
                    return list[i];
                }
            }
            return null;
        }

        public static bool IsOnTheTable(int x, int y)
        {
            return (x > 0 && x < 9 && y > 0 && y < 9);
        }
    }
}
