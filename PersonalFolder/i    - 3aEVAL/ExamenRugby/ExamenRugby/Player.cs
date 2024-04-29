namespace ExamenRugby
{
    public abstract class Player : Character
    {
        protected Team _team;

        public Team Team => _team;
        public Player() { }
        public Player(Team team, Position position) : base(position)
        {
            _team = team;
            _position = position;
        }        
    }
}
