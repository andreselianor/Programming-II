namespace TPVLib
{
    public static class UI
    {			
        public static void UISplashMenu()
        {
            string welcomeMessage = "Bienvenidx a TPV 1.0";
            Console.WriteLine(welcomeMessage);
            Console.ReadLine();
        }
        public static void UIMainMenu()
        {
            string mainMenuMessage = "Introduzca una opcion:";
            string mainMenuMessage1 = "[1].Producto";
            string mainMenuMessage2 = "[2].Factura";
            string mainMenuMessage0 = "[0].Salir";
            Console.WriteLine(mainMenuMessage);
            Console.WriteLine(mainMenuMessage1);
            Console.WriteLine(mainMenuMessage2);
            Console.WriteLine(mainMenuMessage0);
            Console.WriteLine();
        }
        public static void UIProductMenu()
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
            Console.WriteLine();
        }
        public static void UIInvoiceMenu()
        {
            string InvoiceMessage = "Introduzca una opcion";
            string InvoiceMessage1 = "[1].Recoger Factura";
            string InvoiceMessage2 = "[2].Comprobar facturas anteriores";
            string InvoiceMessage0 = "[0].Menu anterior";
            Console.WriteLine(InvoiceMessage);
            Console.WriteLine(InvoiceMessage1);
            Console.WriteLine(InvoiceMessage2);
            Console.WriteLine(InvoiceMessage0);
            Console.WriteLine();
        }
        public static void UIExitMenu()
        {            
            string exitMenuMessage = "Gracias por utilizar TPV 1.0";
            Console.WriteLine(exitMenuMessage);
            Console.ReadLine();
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE UI · MODELO - VISTA - CONTROLADOR DE UNA APLICACION.
        La UI se encarga de mostrar por pantalla las acciones posibles que podemos realizar sobre 
        nuestro programa.
        
        ~ UISplashMenu() : void
        Muestra la pantalla de bienvenida.

        ~ UIMainMenu() : void
        Muestra en pantalla el menu principal

        ~ UIProductMenu() : void
        Muestra el menu producto.

        ~ UIInvoiceMenu() : void
        Muestra el menu de pedidos.

        ~ UIExitMenu(): void
        Muestra el menu de cierre de sesion.
        */
        #endregion
    }
}