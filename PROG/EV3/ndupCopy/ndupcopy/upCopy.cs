namespace ndupcopy
{
    public class upCopy : IUpCopy
    {
        private List<upFile> _controlList = new List<upFile>();
        private string _originFolder = "";
        private string _targetFolder = "";

        public void SetOriginPath(string path)
        {
            _originFolder = path;
        }
        public void SetTargetPath(string path)
        {
            _targetFolder = path;
        }
        public void AddToListUpFiles()
        {
            var result = Directory.EnumerateFiles(_originFolder, "*.*", SearchOption.AllDirectories);
            foreach (string completePath in result)
            {
                upFilePath filePaths = new upFilePath();
                filePaths.SetOriginalPath(_originFolder);
                filePaths.SetTargetPath(_targetFolder);
                filePaths.SetFileName(completePath);
                filePaths.SetPartialPath(_originFolder, completePath);
                filePaths.SetCompleteTargetPath();

                upFile upFile = new upFile(filePaths, completePath);

                _controlList.Add(upFile);
            }
        }
        public void RemoveDuplicateUpFiles()
        {
            foreach (upFile file in _controlList)
            {
                Directory.CreateDirectory(file.Path._targetPath + file.Path._partialPath);

            }
        }
        public void CopyValidUpFiles()
        {
            
            foreach (upFile file in _controlList)
            {

                File.WriteAllBytes(file.Path._completeTargetPath, file.Content);
            }
        }






        public void AddUpFilesToControlList(upFile upFile)
        {
            if (upFile == null)
                throw new ArgumentNullException("El elemento es null");
            if (IsNotValid(upFile))
                return;
            else
                _controlList.Add(upFile);
        }
        public void RemoveDuplicates()
        {
            for (int i = 0; i < _controlList.Count - 1; i++)
            {
                for (int j = i + 1; j < _controlList.Count; j++)
                {
                    if (IsFileDuplicated(_controlList[i], _controlList[j]))
                        _controlList.RemoveAt(j--);
                }
            }
        }

        #region FUNCIONES PRIVADAS
        private bool IsFileDuplicated(upFile upfileOriginal, upFile upfileTarget)
        {
            if (upFileWithSameSize(upfileOriginal, upfileTarget))
                return true;
            if (upFileWithSameSHA256(upfileOriginal, upfileTarget))
                return true;
            if (upFileWithSameHash(upfileOriginal, upfileTarget))
                return true;
            if (upFileWithSameContent(upfileOriginal, upfileTarget))
                return true;

            return false;
        }
        private static bool upFileWithSameSize(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Size == upfileTarget.Size);
        }
        private static bool upFileWithSameSHA256(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Sha256 == upfileTarget.Sha256);
        }
        private static bool upFileWithSameHash(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Hash == upfileTarget.Hash);
        }
        private static bool upFileWithSameContent(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Content == upfileTarget.Content);
        }
        private bool IsNotValid(upFile upfile)
        {
            if (upfile == null)
                return true;
            return false;
        }
        #endregion
    }

    /*
     * 
     * 
        public void CopyOneFile()
        {
            string pathOrigen = "..\\..\\..\\..\\testingApp\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "..\\..\\..\\..\\testingApp\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
        }
        public void CopyAllInFolder()
        {
            string pathFolder = "..\\..\\..\\..\\testingApp\\filesTest";
            string pathFiles = "*.*";

            var result = Directory.EnumerateFiles(pathFolder, pathFiles, SearchOption.AllDirectories);

            foreach (string sending in result)
            {
                string pathOrigen = sending;
                byte[] file = File.ReadAllBytes(pathOrigen);
                string fileName = sending.Substring(33);

                string pathOutput = "..\\..\\..\\..\\testingApp\\outputTest\\" + fileName;
                File.WriteAllBytes(pathOutput, file);
            }
        }
     * */

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpCopy/UpCopy.html">DOCUMENTACION ONLINE</see>

    - _filesList : List<upFile>
    Lista de archivos de tipo 'up' dentro de una coleccion 'Set' donde no existen repeticiones de archivos.

    _outputFolder : string
    String con la ruta de la carpeta donde se escriben los archivos validos.


    - AddUpFile(Upfile) : void
    Añade un archivo a la lista de validos.

    - SetOutputFolder (path) : void
    Indica la direccion de la ruta del directorio de salida.

    */
    #endregion
}