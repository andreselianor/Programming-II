using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Pila
    {
        #region Atributos
        private List<Ficha> _stack = new List<Ficha>();
        #endregion

        #region Properties
        public List<Ficha> Stack
        {
            get { return _stack; }
        }
        #endregion
        #region Constructor
        public Pila()
        {

        }
        #endregion
    }
}
