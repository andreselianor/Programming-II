using System.Collections.Generic;

namespace JuegoOca
{
    public class Board
    {        
        private List<Player> _listPlayer = new List<Player>();


        // Funcion que crea los jugadores
        public void CreatePlayers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Player player = new Player();
                player.AbletoMove = true;
                player.HaltTurns = 0;
                _listPlayer.Add(player);
            }
        }


        // Funcion que mueve a los jugadores
        public void PlayerMove()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                if (_listPlayer[i].AbletoMove == true)
                {
                    _listPlayer[i].PlayerMove();
                }
            }
        }


        // Funcion que devuelve si un jugador ha llegado a la casilla 63
        public bool PlayerHasArrived()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                return _listPlayer[i].CellNumber >= 63;
            }
            return false;
        }

        // Funciones que hacen esperar a los jugadores que caen en casillas de espera
        public void PlayerHalt()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                int actualPlayerCell = _listPlayer[i].CellNumber;
                int turnsHalt = NumberTurnsHalt(actualPlayerCell);
                _listPlayer[i].HaltTurns = turnsHalt;
            }
        }

        // Funcion que hace repetir la tirada de dados
        public void PlayerRepeat()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                int cell = _listPlayer[i].CellNumber;
                if (PlayerRepeat(cell))
                {
                    PlayerMove();
                }
            }
        }

        // Funcion que traslada al jugador a otra casilla
        public void PlayerTranslation()
        {
            for (int i = 0; i < _listPlayer.Count; i++)
            {
                int casilla = _listPlayer[i].CellNumber;
                switch (casilla)
                {
                    case 6:
                        _listPlayer[i].SetCell(12);
                        break;
                    case 12:
                        _listPlayer[i].SetCell(6);
                        break;
                    case 26:
                        _listPlayer[i].SetCell(53);
                        break;
                    case 53:
                        _listPlayer[i].SetCell(26);
                        break;
                }   
            }
        }


        // Funcion que establece cuantos turnos se debe estar sin jugar
        public int NumberTurnsHalt(int cell)
        {
            int turnsHalt = 0;
            switch (cell)
            {
                case (18):
                    turnsHalt = 1;
                    break;
                case (31):
                    turnsHalt = 2;
                    break;
                case (43):
                    turnsHalt = 3;
                    break;
                case (52):
                    turnsHalt = 4;
                    break;
                case (58):
                    turnsHalt = 4;
                    break;
                default:
                    turnsHalt = 0;
                    break;
            }
            return turnsHalt;
        }

        // Funcion que devuelve si un jugador puede repetir tirada de dados
        public bool PlayerRepeat(int cell)
        {
            bool result = false;
            switch (cell)
            {
                case 1:
                case 6:
                case 9:
                case 12:
                case 18:
                case 26:
                case 27:
                case 41:
                case 50:
                case 53:
                case 63:
                    result = true;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }
    }
}
