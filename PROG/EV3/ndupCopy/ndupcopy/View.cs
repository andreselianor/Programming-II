namespace ndupcopy
{
    public static class View
    {
        public static void DisplaySplashScreen()
        {
            string welcome = "Welcome to NDUPCOPY";
            string welcomeGraph = "===================";
            Console.WriteLine(welcome);
            Console.WriteLine(welcomeGraph);
        }

        public static void DisplayQuestionScreen()
        {
            string questionText = "Do you want to copy ONE file?";
            Console.WriteLine(questionText);
            Console.WriteLine("Yes/No");
            Console.ReadLine();
        }

        public static void DisplayExitScreen()
        {
            string exitText = "Pulse cualquier tecla para salir de la aplicación...";
            Console.WriteLine(exitText);
            Console.ReadLine();
        }

        #region DOCUMENTACION
        /*
        // <see href="https://andreselianor.github.io/Documentation/MainApp/View/view.html">DOCUMENTACION ONLINE</see>

        - SplashScreen() : void
        Muestra la pantalla de bienvenida de la aplicación.

        - CopyQuestionScreen() : void
        Pregunta que archivos quiere copiar.

        */
        #endregion
    }
}