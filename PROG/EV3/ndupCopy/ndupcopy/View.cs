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
        public static void DisplayErrorMessage()
        {
            string text = "The program can't find source path of the files.\nPlease, check your parameters.";
            Console.WriteLine(text);
        }

        public static void DisplayExitScreen()
        {
            string exitText1 = "The list of source files have been copied sucessfully.";
            string exitText2 = "Please, insert any key to finish the program.";
            Console.WriteLine(exitText1);
            Console.WriteLine(exitText2);
            Console.ReadLine();
        }

        #region DOCUMENTACION
        /*
        // <see href="https://andreselianor.github.io/Documentation/MainApp/View/view.html">DOCUMENTACION ONLINE</see>

        ~ DisplaySplashScreen() : void
        Muestra por pantalla el 'splashScreen' de la aplicación.

        ~ DisplaySetOriginFolder() : string
        Una función que establece la carpeta de origen.

        ~ DisplaySetTargetFolder : string
        Una función que establece la carpeta de destino.

        ~ DisplayCopyingFiles() : void
        Muestra por pantalla la pantalla de carga y copiado de archivos.

        ~ DisplayExitScreen() : void
        Muestra por pantalla el mensaje de salida del programa.
        */
        #endregion
    }
}