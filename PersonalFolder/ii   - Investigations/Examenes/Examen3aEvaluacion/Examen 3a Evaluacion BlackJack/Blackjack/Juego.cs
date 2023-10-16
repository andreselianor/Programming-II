namespace Blackjack
{
    public class Juego
    {
        private List<Jugador> _playerList = new List<Jugador>();
        private List<Carta> _cartaList = new List<Carta>();


        /// <summary>
        /// La funcion crea los jugadores de la simulacion. Ademas, los añade a la lista de jugadores _playerlist
        /// </summary>
        /// <param name="playerNumber">Numero de jugadores. El 0 le pertenece a la banca</param>
        /// <param name="numeroFichas">Numero de fichas para apostar de cada jugador</param>
        public void CreatePlayers(int playerNumber, int numeroFichas)
        {
            for (int i = 0; i < playerNumber; i++)
            {
                Jugador jugador = new Jugador(numeroFichas);
                _playerList.Add(jugador);
            }
        }

        #region Funcion Crear Baraja
        /// <summary>
        /// Esta funcion crea toda el mazo de cartas para jugar. Creo que se puede refactorizar de multiples maneras, con bucles for
        /// o extrayendo el metodo a otra clase, quizas a la clase Croupier
        /// Falta de tiempo.
        /// </summary>
        public void CreateDeck()
        {
            // 1 Bucle por cada palo
            // Ademas creo el valor de cada carta

            // Bastos

            for (int i = 1; i < 11; i++)
            {
                Carta carta = new Carta(typeCard.Bastos, i, i);
                _cartaList.Add(carta);
            }

            for (int i = 10; i < 13; i++)
            {
                Carta carta = new Carta(typeCard.Bastos, i, 10);
                _cartaList.Add(carta);
            }

            // Copas

            for (int i = 1; i < 11; i++)
            {
                Carta carta = new Carta(typeCard.Copas, i, i);
                _cartaList.Add(carta);
            }

            for (int i = 10; i < 13; i++)
            {
                Carta carta = new Carta(typeCard.Copas, i, 10);
                _cartaList.Add(carta);
            }

            // Oros

            for (int i = 1; i < 11; i++)
            {
                Carta carta = new Carta(typeCard.Oros, i, i);
                _cartaList.Add(carta);
            }

            for (int i = 10; i < 13; i++)
            {
                Carta carta = new Carta(typeCard.Oros, i, 10);
                _cartaList.Add(carta);
            }

            // Espadas

            for (int i = 1; i < 11; i++)
            {
                Carta carta = new Carta(typeCard.Espadas, i, i);
                _cartaList.Add(carta);
            }

            for (int i = 10; i < 13; i++)
            {
                Carta carta = new Carta(typeCard.Espadas, i, 10);
                _cartaList.Add(carta);
            }

            // Ases

            Carta carta1 = new Carta(typeCard.Bastos, 0, 11);
            Carta carta2 = new Carta(typeCard.Copas, 0, 11);
            Carta carta3 = new Carta(typeCard.Oros, 0, 11);
            Carta carta4 = new Carta(typeCard.Espadas, 0, 11);

            _cartaList.Add(carta1);
            _cartaList.Add(carta2);
            _cartaList.Add(carta3);
            _cartaList.Add(carta4);
        }
        #endregion


        /// <summary>
        /// La funcion baraja las cartas, extrayendo una carta aleatoria, quitandola del mazo y añadiendola
        /// a la lista de cartas del jugador.
        /// </summary>
        /// <param name="shuffleNumber">Numero de cartas que se barajan</param>
        public void ShuffleDeck(int shuffleNumber)
        {
            for (int i = 0; i < shuffleNumber; i++)
            {
                int randomPosition = Utils.GetRandom(0, 53);
                Carta cartaMovida = _cartaList[randomPosition];
                _cartaList.RemoveAt(randomPosition);
                _cartaList.Add(cartaMovida);
            }
        }

        /// <summary>
        /// Se reparten las primeras cartas de la partida
        /// </summary>
        public void GiveFirstCards()
        {
            int PlayersNumber = _playerList.Count;
            for (int i = 0; i < PlayersNumber; i++)
            {
                Carta carta = _cartaList[0];                
                _playerList[i].ListaCartas.Add(carta);
                _cartaList.RemoveAt(0);
            }
        }

        /// <summary>
        /// Da una carta al jugador
        /// </summary>
        /// <param name="jugador">Jugador que recibe la carta</param>
        public void GiveCard(Jugador jugador)
        {
            Carta carta = _cartaList[0];
            _cartaList.RemoveAt(0);
            jugador.ListaCartas.Add(carta);
        }

        /// <summary>
        /// Apuesta una ficha
        /// </summary>
        /// <param name="jugador"></param>
        public void BetOneFich(Jugador jugador)
        {
            jugador.Fichas -= 1;
        }

        public void ExecutePlay(Jugador jugador, bool pideCarta)
        {
            if (pideCarta == false)
            {
                jugador.SumaValores = Croupier.CalculateSumCards(jugador.ListaCartas);
            }
            else
            {
                GiveCard(jugador);
                jugador.SumaValores = Croupier.CalculateSumCards(jugador.ListaCartas);
            }
        }

        public void FinishPlayerGame(Jugador jugador)
        {
            if (jugador.SumaValores >= 21)
            {
                jugador.LoseRound = true;
            }
        }

        public bool FinishGame()
        {
            bool finish = false;
            for (int i = 0; i < _playerList.Count; i++)
            {
                if (_playerList[i].LoseRound == true)
                    finish = true;
                else
                {
                    return false;
                }
            }
            return finish;
        }
    }
}
