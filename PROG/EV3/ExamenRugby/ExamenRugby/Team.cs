namespace ExamenRugby
{
    public record Team
    {
        private string _name = string.Empty;

        public Team(string name)
        {
            _name = name;
        }
    }
}