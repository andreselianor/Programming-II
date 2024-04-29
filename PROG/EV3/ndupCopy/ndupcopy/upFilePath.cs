namespace ndupcopy
{
    public class upFilePath
    {
        public string _sourcePath = "";
        public string _targetPath = "";
        public string _partialPath = "";
        public string _completeTargetPath = "";
        public string _fileName = "";

        public string Name => _fileName;

        public upFilePath() { }

        public void SetOriginalPath(string originalPath)
        {
            _sourcePath = originalPath;
        }

        public void SetTargetPath(string targetPath)
        {
            _targetPath = targetPath;
        }

        public void SetPartialPath(string originalPath, string completePath)
        {
            int originalPathLength = originalPath.Length;
            string partialWithFileName = completePath.Substring(originalPathLength);

            int trimFileName = partialWithFileName.Length - _fileName.Length;
            string partialWithoutFileName = partialWithFileName.Substring(0, trimFileName);

            _partialPath = partialWithoutFileName;
        }

        public void SetFileName(string completeOriginPath)
        {
            string fileName;
            int fileNameCount = 0;
            for (int i = completeOriginPath.Length - 1; i > 0; i--)
            {
                if (completeOriginPath[i] == '\\')
                    break;
                fileNameCount++;
            }

            fileName = completeOriginPath.Substring(completeOriginPath.Length - fileNameCount);
            _fileName = fileName;
        }

        public void SetCompleteTargetPath()
        {
            _completeTargetPath = _targetPath + _partialPath + _fileName;
        }
    }

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpFilePath/UpFilePath.html">DOCUMENTACION ONLINE</see>

    - _sourcePath : string
    String que contiene la ruta origen del archivo.

    - _targetPath : string
    String que contiene la ruta destino del archivo.

    - _partialPath : string
    String que contiene la ruta parcial del archivo.

    - _completeTargetPath : string
    String que contiene la ruta completa del archivo.

    - _fileName : string
    String que contiene el nombre con la extensión del archivo.

    [·]Name => _fileName;
    Devuelve el nombre del archivo.

    [#]upFilePath() { }

    + SetOriginalPath(originalPath) : void
    Establece el string que contiene la ruta del archivo original.

    + SetTargetPath(targetPath) : void
    Establece el atributo que contiene la ruta de destino de la copia.

    + SetPartialPath(originalPath, completePath) : void
    Establece el atributo que contiene la ruta parcial del archivo.

    + SetFileName(completeOriginPath) : void
    Establece el atributo que contiene el nombre con la extension del archivo.

    + SetCompleteTargetPath() : void
    Establece la ruta completa del archivo, con la ruta parcial, la carpeta contenedora y el archivo.
    */
    #endregion
}