namespace HerenciaExamen
{
    public class Controlador
    {
        public void Start(ICountry country)
        {
            UI.WelcomeMessage();
            UI.IsEuropeanCountry();
            string european = Console.ReadLine();
            if (european == "si")
                UI.IsEuropeanCountry();
            else
                UI.NonEuropeanCountry();
            country.CreateCountryList();
            UI.SelectCountry();
            UI.PrintCountries(country);
        }
    }
}
