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
            game.ExecuteRound();
        }
    }
}