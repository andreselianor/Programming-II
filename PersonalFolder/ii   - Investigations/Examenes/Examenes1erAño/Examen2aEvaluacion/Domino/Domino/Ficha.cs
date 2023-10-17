namespace Domino
{
    public class Ficha
    {
        #region Atributos
        private int _izquierda;
        private int _derecha;
        #endregion

        #region Constructor
        public Ficha(int izq, int der)
        {
            _izquierda = izq;
            _derecha= der;
        }
        #endregion

        #region Properties
        public int Izquierda
        {
            get { return _izquierda; }
        }
        public int Derecha
        {
            get { return _derecha; }
        }
        #endregion
    }
}
