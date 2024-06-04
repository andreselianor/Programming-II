namespace ndupcopy
{
    public static class View
    {
        private static string versionGraph1 = "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄";
        private static string versionGraph2 = "·························";
        private static string versionGraph3 = ".... n d u p c o p y ....";
        private static string versionGraph4 = ".... v . 1 _ 1 @ 2 4 ....";
        private static string versionGraph5 = "=========================";
        private static string versionGraph6 = ".........................";
        private static string versionGraph7 = "...s t e p _ 1 ..........";
        private static string versionGraph8 = "...l i s t _ u p ........";
        private static string versionGraph9 = "...s t e p _ 2 ..........";
        private static string versionGraph10 = "...d u p s _ d o w n ....";
        private static string versionGraph11 = "...s t e p _ 3 ..........";
        private static string versionGraph12 = "...u p _ c o p y ........";

        private static ConsoleColor WhiteColor = ConsoleColor.White;
        private static ConsoleColor BlueColor = ConsoleColor.DarkCyan;
        private static ConsoleColor GreenColor = ConsoleColor.Green;
        private static ConsoleColor BlackColor = ConsoleColor.Black;
        public static void DisplaySplashScreen()
        {
            string visualGraph1 = "╔═══════════════════════╗";
            string welcome =      "║ Welcome to 'NDUPCOPY' ║";
            string visualGraph2 = "╚═══════════════════════╝";

            Console.WriteLine(visualGraph1);
            Console.WriteLine(welcome);
            Console.WriteLine(visualGraph2);
            Console.WriteLine();
        }
        public static void DisplayAbstractMessage()
        {
            string version = " 'ndupcopy'  version 1.1 ";
            string abstractText = "This Program list up different files located at SOURCE FOLDER, " +
                "remove the duplicated ones, and copy the result list in a DESTINATION FOLDER.";
            string abstractText2 = "This version of ndupcopy can write files with or without original folder structure.";

            string abstractTextJustified = JustifyText(abstractText, 54);
            string abstractText2Justified = JustifyText(abstractText2, 54);
            Console.ForegroundColor = WhiteColor;
            Console.WriteLine(version);
            Console.ForegroundColor = BlueColor;
            Console.WriteLine(versionGraph1);
            Console.WriteLine(versionGraph3);
            Console.WriteLine(versionGraph4);
            Console.WriteLine();
            Console.ReadLine();
            Console.ForegroundColor = WhiteColor;
            Console.WriteLine(abstractTextJustified);
            Console.WriteLine();
            Console.WriteLine(abstractText2Justified);
            Console.ReadLine();
        }
        public static string DisplaySetOriginFolder()
        {
            string text = "Please, insert the complete path of the origin folder: ";
            Console.WriteLine(text);
            string userAnswer = Console.ReadLine();
            while (!RigthAnswerFolder(userAnswer))
            {
                DisplayErrorUserConsoleMessage();
                userAnswer = Console.ReadLine();
            }
            return userAnswer;
        }
        public static string DisplaySetTargetFolder()
        {
            string text = "Please, insert the complete path of target copy destination: ";
            Console.WriteLine(text);
            string userAnswer = Console.ReadLine();
            while (!RigthAnswerFolder(userAnswer))
            {
                DisplayErrorUserConsoleMessage();
                userAnswer = Console.ReadLine();
            }
            return userAnswer;
        }
        public static bool DisplayQuestionStructureFolder()
        {
            string text = "Do you want to keep the folder structure 'y/n'?";
            Console.WriteLine(text);
            string userAnswer = Console.ReadLine();
            while (!RigthAnswerStructureFolder(userAnswer))
            {
                DisplayErrorUserStructureMessage();
                userAnswer = Console.ReadLine();
            }
            Console.WriteLine();
            return userAnswer == "y" ? true : false;
        }

        public static void DisplayCopyingFiles()
        {
            string text = "Coping files, press any key to continue...";
            Console.WriteLine(text);
            Console.ReadLine();
        }
        public static void DisplayExitScreen()
        {
            string exitText1 = "The list of source files have been copied sucessfully.";
            string exitText2 = "Insert any key to terminate the program.";
            Console.WriteLine(exitText1);
            Console.WriteLine(exitText2);
            Console.ReadLine();
        }

        // MENSAJES DE ERROR
        public static void DisplayErrorMessage()
        {
            string text = "The program can't find source path of the files.\nPlease, check your parameters.";
            Console.WriteLine(text);
        }
        public static void DisplayErrorUserConsoleMessage()
        {
            string text = "You have entered an invalid option.";
            string text2 = "Please, check your destination path.";

            Console.WriteLine(text);
            Console.WriteLine(text2);
            Console.WriteLine();
        }
        public static void DisplayErrorUserStructureMessage()
        {
            string text = "Please type a valid option.";
            Console.WriteLine(text);
        }

        // MENSAJES GRAFICOS
        public static void DisplayFirstStepProcess()
        {
            Console.ForegroundColor = BlueColor;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(versionGraph7);
            Console.WriteLine(versionGraph8);
            Console.WriteLine(versionGraph6);
            Console.WriteLine();
            Console.ReadLine();
            Console.ForegroundColor = WhiteColor;
        }
        public static void DisplaySecondStepProcess()
        {
            Console.ForegroundColor = BlueColor;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(versionGraph9);
            Console.WriteLine(versionGraph10);
            Console.WriteLine(versionGraph6);
            Console.WriteLine();
            Console.ReadLine();
            Console.ForegroundColor = WhiteColor;
        }
        public static void DisplayThirdStepProcess()
        {
            Console.ForegroundColor = BlueColor;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(versionGraph11);
            Console.WriteLine(versionGraph12);
            Console.WriteLine(versionGraph6);
            Console.WriteLine();
            Console.ReadLine();
            Console.ForegroundColor = WhiteColor;
        }

        #region PRIVATE FUNCTIONS
        private static bool RigthAnswerFolder(string text)
        {
            if (text == null)
                return false;
            if (text.Length < 1)
                return false;
            if (text[0] != 'C')
                return false;
            else
                return true;
        }
        private static bool RigthAnswerStructureFolder(string text)
        {
            return (text == "y" || text == "n");
        }
        private static string JustifyText(string text, int numberCharacters)
        {
            string textResult = "";
            for (int i = 1; i <= text.Length; i++)
            {
                textResult += text[i - 1];
                if (i % numberCharacters == 0)
                    textResult += "\n";
            }
            return textResult;
        }
        #endregion

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