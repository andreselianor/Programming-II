namespace ndupcopyTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string origen = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\UpFileTests";
            string destino = @"C:\Andres\DAM\Programming-II\PROG\EV3\ndupCopy\ndupcopyTests\copia1";

            var result = Directory.EnumerateDirectories(origen, "*.*", SearchOption.AllDirectories);
            foreach(string s in result)
            {
                CreateDirectories(s, destino, origen);
            }

            var result2 = Directory.EnumerateFiles(origen, "*.*", SearchOption.AllDirectories);
            foreach(string s2 in result2)
            {
                CreateFile(s2, destino, origen);
            }
        }

        public static void CreateDirectories(string completePath, string destino, string origen)
        {
            string complete = completePath;
            int completeint = completePath.Length;

            string original = origen;
            int originalint = original.Length;

            string result = complete.Substring(originalint);
            Directory.CreateDirectory(destino + result);
        }
        public static void CreateFile(string completePath, string destino, string origen)
        {
            string complete = completePath;
            int completeint = completePath.Length;

            string original = origen;
            int originalint = original.Length;

            string relativa = complete.Substring(originalint);

            byte[] result = File.ReadAllBytes(completePath);
            File.WriteAllBytes(destino + relativa, result);
        }
    }
}