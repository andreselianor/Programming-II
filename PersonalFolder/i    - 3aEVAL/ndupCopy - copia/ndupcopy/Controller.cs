namespace ndupcopy
{
    public class Controller
    {
        public static void Launch(IUpCopy upCopy, string[] args)
        {
            Controller controller = new Controller();
            controller.Start(upCopy, args);
        }

        private void Start(IUpCopy upCopy, string[] args)
        {
            // * display SplashScreen
            View.DisplaySplashScreen();
            View.DisplayAbstractMessage();
            View.DisplayFirstStepProcess();

            // * La carpeta ORIGEN se encuentra indicada en 'args'.
            // * La carpeta DESTINO se introduce por consola.
            string targetPath = View.DisplaySetTargetFolder();
            View.DisplaySecondStepProcess();

            // * La siguiente linea tiene efectos para debuggear.
            // string targetPath = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\TestFolder1\carpetaDestino";

            // * Se le pregunta al usuario si quiere mantener la jerarquia de carpetas del archivo.
            bool keepStructureFolder = View.DisplayQuestionStructureFolder();

            // * app Run
            foreach (string sourcePath in args)
            {
                upCopy.SetOriginPath(sourcePath);
                upCopy.SetTargetPath(targetPath);
                upCopy.AddToListUpFiles();
                upCopy.RemoveDuplicateUpFiles();
                upCopy.CopyValidUpFiles(keepStructureFolder);
            }
            View.DisplayCopyingFiles();
            View.DisplayThirdStepProcess();

            // * app Terminating
            View.DisplayExitScreen();
        }

        #region DOCUMENTACION
        /*
        // <see href="https://andreselianor.github.io/Documentation/MainApp/Controller/controller.html">DOCUMENTACION ONLINE</see>

        ~ Launch() : void
        Crea un objeto de tipo controlador y ejecuta la función Start, que inicia la copia de archivos.
        Recibe por parametros las direcciones de las carpetas de origen.

        - Start(IUpcopy, args) : void
        Inicia el proceso de listado, eliminacion de duplicados y copiado de archivos, en las carpetas que se le indican
        por parametros.
        
        ~ DisplaySplashScreen() : void
        Muestra la pantalla inicial de la aplicación.

        ~ DisplaySetTargetFolder() : string
        Le pregunta al usuario cual es la carpeta destino de la copia de archivos.

        ~ DisplayKeepFolderStructure() : void
        Le pregunta al usuario si quiere mantener la estructura de carpetas.

        ~ DisplayCopyingFiles() : void
        Muestra el proceso de copia de los archivos.

        ~ DisplayExitScreen() : void
        Muestra el mensaje de despedida.

        */
        #endregion
    }
}