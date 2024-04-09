namespace ndupcopy
{
    public static class UI
    {
        public static void SplashScreen()
        {
            string welcome = "Welcome to NDUPCOPY";
            string welcomeGraph = "===================";
            Console.WriteLine(welcome);
            Console.WriteLine(welcomeGraph);
        }

        public static void CopyQuestionScreen()
        {
            string question = "Do you want to copy ONE file?";
            Console.WriteLine(question);
            Console.WriteLine("Yes/No");
            Console.ReadLine();
        }

        #region DOCUMENTACION
        /*
        - SplashScreen() : void
        Muestra la pantalla de bienvenida de la aplicación.

        - CopyQuestionScreen() : void
        Pregunta que archivos quiere copiar.

        */
        #endregion
    }
}