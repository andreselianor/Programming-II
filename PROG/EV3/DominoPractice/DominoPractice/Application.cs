namespace DominoPractice
{
    public class Application
    {
        public static void Launch(IGame game)
        {
            Application app = new Application();
            app.StartGame(game);
        }

        public void StartGame(IGame game)
        {
            game.InitGame();

            while (game.ArePlayersPlaying())
            {
                game.InitRound(game);
            }

            UI.Winner(game.WinnerPlayer());
        }
    }
}