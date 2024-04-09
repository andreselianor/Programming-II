namespace ndupcopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            TEST 01
            string pathOrigen = "C:\\Andres\\DAM\\Programming-II\\PROG\\EV3\\ndupCopy\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "C:\\Andres\\DAM\\Programming-II\\PROG\\EV3\\ndupCopy\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
            */

            /*TEST 02
            string pathOrigen = "..\\..\\..\\..\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "..\\..\\..\\..\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
            */

            Controller controllerApp = new Controller();
            controllerApp.Launch();
        }
    }
}
