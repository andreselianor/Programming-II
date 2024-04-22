namespace ExamenRugby
{
    public abstract class Character
    {
        protected Position _position = new Position();

        public Character() { }
        public Character(Position position)
        {
            _position = position;
        }

        public abstract void ExecuteTurn(IMatch match);
    }
}
