namespace ndupcopy
{
    public class upFile
    {
        private byte[] _file = Array.Empty<byte>();

        private upFilePath _path;
        private DateTime _date;
        private int _size;
        private int _hash;
        private string _SHA256;


        public byte[] Content => _file;
        public upFilePath Path => _path;
        public DateTime Date => _date;
        public int Size => _size;
        public int Hash => _hash;
        public string Sha256 => _SHA256;


        public upFile() { }
        public upFile(upFilePath path, string filePath)
        {
            _path = path;
            _file = CreateFile(filePath);

            _size = _file.Length;
            _date = File.GetCreationTime(filePath);

            _hash = _file.GetHashCode();
            _SHA256 = upCopy.GetSHA256(_file);
        }


        private byte[] CreateFile(string filePath)
        {
            FileStream fsSource = new FileStream(filePath, FileMode.Open);
            byte[] result = new byte[fsSource.Length + 1];

            int byteContent = fsSource.ReadByte();
            int count = 0;
            while(byteContent != -1)
            {
                result[count] = Convert.ToByte(byteContent);
                count++;
                byteContent = fsSource.ReadByte();
            }
            
            return result;
        }
    }

    #region DOCUMENTACION
    /*
    // <see href="https://andreselianor.github.io/Documentation/MainApp/UpFile/UpFile.html">DOCUMENTACION ONLINE</see>

    [#] upFile ()
    Crea un archivo 'upFile' con atributos vacios.

    [#] upFile (upfilePath, filePath)
    Crea un archivo 'upFile' con una referencia a sus direcciones y el contenido del archivo.

    - file: byte[]
    Contiene el array de bytes con el contenido del archivo.

    - path : upFilePath
    Contiene una referencia a la clase 'upFilePath' donde se almacenan las direcciones de las distintas carpetas.

    - date : int
    Almacena la fecha de creación del archivo.

    - size : int
    Almacena el tamaño en bytes del archivo.

    - hash : int
    Contiene el numero hash del archivo.

    - SHA256 : string
    Contiene el archivo codificado en una cadena de texto, según el algoritmo SHA256.
    */
    #endregion
}