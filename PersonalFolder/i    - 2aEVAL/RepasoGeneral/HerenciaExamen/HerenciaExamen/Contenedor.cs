using System.Xml.Linq;

namespace HerenciaExamen
{
    internal class Contenedor : ICountry
    {
        List<Country> _countriesList = new List<Country>();

        public void CreateCountryList()
        {
            Country c1 = new Country("España", "Unidad");
            Country c2 = new Country("Belgica", "Liderazgo");
            Country c3 = new Country("Prusia", "Supervivencia");
            _countriesList = new List<Country> { c1, c2, c3 };
        }
    
    public string GetCountry()
    {
        return _name;
    }

    public string GetObjective()
    {
        return _objective;
    }

    public bool GetParticularObjective()
    {
        return false;
    }
}
    
}
