namespace Domino
{
    /// <summary>
    /// Clase Game que implementa de IGame. En esta clase se ejecutan las ordenes que hacen 
    /// funcionar la partida.
    /// </summary>
    public class Game : IGame
    {
        #region Atributos
        private List<Jugador> _jugadores = new List<Jugador>();
        private Pila _pila = new Pila();
        public Jugador Ganador = new Jugador("Empate");
        #endregion

        #region Properties
        public Pila Pila
        {
            get { return _pila; }
        }
        public List<Jugador> Jugador
        {
            get { return _jugadores; }
        }
        #endregion


        #region Metodos
        public void InitPlay()
        {
            _pila.Stack.Clear();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Ficha f1 = new Ficha(i, j);
                    _pila.Stack.Add(f1);
                }
            }
        }
        #endregion
        public void InitPlayers()
        {
            _jugadores.Clear();
            for (int i = 0; i < 1; i++)
            {
                Jugador j1 = new Jugador("Bonete");
                Jugador j2 = new Jugador("Sembrin");
                _jugadores.Add(j1);
                _jugadores.Add(j2);
            }
        }

        public void MoveStack(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Ficha Fmove = new Ficha(0, 0);
                int random = Utils.GetRandom(25);
                Fmove = Pila.Stack[0];
                Pila.Stack[0] = Pila.Stack[random];
                Pila.Stack[random] = Fmove;
            }
        }

        public void GiveChips()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Jugador[j].Hand.Add(Pila.Stack[0]);
                    Pila.Stack.Remove(Pila.Stack[0]);
                }
            }
        }

        public Ficha Opening()
        {
            return Jugador[0].Hand.First();
        }

        public void Execute()
        {
            Ficha Playing = Opening();

            while (Pila.Stack.Count > 1)
            {
                bool robar1 = true;
                for (int i = 0; i < Jugador[1].Hand.Count; i++)
                {
                    if(Jugador[1].Hand[i].Izquierda == Playing.Derecha)
                    {
                        Playing = Jugador[1].Hand[i];
                        Jugador[1].Hand.Remove(Jugador[1].Hand[i]);
                        robar1 = false;
                    }                    
                }

                if (robar1 == true)
                {
                    Jugador[1].Hand.Add(Pila.Stack[0]);
                    Pila.Stack.Remove(Pila.Stack[0]);
                }

                bool robar0 = true;
                for (int i = 0; i < Jugador[0].Hand.Count; i++)
                {
                    if (Jugador[0].Hand[i].Izquierda == Playing.Derecha)
                    {
                        Playing = Jugador[0].Hand[i];
                        Jugador[0].Hand.Remove(Jugador[0].Hand[i]);
                        robar0 = false;
                    }
                }

                if (robar0 == true)
                {
                    Jugador[0].Hand.Add(Pila.Stack[0]);
                    Pila.Stack.Remove(Pila.Stack[0]);
                }
                Winner();                
            }            
        }

        public List<Ficha> ActualStack()
        {
            return _pila.Stack;
        }

        public Jugador Winner()
        {
            if (Jugador[0].Hand.Count == 0)
            {
                Ganador = Jugador[0];
            }
            else if (Jugador[1].Hand.Count == 0)
            {
                Ganador = Jugador[1];
            }
            return Ganador;            
        }
    }
}
