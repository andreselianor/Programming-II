using System;
using System.Collections.Generic;
namespace Domino
{
    public class Jugador
    {
        #region Atributos
        private string _name;
        private List<Ficha> _hand = new List<Ficha>();
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }
        public List<Ficha> Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }
        #endregion

        #region Constructor
        public Jugador()
        {

        }
        public Jugador(string name)
        {
            _name = name;
        }
        #endregion
    }
}
