namespace ExamenRugby
{
    public class Controller
    {
        public static void Launch(IMatch game)
        {
            Controller controller = new Controller();
            controller.Start(game);
        }

        public void Start(IMatch game)
        {
            UI.DisplaySplashScreen();

            game.Init();
            for(int i = 0; i < 1000; i++)
            {
                game.ExecuteRound(game);
            }
            Team winnerTeam = game.Winner();

            UI.DisplayExitScreen(winnerTeam.ToString());
        }
    }
}