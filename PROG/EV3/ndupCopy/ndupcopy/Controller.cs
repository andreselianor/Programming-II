namespace ndupcopy
{
    public class Controller
    {
        public static void Launch(IUpCopy upCopy)
        {            
            Controller controller = new Controller();            
            controller.Start(upCopy);
        }

        private void Start(IUpCopy upCopy)
        {
            // display Screen
            View.DisplaySplashScreen();
            string originPath = View.DisplaySetOriginFolder();
            string targetPath = View.DisplaySetTargetFolder();
            View.DisplayCopyingFiles();


            // * app Run
            originPath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\UpFileTests";
            targetPath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\copiaPrueba";

            upCopy.SetOriginPath(originPath);
            upCopy.SetTargetPath(targetPath);
            upCopy.AddToListUpFiles();
            upCopy.RemoveDuplicateUpFiles();
            upCopy.CopyValidUpFiles();


            // * app Terminating
            View.DisplayExitScreen();
        }

        #region DOCUMENTACION
        /*
        // <see href="https://andreselianor.github.io/Documentation/MainApp/Controller/controller.html">DOCUMENTACION ONLINE</see>

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