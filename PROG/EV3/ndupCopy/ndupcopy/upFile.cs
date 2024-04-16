namespace ndupcopy
{
    public class upFile
    {
        private byte[] _file = Array.Empty<byte>();
        private string _folder = "";

        private int _date;
        private int _size;
        private int _hash;
        private int _SHA256;

        public string Folder => _folder;
        public int Date => _date;
        public int Size => _size;
        public int Hash => _hash;
        public int Sha256 => _SHA256;
        public byte[] Content => _file;


        public upFile() { }
        public upFile(string filePath)
        {
            _file = File.ReadAllBytes(filePath);
        }
        public upFile(string filePath, string folder)
        {
            _file = File.ReadAllBytes(filePath);
            _folder = folder;
        }

        public static void GetPath(string path, string userFolder, out string relativePath, out string fileName)
        {            
            int userFolderCount = userFolder.Length;
            string completeRelative = path.Substring(userFolderCount);


            int fileNameCount = 0;
            for (int i = completeRelative.Length - 1; i > 0; i--)
            {
                if (completeRelative[i] == '\\')
                    break;
                fileNameCount++;
            }
            fileName = completeRelative.Substring(completeRelative.Length - fileNameCount);
        }
    }

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpFile/UpFile.html">DOCUMENTACION ONLINE</see>

    [#] upFile
    Crea un archivo 'upFile' de tipo array de byte 'byte[]'

    + CreateUpFile (filePath) : void
    El atributo _file se compone de el archivo que le indicamos en la ruta.

    + CreateFolderPath (folderPath) : void
    Se crea un string con la dirección de la ruta de la carpeta contenedora.

    */
    #endregion
}