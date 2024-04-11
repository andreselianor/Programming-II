namespace ndupcopy
{
    public class Launcher
    {
        public static void LaunchApp(IUpCopy upCopy)
        {
            Controller c = new Controller();
            c.Launch(upCopy);
        }
    }
}
