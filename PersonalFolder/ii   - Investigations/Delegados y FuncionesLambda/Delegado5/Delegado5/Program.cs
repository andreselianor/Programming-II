namespace Delegado5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculations calculations = new Calculations();

            // El usuario llama a la funcion Filter que imprime por pantalla
            // los numeros de la lista mayores que 100.
            calculations.FilterMajorThan(parameter => parameter > 100);

            // El usuario llama a la funcion Multiplicate que imprime por pantalla
            // los numeros de la lista multiplicados por el parametro.
            calculations.Multiplicate(parameter => { return parameter * 10; });

            Paragraphs paragraphs = new Paragraphs();

            // El usuario llama a la funcion Filter que imprime por pantalla
            // los parrafos mayores que 20 caracteres.
            paragraphs.FilterLengthMajorThan(parameter => parameter >= 20);
        }
    }

    public class Calculations
    {
        public delegate bool DelegadoFuncion(int parameter);
        List<int> list = new List<int> { 1, 3, 10, 20, 30, 5, 50, 100, 105 };

        // Funcion que imprime el elemento de la lista
        // si el delegado es verdadero.
        public void FilterMajorThan(DelegadoFuncion del)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int element = list[i];
                if (del(element))
                    Console.WriteLine(element);
            }
        }


        public delegate int DelegadoFuncion2(int parameter);
        List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Funcion que imprime el numero que devuelve el delegado.
        public void Multiplicate(DelegadoFuncion2 del)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(del(list2[i]));
            }
        }
    }

    public class Paragraphs
    {
        public delegate bool DelegateMajor(int number);
        public List<string> list = new List<string>();

        public Paragraphs()
        {
            CreateList();
        }

        public void CreateList()
        {
            list.Add("Me encanta cuando te arreglas el pelo con rulos.");
            list.Add("La genealogia de los barbaros vikingos se basaba en la caza de animales salvajes y la busqueda constante de la calidad " +
                "de un tesoro que no resultara demasiado caro, en terminos de esfuerzos físicos y económicos.");
            list.Add("A lo largo de la tarde se espera un leve repunte al alza de los valores bursatiles dedicados a la banca buscando" +
                "alcanzar un valor soporte a las caidas generalizadas del dia de hoy.");
        }

        // Funcion que imprime el string si el delegado
        // devuelve verdadero.
        public void FilterLengthMajorThan(DelegateMajor del)
        {
            foreach (string s in list)
            {
                int number = s.Count();
                if (del(number))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}