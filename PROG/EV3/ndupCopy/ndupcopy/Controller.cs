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
            // * display Screen
            //View.DisplaySplashScreen();
            //View.DisplayQuestionScreen();


            // * app Run
            upCopy.SetOutputFolder(@"C:\Andres\DAM\Programming - II\PROG\EV3\salida1");
            upCopy.GetPathTargetFiles();
            upCopy.CopyUpFiles();


            // * app Terminating
            //View.DisplayExitScreen();
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