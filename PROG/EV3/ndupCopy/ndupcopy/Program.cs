namespace ndupcopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUpCopy upCopy = new upCopy();
            Controller.Launch(upCopy);

            #region PRUEBAS DE PROGRAMADOR
            /*
            
            --TEST 01
            string pathOrigen = "C:\\Andres\\DAM\\Programming-II\\PROG\\EV3\\ndupCopy\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "C:\\Andres\\DAM\\Programming-II\\PROG\\EV3\\ndupCopy\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
            
            */

            /*
             
            --TEST 02
            string pathOrigen = "..\\..\\..\\..\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "..\\..\\..\\..\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);

            */
            #endregion
        }
    }
    /* DOCUMENTACION DEL PROGRAMA*/
    // <see href="https://andreselianor.github.io/Documentation/">DOCUMENTACION ONLINE</see>
}