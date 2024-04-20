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

        public upFilePath Path => _path;
        public int Date => _date;
        public int Size => _size;
        public int Hash => _hash;
        public int Sha256 => _SHA256;
        


        public upFile() { }
        public upFile(upFilePath path, string filePath)
        {
            _path = path;
            _file = File.ReadAllBytes(filePath);

            _size = _file.Length;
            _hash = _file.GetHashCode();
        }

    }

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpFile/UpFile.html">DOCUMENTACION ONLINE</see>

    [#] upFile ()
    Crea un archivo 'upFile' con atributos vacios.

    [#] upFile (upfilePath, filePath)
    Crea un archivo 'upFile' con una referencia a sus direcciones y el contenido del archivo.

    */
    #endregion
}