namespace Chess
{
    public class Game
    {
        private Board _boardGame = new Board();
        private bool _winner;

        public void Play()
        {
            _boardGame.CreatePieces();

            while (!_winner)
            {
                _boardGame.Execute();
                _boardGame.IsWinner();
            }
        }
    }
}
