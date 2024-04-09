namespace DelegadosResumen
{
    public class City
    {
        private string _name = "";
        private int _population;

        public string Name => _name;
        public int Population => _population;

        public City() { }
        public City(string name)
        {
            _name = name;
        }
        public City(string name, int population)
        {
            _name = name;
            _population = population;
        }
    }
}