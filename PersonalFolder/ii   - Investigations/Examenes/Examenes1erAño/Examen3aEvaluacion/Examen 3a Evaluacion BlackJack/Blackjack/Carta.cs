namespace Blackjack
{

    public enum typeCard
    {
        Bastos,
        Copas,
        Oros,
        Espadas
    }
    public class Carta
    {
        private typeCard _palo;
        private int _number;
        private int _value;

        public Carta(typeCard palo, int number, int value)
        {
            _palo = palo;
            _number = number;
            _value = value;
        }

        public int Value => _value;
    }
}
