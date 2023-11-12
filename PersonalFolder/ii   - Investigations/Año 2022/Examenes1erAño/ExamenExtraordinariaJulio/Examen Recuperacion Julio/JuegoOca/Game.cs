using System.Collections.Generic;

namespace JuegoOca
{
    public class Game
    {
        private Board board = new Board();
        private List<Player> _listJugador = new List<Player>();
        private bool _playGame;

        // Funcion que inicia el juego
        public void InitGame(Board board)
        {
            board.CreatePlayers(4);
        }

        // Funcion que ejecuta el juego
        public void Execute(Board board)
        {
            while (_playGame)
            {
                board.PlayerMove();
                board.PlayerTranslation();
                board.PlayerRepeat();
                board.PlayerHalt();

                GameWin(board);
            }
        }

        // Funcion que indica si el juego ha terminado
        public void GameWin(Board board)
        {
            _playGame = board.PlayerHasArrived();
        }
    }
}
