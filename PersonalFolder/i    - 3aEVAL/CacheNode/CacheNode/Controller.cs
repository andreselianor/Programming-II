namespace CacheNode
{
    public class Controller
    {
        public static void Launch(IDatabase db)
        {
            Controller controller = new Controller();
            controller.SplashScreen(db);
        }

        public void SplashScreen(IDatabase db)
        {
            bool play = true;
            UI.UISplashScreen();
            UI.UIDisplayNode();

            db.CreateDatabase();
            string root = db.GetRoot();
            List<string> children = db.GetChildren();

            while (play)
            {
                Console.WriteLine($"El nodo root es {root} y los nodos hijos son:");
                Console.WriteLine($"Nodo 1: {children[0]}, Nodo 2: {children[1]}, Nodo 3: {children[2]}");

                UI.UISelectNode();
                string choice = Console.ReadLine();

                db.CreateCache(Int32.Parse(choice) - 1);
                db.Display();
                Console.ReadLine();
            }
        }
    }
}