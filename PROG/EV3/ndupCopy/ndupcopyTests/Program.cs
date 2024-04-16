namespace ndupcopyTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            byte[] result = File.ReadAllBytes(@"C:\Users\yveelilop\Desktop\GIT\Programming-II\PROG\EV3\ndupCopy\tests\TestOrigen\folder1\test1.txt");
            string path = "C:\\Users\\yveelilop\\Desktop\\GIT\\Programming-II\\PROG\\EV3\\ndupCopy\\salida\\prueba\\exit\\testsalida1.txt";
            string salida = "C:\\Users\\yveelilop\\Desktop\\GIT\\Programming-II\\PROG\\EV3\\ndupCopy\\salida\\prueba\\exit";
            Directory.CreateDirectory(salida);
            File.WriteAllBytes(path,result);
            */
            string origen = @"C:\Users\yveelilop\Desktop\GIT\Programming-II\PROG\EV3\ndupCopy\tests";
            var result = Directory.EnumerateDirectories(origen, "*.*", SearchOption.AllDirectories);
            foreach(string s in result)
            {
                Program.GetPath(s);
            }
            


        }

        public static void GetPath(string completePath)
        {
            string complete = completePath;
        }
    }
}