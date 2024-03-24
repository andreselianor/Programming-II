namespace TPVLib
{
    public class Controller
    {
        private bool _isRunning = true;

        public static void RunApplication(ITPV tpv)
        {
            Controller controller = new Controller();
            controller.StartProgram(tpv);
        }

        public void StartProgram(ITPV tpv)
        {
            UI.UISplashMenu();
            while (_isRunning)
            {
                UIdisplayMainMenu(tpv);
            }
            UI.UIExitMenu();
        }

        public void UIdisplayMainMenu(ITPV tpv)
        {
            bool mainMenu = true;
            int optionMenu;
            while (mainMenu)
            {
                UI.UIMainMenu();
                optionMenu = Int32.Parse(Console.ReadLine());

                if(optionMenu == 1)
                    UIdisplayProductMenu(tpv);
                else if(optionMenu == 2)
                    UIdisplayInvoiceMenu(tpv);
                else if(optionMenu == 0)
                {
                    mainMenu = false;
                    _isRunning = false;
                }    
                else
                    Console.WriteLine("Introduzca una opcion valida");
            }
        }

        public void UIdisplayProductMenu(ITPV tpv)
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
                    DisplayingAvailableProducts(tpv);
                }
                else if (optionMenu == 2)
                    Console.WriteLine("No implementado");
                else if (optionMenu == 3)
                    Console.WriteLine("No implementado");
                else if (optionMenu == 4)
                    Console.WriteLine("No implementado");
                else if (optionMenu == 0)
                    productMenu = false;
                else
                    Console.WriteLine("Introduzca una opcion valida");

                Console.WriteLine();
            }
            UIdisplayMainMenu(tpv);
        }

        public void UIdisplayInvoiceMenu(ITPV tpv)
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
                    invoiceMenu = false;
                else
                    Console.WriteLine("Introduzca una opcion valida");

                Console.WriteLine();
            }
            UIdisplayMainMenu(tpv);
        }

        private void DisplayingAvailableProducts(ITPV tpv)
        {
            List<Product> listProducts = tpv.GetProducts();

            foreach (Product p in listProducts)
            {
                Console.WriteLine($"Producto con ID {p.ID}: {p.Name} - Cantidad en stock: {p.Stock}");
            }
            Console.WriteLine();
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE CONTROLLER · MODELO - VISTA - CONTROLADOR DE UNA APLICACION.
        El controlador se encarga de relacionar los datos de la coleccion del modelo, 
        con la interfaz grafica del usuario.
        
        ~ Run(ITPV) : void
        Crea un objeto controlador nuevo y ejecuta la funcion de arranque del programa.

        + StartProgram(ITPV) : void
        Funcion que muestra por pantalla el 'splash screen'.

        + UIdisplayMainMenu(ITPV) : void
        Muestra por pantalla el menu principal.

        + UIdisplayProductMenu(ITPV) : void
        Muestra por pantalla el menu productos.

        + UIdisplayInvoiceMenu(ITPV) : void
        Muestra por pantalla el menu pedidos.

        - DisplayingAvailableProducts(ITPV) : void
        Muestra por pantalla los productos disponibles.
        
        */
        #endregion
    }
}