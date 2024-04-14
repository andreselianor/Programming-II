namespace ndupcopy
{
    public class Controller
    {
        public static void Launch(IUpCopy upCopy)
        {
            Controller controller = new Controller();
            controller.Start(upCopy);
        }
        public void Start(IUpCopy upCopy)
        {
            //display
            DisplaySplashScreen();
            DisplayQuestionCopy();

            //program
            upCopy app = new upCopy();
            
            app.AddupFilesToList(new upFile());
            app.RemoveDuplicates();
            app.CopyupFiles();
        }

        #region FUNCIONES PRIVADAS
        private void DisplaySplashScreen()
        {
            UI.SplashScreen();
        }

        private void DisplayQuestionCopy()
        {
            UI.CopyQuestionScreen();
        }

        private void CopyOneFile()
        {
            string pathOrigen = "..\\..\\..\\..\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "..\\..\\..\\..\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
        }
        #endregion

        #region DOCUMENTACION
        /*
        - DisplaySplashScreen() : void
        Muestra por pantalla el 'splashScreen' de la aplicación.

        - DisplayQuestionCopy() : void
        Le pregunta al usuario si quiere ejecutar el programa de copia.

        - CopyOneFile() : void
        Copia el archivo relativo en la carpeta destino

        */
        #endregion
    }
}