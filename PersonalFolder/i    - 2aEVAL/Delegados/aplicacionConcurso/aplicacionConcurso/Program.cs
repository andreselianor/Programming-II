namespace aplicacionConcurso
{
    public delegate string DelegateShow();

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sorteo de gaming");

            Sorteo sorteo1 = new Sorteo();
            sorteo1.CreateList();
            Console.WriteLine("La lista de premios se está creando");
            Console.ReadLine();

            bool playing = true;
            int count = 0;
            while(playing)
            {
                count++;
                sorteo1.SwapList(50);
                Console.WriteLine("Estamos girando los premios");
                Console.ReadLine();

                DelegateShow delegate1 = new DelegateShow(sorteo1.GetFirstElement);
                string result = delegate1();
                Console.WriteLine("El resultado del sorteo numero {0} es:\n +{1}",count,result);
                Console.ReadLine();

                if (count == 4)
                    playing = false;
            }
            
        }
    }
}