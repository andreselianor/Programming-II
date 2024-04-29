namespace ExamenRugby
{
    public class Ball
    {
        private Position _position = new Position();

        public Position Position => _position;

        public void SetInitialPosition(int widthBoard, int heightBoard)
        {
            int positionX = Utils.GetRandomInt(0, widthBoard);
            int positionY = Utils.GetRandomInt(0, heightBoard);

            _position = new Position(positionX, positionY);
        }

        public void SetBallToPosition(int X, int Y)
        {
            _position.X = X;
            _position.Y = Y;
        }
    }
}