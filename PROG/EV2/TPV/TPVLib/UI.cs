namespace TPVLib
{
    public class UI
    {
        private bool _runningApp = true;

        public bool RunningApp()
        {
            return _runningApp;
        }

        public void SplashMenu()
        {
            string welcomeMessage = "Bienvenidx a TPV 1.0";
            Console.WriteLine(welcomeMessage);
            Console.ReadLine();
        }

        public void MainMenu(ITPV tpv)
        {
            string mainMenuMessage = "Introduzca una opcion:";
            string mainMenuMessage1 = "[1].Producto";
            string mainMenuMessage2 = "[2].Factura";
            string mainMenuMessage0 = "[0].Salir";
            Console.WriteLine(mainMenuMessage);
            Console.WriteLine(mainMenuMessage1);
            Console.WriteLine(mainMenuMessage2);
            Console.WriteLine(mainMenuMessage0);

            string choice = Console.ReadLine();
            if (choice == "1")
                ProductMenu(tpv);
            else if (choice == "2")
                InvoiceMenu(tpv);
            else if (choice == "0")
                _runningApp = false;
            else
                MainMenu(tpv);
        }

        public void ProductMenu(ITPV tpv)
        {
            string ProductMessage = "Introduzca una opcion";
            string ProductMessage1 = "[1].Listar productos disponibles";
            string ProductMessage2 = "[2].Escoger Producto";
            string ProductMessage3 = "[3].Comprobar existencias";
            string ProductMessage0 = "[0].Menu anterior";
            Console.WriteLine(ProductMessage);
            Console.WriteLine(ProductMessage1);
            Console.WriteLine(ProductMessage2);
            Console.WriteLine(ProductMessage3);
            Console.WriteLine(ProductMessage0);

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Listando productos disponibles en la base de datos...");
                DisplayingAvailableProducts(tpv);
                ProductMenu(tpv);
            }
            else if (choice == "2")
                Console.WriteLine("No implementado");
            else if (choice == "3")
                Console.WriteLine("No implementado");
            else if (choice == "0")
                MainMenu(tpv);
            else
            {
                Console.WriteLine("Introduzca una opcion valida");
                ProductMenu(tpv);
            }
        }

        public void InvoiceMenu(ITPV tpv)
        {
            string InvoiceMessage = "Introduzca una opcion";
            string InvoiceMessage1 = "[1].Recoger Factura";
            string InvoiceMessage2 = "[1].Comprobar facturas anteriores";
            string InvoiceMessage0 = "[0].Menu anterior";
            Console.WriteLine(InvoiceMessage);
            Console.WriteLine(InvoiceMessage1);
            Console.WriteLine(InvoiceMessage2);
            Console.WriteLine(InvoiceMessage0);

            string choice = Console.ReadLine();
            if (choice == "1")
                Console.WriteLine("No implementado");
            else if (choice == "2")
                Console.WriteLine("No implementado");
            else if (choice == "0")
                MainMenu(tpv);
            else
            {
                Console.WriteLine("Introduzca una opcion valida");
                InvoiceMenu(tpv);
            }
        }
        public void ExitMenu()
        {            
            string exitMenuMessage = "Gracias por utilizar TPV 1.0";
            Console.WriteLine(exitMenuMessage);
            Console.ReadLine();
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