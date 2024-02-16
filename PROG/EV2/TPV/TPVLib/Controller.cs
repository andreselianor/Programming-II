using static System.Net.Mime.MediaTypeNames;

namespace TPVLib
{
    public class Controller
    {
        private RAMTPV _core = new RAMTPV();
        private UI _ui = new UI();

        public void StartProgram()
        {            
            UIdisplayMenu();
        }

        public void UIdisplayMenu()
        {
            _ui.SplashMenu();
            while (_ui.RunningApp())
            {
                _ui.MainMenu(_core);
            }
            _ui.ExitMenu();
        }
    }
}