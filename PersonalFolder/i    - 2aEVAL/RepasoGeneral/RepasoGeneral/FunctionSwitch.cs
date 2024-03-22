namespace RepasoGeneral
{
    public class FunctionSwitch
    {
        // Estructura de control de flujo
        private int _intControl;
        private string _stringControl = "";

        public int IntControl
        {
            get { return _intControl; }
            set { _intControl = value; }
        }

        public string StringControl
        {
            get { return _stringControl; }
            set { _stringControl = value; }
        }

        public void TestingSwitch1()
        {            
            string result = "";
            switch (_intControl)
            {
                case -1:
                    result = "numero -1";
                    break;
                case 0:
                    result = "numero 0";
                    break;
                case 1:
                    result = "numero 1";
                    break;
                default:
                    result = "cualquier numero";
                    break;
            }
            Console.WriteLine(result);
        }

        public void TestingSwitch2()
        {
            string result = "";

            Random random = new Random();
            int choice = random.Next(4);

            switch(choice)
            {
                case 0:
                    _stringControl = "MonigoteNoCocina";
                    break;
                case 1:
                    _stringControl = "StressEnelTrabajo";
                    break;
                case 2:
                    _stringControl = "CambioDeRitmo";
                    break;
            }

            switch (_stringControl)
            {
                case "MonigoteNoCocina":
                    result = "me tomo una nectarina";
                    break;
                case "StressEnelTrabajo":
                    result = "un masaje de pies es una ensoñacion";
                    break;
                case "CambioDeRitmo":
                    result = "pienso en largos paseos por un zoologico";
                    break;
            }
            Console.WriteLine(result);
        }

        public string TestingSwitch3()
        {
            switch (_stringControl)
            {
                case "SI":
                    return "una linea de switch";
                case "NO":
                    return "tambien compila";
                default:
                    return "cualquier cosa";
            }
        }
    }

    public static class FunctionSwitchStatic
    {
        public static string TestingSwitchStatic(int number)
        {
            if (number < 0 || number > 100)
                return string.Empty;

            string result = string.Empty;
            switch (number)
            {
                case 0:
                    result = "numero 0";
                    break;
                case 1:
                    result = "numero 1";
                    break;
                default:
                    result = "cualquier numero";
                    break;
            }
            return result;
        }
    }
}
