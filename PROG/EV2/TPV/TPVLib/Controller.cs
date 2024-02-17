using static System.Net.Mime.MediaTypeNames;

namespace TPVLib
{
    public class Controller
    {
        private RAMTPV _core = new RAMTPV();
        private bool _isRunning = true;

        public void StartProgram()
        {
            UI.UISplashMenu();
            while (_isRunning)
            {
                UIdisplayMainMenu();
            }
            UI.UIExitMenu();
        }

        public void UIdisplayMainMenu()
        {
            bool mainMenu = true;
            int optionMenu;
            while (mainMenu)
            {
                UI.UIMainMenu();
                optionMenu = Int32.Parse(Console.ReadLine());
                if(optionMenu == 1)
                    UIdisplayProductMenu();
                else if(optionMenu == 2)
                    UIdisplayInvoiceMenu();
                else if(optionMenu == 0)
                {
                    mainMenu = false;
                    _isRunning = false;
                }                                   
            }
        }

        public void UIdisplayProductMenu()
        {
            bool productMenu = true;
            int optionMenu;

            while (productMenu)
            {
                UI.UIProductMenu();
                optionMenu = Int32.Parse(Console.ReadLine());
                if (optionMenu == 1)
                {
                    Console.WriteLine("Listando productos disponibles en la base de datos...");
                    DisplayingAvailableProducts(_core);
                }
                if (optionMenu == 2)
                    Console.WriteLine("No implementado");
                else if(optionMenu == 3)
                    Console.WriteLine("No implementado");
                else if(optionMenu == 4)
                    Console.WriteLine("No implementado");
                else if(optionMenu == 0)
                    UIdisplayMainMenu();
                else                
                    Console.WriteLine("Introduzca una opcion valida");                
            }            
        }

        public void UIdisplayInvoiceMenu()
        {
            bool invoiceMenu = true;
            int optionMenu;

            while (invoiceMenu)
            {
                UI.UIInvoiceMenu();
                optionMenu = Int32.Parse(Console.ReadLine());
                if (optionMenu == 1)
                    Console.WriteLine("No implementado");
                else if (optionMenu == 2)
                    Console.WriteLine("No implementado");
                else if (optionMenu == 0)
                    UIdisplayMainMenu();
                else                
                    Console.WriteLine("Introduzca una opcion valida");                
            }            
        }

        private void DisplayingAvailableProducts(ITPV tpv)
        {
            List<Product> listProducts = tpv.GetProducts();

            foreach (Product p in listProducts)
            {
                Console.WriteLine($"Producto con ID {p.ID}: {p.Name} - Cantidad en stock: {p.Stock}");
            }
        }
    }
}