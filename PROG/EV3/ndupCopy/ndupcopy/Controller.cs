namespace ndupcopy
{
    public class Controller
    {
        public void Launch()
        {
            DisplaySplashScreen();
            DisplayQuestionCopy();

            CopyOneFile();
        }

        private void DisplaySplashScreen()
        {
            UI.SplashScreen();
        }

        private void DisplayQuestionCopy()
        {
            UI.CopyFile();
        }

        private void CopyOneFile()
        {
            string pathOrigen = "..\\..\\..\\..\\filesTest\\test1.txt";
            byte[] file = File.ReadAllBytes(pathOrigen);

            string pathOutput = "..\\..\\..\\..\\filesTest\\outputTest\\outTest1.txt";
            File.WriteAllBytes(pathOutput, file);
        }
    }
}