namespace ndupcopy
{
    public class upCopy : INDupcopy
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

        // AÑADIR UN ARCHIVO TIPO UPFILE A LA LISTA DE VALIDOS

        public void AddUpFile(upFile upFile)
        {
            if (upFile == null)
                throw new ArgumentNullException("El archivo es null");

            if (ListContainsUpFile(upFile))
                return;
            else
                _filesList.Add(upFile);
        }

        // COMPROBAR QUE LOS ARCHIVOS SON UNICOS

        public bool ListContainsUpFile(upFile upfile)
        {
            if (upfile == null)
                throw new ArgumentNullException("El archivo es null");

            if (upFileWithSameSize(upfile))
                return true;

            if (upFileWithSameSHA256(upfile))
                return true;

            if (upFileWithSameHash(upfile))
                return true;

            if (upFileWithSameContent(upfile))
                return true;

            return false;
        }
        

        private bool upFileWithSameSize(upFile upfile)
        {
            for (int i = 0; i < _filesList.Count; i++)
            {
                if (_filesList[i].Size == upfile.Size)
                    return true;
            }
            return false;
        }

        private bool upFileWithSameSHA256(upFile upfile)
        {
            for (int i = 0; i < _filesList.Count; i++)
            {
                if (_filesList[i].Sha256 == upfile.Sha256)
                    return true;
            }
            return false;
        }
        private bool upFileWithSameHash(upFile upfile)
        {
            for (int i = 0; i < _filesList.Count; i++)
            {
                if (_filesList[i].Hash == upfile.Hash)
                    return true;
            }
            return false;
        }

        private bool upFileWithSameContent(upFile upfile)
        {
            for (int i = 0; i < _filesList.Count; i++)
            {
                if (_filesList[i].Content == upfile.Content)
                    return true;
            }
            return false;
        }    


        public void RemoveDuplicates()
        {

        }

        // FINALIZACION DEL PROGRAMA

        public void SetOutputFolder(string path)
        {
            _outputFolder = path;
        }
        public void CopyValidUpFiles()
        {

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