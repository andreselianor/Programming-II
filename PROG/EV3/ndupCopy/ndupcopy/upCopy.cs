﻿namespace ndupcopy
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
            for (int i = 0; i < _controlList.Count - 1; i++)
            {
                for (int j = i + 1; j < _controlList.Count; j++)
                {
                    if (IsFileDuplicated(_controlList[i], _controlList[j]))
                        _controlList.RemoveAt(j--);
                }
            }
        }
        public void CopyValidUpFiles()
        {
            foreach (upFile file in _controlList)
            {
                Directory.CreateDirectory(file.Path._targetPath + file.Path._partialPath);
            }

            foreach (upFile file in _controlList)
            {
                File.WriteAllBytes(file.Path._completeTargetPath, file.Content);
            }
        }

        #region FUNCIONES PRIVADAS
        private bool IsFileDuplicated(upFile upfileOriginal, upFile upfileTarget)
        {
            if (upFileWithSameName(upfileOriginal, upfileTarget))
                return true;

            /*
            if (upFileWithSameSize(upfileOriginal, upfileTarget))
                return true;
            if (upFileWithSameSHA256(upfileOriginal, upfileTarget))
                return true;
            if (upFileWithSameHash(upfileOriginal, upfileTarget))
                return true;
            if (upFileWithSameContent(upfileOriginal, upfileTarget))
                return true;
            */

            return false;
        }
        private static bool upFileWithSameName(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Path.Name == upfileTarget.Path.Name);
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

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpCopy/UpCopy.html">DOCUMENTACION ONLINE</see>

    - _controlList : List<upFile>
    Lista de archivos de tipo 'upFile' dentro de una coleccion tipo 'List'. Aquí se encuentran todos los archivos listados en 
    la carpeta origen.

    _originFolder : string
    String con la ruta de la carpeta origen de archivos.

    _targetFolder : string
    String con la ruta de la carpeta destino de archivos.

    + SetOriginPath(originPath) : void
    Establece el atributo que almacena la direccion de la carpeta original.

    + SetTargetPath(targetPath) : void
    Estblece el atributo que almacena la direccion de la carpeta destino.

    + AddToListUpFiles() : void
    Funcion que añade a la lista de control de archivos 'upFile' todos los archivos contenidos en la carpeta origen.

    + RemoveDuplicateUpFiles() : void
    Funcion que elimina los archivos duplicados.
    
    + CopyValidUpFiles() : void
    Funcion que copia en la carpeta origen, todos los archivos que se encuentran en la lista de control.

    */
    #endregion
}