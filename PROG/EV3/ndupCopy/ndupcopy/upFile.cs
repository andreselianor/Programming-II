namespace ndupcopy
{
    public class upFile
    {
        private byte[] _file = Array.Empty<byte>();
        private string _folderPath = "";

        private int _date;
        private int _size;
        private int _hash;
        private int _SHA256;

        public string Folder => _folderPath;
        public int Date => _date;
        public int Size => _size;
        public int Hash => _hash;
        public int Sha256 => _SHA256;
        public byte[] Content => _file;


        public upFile() { }
        public upFile(string filePath, string folderPath)
        {
            _file = File.ReadAllBytes(filePath);
            _folderPath = folderPath;
        }


        public void CreateUpFile(string filePath)
        {
            _file = File.ReadAllBytes(filePath);
        }

        public void CreateFolderPath(string folderPath)
        {
            _folderPath = folderPath;
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