namespace Chess
{
    public class Game
    {
        private Board boardGame = new Board();
        private bool _winner;


        public void CreateBoard()
        {            
            boardGame.CreatePieces();
            while (!_winner)
            {
                boardGame.Execute();
                boardGame.IsWinner();
            }
        }        
    }
}
