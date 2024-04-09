namespace ndupcopy
{
    public static class UI
    {
        public static void SplashScreen()
        {
            string welcome = "Welcome to NDUPCOPY";
            string welcomeGraph = "===================";
            Console.WriteLine(welcome);
            Console.WriteLine(welcomeGraph);
        }

        public static void CopyFile()
        {
            string question = "Do you want to copy ONE file?";
            Console.WriteLine(question);
            Console.WriteLine("Yes/No");
            Console.ReadLine();
        }
    }
}