namespace HerenciaExamen
{
    public static class UI
    {
        public static void WelcomeMessage()
        {
            string message = "Bienvenido a su panel de control";
            Console.WriteLine(message);
            Console.ReadLine();
        }
        public static void ContinentSelector()
        {
            string message = "Eliga un continente";
            Console.WriteLine(message);
        }
        public static void IsEuropeanCountry()
        {
            string message = "¿Desea elegir un pais Europeo?";
            Console.WriteLine(message);
        }
        public static void EuropeanCountry()
        {
            string message = "Usted ha elegido un pais europeo";
            Console.WriteLine(message);
            Console.ReadLine();
        }
        public static void NonEuropeanCountry()
        {
            string message = "Usted ha elegido un pais  no europeo";
            Console.WriteLine(message);
            Console.ReadLine();
        }
        public static void SelectCountry()
        {
            string message = "Escoja un pais europeo";
            
            Console.WriteLine(message);
        }
        public static void PrintCountries(List<Country> countries)
        {
            foreach(Country c in countries)
            {
                Console.WriteLine(c.Name + " cuyo objetivo es: " + c.Objective);
            }
        }
        public static void CountrySelector()
        {

        }

    }
}
