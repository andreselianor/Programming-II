namespace Classes
{
    public class ChessUtils
    {
        private ChessPosition _position = new ChessPosition();

        public static bool CanKnightMoveTo(ChessFigure figure, List<ChessFigure> list, int targetX, int targetY)
        {
            if (targetX == figure.X - 2 && (targetY == figure.Y + 1 || targetY == figure.Y - 1))
                return true;

            if (targetX == figure.X - 1 && (targetY == figure.Y + 2 || targetY == figure.Y - 2))
                return true;

            if (targetX == figure.X + 2 && (targetY == figure.Y + 1 || targetY == figure.Y - 1))
                return true;

            if (targetX == figure.X + 1 && (targetY == figure.Y + 2 || targetY == figure.Y - 2))
                return true;
            
            if (IsFigureAt(targetX, targetY, list))
                return false;

            if (!IsOnTheTable(targetX, targetY))
                return false;

            return false;
        }

        public static List<ChessPosition> GetAvailablePositionsStatic(ChessFigure figure)
        {
            List<ChessPosition> listAvailable = new List<ChessPosition>();

            ChessPosition position = new ChessPosition();

            position.SetPosition(figure.X - 2, figure.Y + 1);
            listAvailable.Add(position);

            position.SetPosition(figure.X - 1, figure.Y + 2);
            listAvailable.Add(position);

            position.SetPosition(figure.X + 2, figure.Y + 1);
            listAvailable.Add(position);

            position.SetPosition(figure.X + 1, figure.Y + 2);
            listAvailable.Add(position);

            position.SetPosition(figure.X - 2, figure.Y - 1);
            listAvailable.Add(position);

            position.SetPosition(figure.X - 1, figure.Y - 2);
            listAvailable.Add(position);

            position.SetPosition(figure.X + 2, figure.Y - 1);
            listAvailable.Add(position);

            position.SetPosition(figure.X + 1, figure.Y - 1);
            listAvailable.Add(position);

            return listAvailable;
        }

        public void GetAvailablePositions(ChessFigure figure)
        {
            _position.SetPosition(figure.X - 2, figure.Y + 1);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X - 1, figure.Y + 2);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X + 2, figure.Y + 1);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X + 1, figure.Y + 2);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X - 2, figure.Y - 1);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X - 1, figure.Y - 2);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X + 2, figure.Y - 1);
            figure.ListAvailablePosition.Add(_position);

            _position.SetPosition(figure.X + 1, figure.Y - 1);
            figure.ListAvailablePosition.Add(_position);
        }

        public static bool IsFigureAt(int x, int y, List<ChessFigure> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].X == x && list[i].Y == y)
                    return true;
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

        public static int GetFigureCount(List<ChessFigure> list)
        {
            return list.Count;
        }

        public static bool IsOnTheTable(int x, int y) => (x > 0 && x < 9 && y > 0 && y < 9);
    }
}
