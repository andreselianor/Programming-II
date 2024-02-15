using static System.Net.Mime.MediaTypeNames;

namespace TPVLib
{
    public class Controller
    {
        private RAMTPV _core = new RAMTPV();
        private UI _ui = new UI();

        public List<Product> DisplayProducts()
        {
            return _core.GetProducts();
        }

        public void UIdisplayMenu()
        {
            _ui.SplashMenu();

            while (!_ui.Exit)
            {
                _ui.MainMenu();
            }
        }
    }
}
