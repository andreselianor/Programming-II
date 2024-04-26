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

    - _sourcePath : string;
    - _targetPath : string;
    - _partialPath : string;
    - _completeTargetPath : string;
    - _fileName : string;

    Name => _fileName;

    [#]upFilePath() { }

    + SetOriginalPath(originalPath) : void
    Descripcion

    + SetTargetPath(targetPath) : void
    Descripcion

    + SetPartialPath(originalPath, completePath) : void
    Descripcion

    + SetFileName(completeOriginPath) : void
    Descripcion

    + SetCompleteTargetPath() : void
    Descripcion
    */
    #endregion
}