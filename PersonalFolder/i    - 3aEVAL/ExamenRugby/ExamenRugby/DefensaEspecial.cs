namespace ExamenRugby
{
    public class DefensaEspecial : Defensa
    {
        public DefensaEspecial() { }
        public DefensaEspecial(Team team, Position position) : base (team, position)
        {
            _team = team;
            _position = position;
        }

        public override void ExecuteTurn(IMatch match)
        {
            
        }
    }
}
