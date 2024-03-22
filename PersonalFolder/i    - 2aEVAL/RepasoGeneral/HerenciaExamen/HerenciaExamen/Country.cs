namespace HerenciaExamen
{
    public class Country : ICountry
    {
        private string _name = "";
        private string _objective = "";

        public string Name => _name;
        public string Objective => _objective;
        public Country() { }
        public Country(string name, string objective)
        {
            _name = name;
            _objective = objective;
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
