using System.Xml.Linq;

namespace Dardos
{
    public class Player
    {
        private string _name = "";
        private int _id;
        private int _money = 100;
        private int _puntuationRound;
        private bool _greatThrow;


        // Properties para recuperar la cantidad de dinero que le queda y la puntuacion en cada ronda
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        public int PuntuationOneRound => _puntuationRound;
        public bool GreatThrow => _greatThrow;


        // He decidido crear funciones para establecer el nombre y la identificacion del jugador.
        // Otra opcion es pasar los parametros por un constructor, pero de esta manera resultaba mas
        // eficiente a la hora de crear los jugadores en la clase Juego
        public int SetName(string name)
        {
            if (name == null)
                return -1;
            _name = name;
            return 1;
        }

        public int SetId(int number)
        {
            if (number <= 0)
                return -1;
            _id = number;
            return 1;
        }


        #region METODOS
        // Metodo para apostar monedas. Si tiene menos de 5 las apuesta todas.
        public int BetChips()
        {
            int bet;
            if (_money <= 5)
            {
                bet = _money;
                _money = 0;
            }
            else
            {
                bet = Utils.GetRandom(5, _money);
                _money -= bet;
            }
            return bet;
        }

        // Metodo para calcular la puntuacion de cada ronda.        
        // Se le pasa por parametro el numero de dardos que tira cada jugador.
        // Si en la ronda anterior ha hecho una gran jugada, tira un dardo mas.

        public void ThrowDarts(int numberDarts)
        {
            _puntuationRound = 0;

            int result = 0;

            for (int i = 0; i < numberDarts; i++)
            {
                int hability = Utils.GetRandom(0, 100);
                int luck = Utils.GetRandom(0, 100);
                int dartThrow = hability + luck;

                switch (dartThrow)
                {
                    case < 40:
                        result += 0;
                        break;
                    case < 80:
                        result += 1;
                        break;
                    case < 120:
                        result += 5;
                        break;
                    case < 160:
                        result += 10;
                        break;
                    case < 180:
                        result += 50;
                        break;
                    case < 200:
                        result += 100;
                        break;
                    case 200:
                        result += 100;
                        _greatThrow = true;
                        break;
                    default:
                        result += 0;
                        break;
                }

                // Otra solucion para calcular la puntuacion de cada ronda.
                // En lugar de sentencias Switch, tambien se puede utilizar las condicionales if

                /*
                if (lanzamiento > 0 && lanzamiento < 20)
                    result += 0;
                if (lanzamiento > 20 && lanzamiento < 40)
                    result += 1;
                if (lanzamiento > 40 && lanzamiento < 60)
                    result += 5;
                if (lanzamiento > 60 && lanzamiento < 80)
                    result += 10;
                if (lanzamiento > 80 && lanzamiento < 90)
                    result += 50;
                if (lanzamiento > 90 && lanzamiento < 100)
                    result += 100;
                if (lanzamiento = 100)
                    _greatThrow = true;
                */
            }
            _puntuationRound = result;
        }
        #endregion
    }
}
