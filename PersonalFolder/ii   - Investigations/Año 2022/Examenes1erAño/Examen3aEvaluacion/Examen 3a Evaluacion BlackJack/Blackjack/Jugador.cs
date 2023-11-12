namespace Blackjack
{
    public class Jugador
    {
        private string _name;
        private List<Carta> _listaCartas = new List<Carta>();
        private int _sumaValores;
        private int _fichas;
        private bool _loseRound;

        public Jugador()
        {

        }
        public Jugador(int fichas)
        {
            _fichas = fichas;
        }
        public Jugador(string nombre, int fichas)
        {
            _name = nombre;
            _listaCartas = new List<Carta>();
            _fichas = fichas;
        }

        public List<Carta> ListaCartas
        {
            get { return _listaCartas; }
            set { _listaCartas = value; }
        }

        public int SumaValores
        {
            get { return _sumaValores; }
            set { _sumaValores = value; }
        }

        public int Fichas
        {
            get { return _fichas; }
            set { _fichas = value; }
        }

        public bool LoseRound
        {
            get { return _loseRound; }
            set { _loseRound = value; }
        }
    }
}
