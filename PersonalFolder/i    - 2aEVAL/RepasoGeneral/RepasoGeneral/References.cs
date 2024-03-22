namespace RepasoGeneral
{
    public static class References
    {
        // La palabra clave 'out' escribe en el parametro de entrada el valor que le asigna el cuerpo de la función.
        public static void ReferenceOut(out int number1, out int number2)
        {
            number1 = 10;
            number2 = 50;
        }

        // La palabra clave 'ref' lee el parametro cuando entra en la funcion y escribe el parametro antes de salir.
        public static void ReferenceRef(ref int number1, ref int number2)
        {
            int result = number1 + number2;
            number1 = 1920;
            number2 = 720;
        }

        // La palabra clave 'in' establece el parametro de entrada como de solo lectura.
        public static int ReferenceIn(in int number1, int number2)
        {
            int result = number1 + number2;
            //number1 = 10; EC
            number2 = 10;
            return result;
        }

        /*
        public static void Main(string[] args)
        {
            int numero1 = 5, numero2;
            References.ReferenceOut(out numero1, out numero2);
            Console.WriteLine("" + numero1 + "-" + numero2);
            numero1 = 10; numero2 = 50;

            int numero3 = 15, numero4 = 35;
            References.ReferenceRef(ref numero3, ref numero4);
            Console.WriteLine("" + numero3 + "-" + numero4);
            numero3 = 1920; numero4 = 720;

            int numero5 = 500, numero6 = 1000;
            int result = References.ReferenceIn(in numero5, numero6);
            Console.WriteLine(result);
            numero5 = 1920; numero6 = 10;
        }
        */
    }
}