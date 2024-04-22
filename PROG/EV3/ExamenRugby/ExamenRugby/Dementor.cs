namespace ExamenRugby
{
    public class Dementor : Character
    {
        public Dementor() { }
        public Dementor(Position position) : base(position) 
        {
            _position = position;
        }


        public override void ExecuteTurn(IMatch match)
        {

        }
    }
}
