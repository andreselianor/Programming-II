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
}
