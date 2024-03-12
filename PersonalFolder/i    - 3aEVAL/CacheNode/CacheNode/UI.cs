namespace CacheNode
{
    public static class UI
    {
        public static void UISplashScreen()
        {
            string intro = "Bienvenidos a CacheNode, App Manager";
            Console.WriteLine(intro);
            Console.WriteLine();
        }
        public static void UIDisplayNode()
        {
            string display = "Estos son los nodos hijos de la raiz";
            Console.WriteLine(display);
            Console.WriteLine();
        }

        public static void UISelectNode()
        {
            string select = "Escoja un nodo para mostrar sus hijos";
            Console.WriteLine(select); 
            Console.WriteLine();
        }
    }
}
