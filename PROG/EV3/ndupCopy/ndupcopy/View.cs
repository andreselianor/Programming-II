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
        public static string DisplaySetOriginFolder()
        {
            string text = "Please, insert the complete path of the origin folder: ";
            Console.WriteLine(text);
            string userAnswer = Console.ReadLine();
            return userAnswer;
        }
        public static string DisplaySetTargetFolder()
        {
            string text = "Please, insert the complete path of target copy destination: ";
            Console.WriteLine(text);
            string userAnswer = Console.ReadLine();
            return userAnswer;
        }
        public static void DisplayCopyingFiles()
        {
            string text = "Coping files, please stand by...";
            Console.WriteLine(text);
        }

        public static void DisplayExitScreen()
        {
            string exitText1 = "La copia se ha realizado con éxito.";
            string exitText2 = "Pulse cualquier tecla para salir de la aplicación...";
            Console.WriteLine(exitText1);
            Console.WriteLine(exitText2);
            Console.ReadLine();
        }

        #region DOCUMENTACION
        /*
        // <see href="https://andreselianor.github.io/Documentation/MainApp/View/view.html">DOCUMENTACION ONLINE</see>

        - DisplaySplashScreen() : void
        Muestra la pantalla de bienvenida de la aplicación.

        - DisplaySetTargetFolder() : void
        Pregunta la ruta destino de la copia de archivos.

        - DisplayCopyingFiles() : void
        Informa al usuario que la copia de los archivos se está ejecutando.

        - DisplayExitScreen() : void
        Muestra la pantalla de salida de la aplicación.
        */
        #endregion
    }
}