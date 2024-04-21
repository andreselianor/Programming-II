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

    - file: byte[]
    Contiene el array de bytes con el contenido del archivo.

    - path : upFilePath
    Contiene una referencia a la clase 'upFilePath' donde se almacenan las direcciones de las distintas carpetas.

    - date : int
    Almacena la fecha de creación del archivo.

    - size : int
    Almacena el tamaño en bytes del archivo.

    - hash : int
    Contiene el numero hash del archivo.

    - SHA256 : string
    Contiene el archivo codificado en una cadena de texto, según el algoritmo SHA256.
    */
    #endregion
}