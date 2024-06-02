using System.Text;
using System.Security.Cryptography;

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
            try
            {
                var result = Directory.EnumerateFiles(_originFolder, "*.*", SearchOption.AllDirectories);
                foreach (string completePath in result)
                {
                    upFilePath filePath = new upFilePath();
                    filePath.SetOriginalPath(_originFolder);
                    filePath.SetTargetPath(_targetFolder);
                    filePath.SetFileName(completePath);
                    filePath.SetPartialPath(_originFolder, completePath);
                    filePath.SetCompleteTargetPath();

                    upFile upFile = new upFile(filePath, completePath);

                    if (IsNotValid(upFile))
                        return;

                    _controlList.Add(upFile);
                }
            }
            catch
            {
                View.DisplayErrorMessage();
                throw new Exception("Existe un error en la apertura de archivos.");
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
        public void CopyValidUpFiles(bool keepStructureFolder)
        {
            if (keepStructureFolder)
            {
                foreach (upFile file in _controlList)
                {
                    Directory.CreateDirectory(file.Path._targetPath + file.Path._partialPath);
                }

                foreach (upFile file in _controlList)
                {
                    FileStream fs = new FileStream(file.Path._completeTargetPath, FileMode.Create, FileAccess.Write);
                    fs.Write(file.Content, 0, file.Content.Length);
                    fs.Close();
                }
            }
            else
            {
                foreach (upFile file in _controlList)
                {
                    string targetPathWithoutStructure = file.Path._targetPath + "\\" + file.Path._fileName;
                    FileStream fs = new FileStream(targetPathWithoutStructure, FileMode.Create, FileAccess.Write);
                    fs.Write(file.Content, 0, file.Content.Length);
                    fs.Close();
                }
            }            
        }

        #region FUNCIONES PRIVADAS
        private bool IsFileDuplicated(upFile upfileOriginal, upFile upfileTarget)
        {
            if (!upFileWithSameSHA256(upfileOriginal, upfileTarget))    // 32 bytes
                return false;
            if (!upFileWithSameHash(upfileOriginal, upfileTarget))      // 4 bytes
                return false; 
            if (!upFileWithSameSize(upfileOriginal, upfileTarget))
                return false;
            if (!upFileWithSameContent(upfileOriginal, upfileTarget))
                return false;
            return true;
        }
        private static bool upFileWithSameSHA256(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Sha256.Equals(upfileTarget.Sha256));
        }
        private static bool upFileWithSameHash(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Hash.Equals(upfileTarget.Hash));
        }
        private static bool upFileWithSameSize(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Size.Equals(upfileTarget.Size));
        }
        private static bool upFileWithSameContent(upFile upfileOriginal, upFile upfileTarget)
        {
            return (upfileOriginal.Content.Equals(upfileTarget.Content));
        }
        public static string GetSHA256(byte[] input)
        {
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            StringBuilder sb = new StringBuilder();
            byte[] stream = sha256.ComputeHash(input);
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }
        private bool IsNotValid(upFile upfile)
        {
            if (upfile == null)
                return true;
            if (upfile.Size < 0)
                return true;
            return false;
        }
        #endregion
    }

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpCopy/UpCopy.html">DOCUMENTACION ONLINE</see>

    - controlList : List<upFile>
    Lista de archivos de tipo 'upFile' dentro de una coleccion tipo 'List'. Aquí se encuentran todos los archivos listados en 
    la carpeta origen.

    - originFolder : string
    String con la ruta de la carpeta origen de archivos.

    - targetFolder : string
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