namespace ExamenRugby
{
    public abstract class Player
    {
        protected Team _team;
        protected Position _position = new Position();

        public Player() { }
        public Player(Team team, Position position) 
        {
            _team = team;
            _position = position;
        }
        public abstract void ExecuteTurn();
    }
}
