namespace ndupcopy
{
    public class upFile
    {
        private byte[] _file = Array.Empty<byte>();

        private upFilePath _path;

        private int _date;
        private int _size;
        private int _hash;
        private int _SHA256;


        public byte[] Content => _file;
        public int Date => _date;
        public int Size => _size;
        public int Hash => _hash;
        public int Sha256 => _SHA256;


        public upFile() { }
        public upFile(upFilePath path)
        {
            _path = path;
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