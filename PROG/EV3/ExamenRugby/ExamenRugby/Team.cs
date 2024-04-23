namespace ExamenRugby
{
    public record Team
    {
        // Equipo 'A' juega ARRIBA
        // Equipo 'B' juega ABAJO

        private char _team = ' ';

        public char TeamLetter => _team;

        public Team(char letter)
        {
            _team = letter;
        }
    }
}