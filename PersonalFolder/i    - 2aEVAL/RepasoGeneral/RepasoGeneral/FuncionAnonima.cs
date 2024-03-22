namespace PruebasBorrar
{
    public delegate int Delegate1(int number);
    public delegate bool Delegate2(int number);
    public delegate string Delegate3(int number);

    public class FuncionAnonima
    {

        public void Functions1()
        {
            Delegate1 test1 = delegate (int value) { return value * value; };

            Console.WriteLine(test1(5));
        } 

        public bool Functions2()
        {
            Delegate2 test2 = delegate (int value) { return value < 10; };

            return test2(2);
        }

        public string Functions3()
        {
            Delegate3 test3 = delegate (int number)
            {
                string result = "";
                switch (number)
                {
                    case 0:
                        result = "numero 0";
                        break;
                    case 1:
                        result = "numero 1";
                        break;
                    case 2:
                        result = "numero 2";
                        break;
                    default:
                        result = "Cualquier numero";
                        break;
                }
                return result;
            };

            return test3(2);
        }

        public string Functions4(int parameter)
        {
            Delegate3 test3 = delegate (int number)
            {
                string result = "";
                switch (number)
                {
                    case 0:
                        result = "numero 0";
                        break;
                    case 1:
                        result = "numero 1";
                        break;
                    case 2:
                        result = "numero 2";
                        break;
                    default:
                        result = "Cualquier numero";
                        break;
                }
                return result;
            };

            return test3(parameter);
        }
    }
    public class FuncionAnonimaTeoria
    {
        // 1. Definicion del 'prototipo' delegado.
        // public 'delegate' [tipo de salida] [nombre de delegado] (tipo y parametro de entrada)
        public delegate int DelegateName(int parameter);

        public int Anonima(int number)
        {
            // 2. Definicion de la funcion anonima.
            // [nombre delegado] [nombre variable] = 'delegate' (tipo parametro) { cuerpo de la funcion anonima };
            DelegateName del = delegate (int value)
            {
                if (value < 50)
                    return -1;
                else
                {
                    return 1;
                }
            };

            // 3. Llamada al delegado.
            return del(number);
        }
    }
}