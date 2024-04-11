namespace ndupcopy
{
    public class upCopy : IUpCopy
    {
        private List<upFile> _filesList = new List<upFile>();
        private string _outputFolder = "";


        // CREAR UN ARCHIVO DE TIPO UPFILE
        public upFile CreateUpFile(string filePath, string folderPath)
        {
            upFile fileResult = new upFile();

            fileResult.CreateUpFile(filePath);
            fileResult.CreateFolderPath(folderPath);

            return fileResult;
        }
        public void SetOutputFolder(string path)
        {
            _outputFolder = path;
        }


        // funcionamiento del programa
        public void AddupFilesToList(upFile upFile)
        {
            if (upFile == null)
                throw new ArgumentNullException("El elemento es null");
            if (IsNotValid(upFile))
                return;
            else
                _filesList.Add(upFile);
        }
        public void RemoveDuplicates()
        {
            for (int i = 0; i < _filesList.Count - 1; i++)
            {
                for (int j = i + 1; j < _filesList.Count; j++)
                {
                    if (IsFileDuplicated(_filesList[i], _filesList[j]))
                        _filesList.RemoveAt(j--);
                }
            }
        }
        public void CopyupFiles()
        {
            CopyListToDestinationFolder();
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


        // FINALIZACION DEL PROGRAMA
        public void CopyListToDestinationFolder()
        {
            foreach(var file in _filesList)
            {
                File.Copy(file.Folder, _outputFolder);
            }
        }

    }

    #region DOCUMENTACION
    /*
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