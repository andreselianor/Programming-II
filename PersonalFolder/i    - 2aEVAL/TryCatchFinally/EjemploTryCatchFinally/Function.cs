namespace EjemploTryCatchFinally
{
    public class Function
    {
        private readonly string _test;

        public Function()
        {
            _test = "valor por defecto";
        }

        public void ExecuteFunction()
        {
            try
            {
                Console.WriteLine("Este es el try");
                _test.Clone();
                List<string> list = new List<string>();
                List<string> list2 = new List<string> { "Uno", "Dos", "Tres" };
                string test = list[1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Existe un error en la funcion 'ExecuteFunction'.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Este es el finally");
            }
        }

        public void ExecuteFunctionThrowException()
        {
            if (_test == null)
                throw new Exception("El atributo test apunta a una referencia nula.");

            Console.WriteLine();
            if (_test == null)
                throw new Exception();

            return;
        }
    }
}