
namespace Figuras
{
    public class Plano : IFigura
    {
        private List<Figura> _figureList = new List<Figura>();


        #region Funciones
        // La funcion AddFigure añade la figura que tenga un nombre determinado a la lista de Figuras figurelist
        public void AddFigure(Figura figureName)
        {
            _figureList.Add(figureName);
        }


        // La funcion RemoveFigureIndex elimina la figura dentro de la lista que se encuentre en la posicion pasada en el index
        public void RemoveFigureIndex(int index)
        {
            _figureList.RemoveAt(index);
        }


        // La funcion RemoveFigureName elimina la figura de la lista que coincida con el figurename que le pasamos por parametros
        public void RemoveFigureName(Figura figureName)
        {
            for (int i = 0; i < _figureList.Count; i++)
            {
                if (_figureList[i].Nombre == figureName.Nombre)
                {
                    _figureList.RemoveAt(i);
                }
            }
        }


        // La funcion RemoveFigure elimina la figura de la lista
        public void RemoveFigure(Figura figure)
        {
            for (int i = 0; i < _figureList.Count; i++)
            {
                if (_figureList[i] == figure)
                {
                    _figureList.RemoveAt(i);
                }
            }
        }


        // Esta funcion devuelve el numero de figuras que hay dentro de la lista
        public int GetNumberFigure()
        {
            return _figureList.Count();
        }


        // GetFigureAt devuelve la figura que se encuentra en una posicion de la lista
        public Figura GetFigureAt(int index)
        {
            return _figureList[index];
        }
        #endregion

        // No me ha dado tiempo a arreglar esta funcion.
        // En primer lugar he pensado en calcular el area de cada figura con una funcion estatica diseñada en la clase Utils.
        // Ahora me he dado cuenta que resulta mejor solucion diseñar una funcion abstracta dentro de la clase Planas, de nombre CalculateArea
        // Que implementan las clases hijas en su funcion correspondiente.
        // Tambien entiendo perfectamente que no he revisado los parametros de entrada de las distintas funciones, pero he decidido trabajar en global sobre
        // todo el conjunto del examen.
        public double CalculateArea(Planas figure)
        {
            figure.CalculateArea();
            return figure.AreaFigure;
        }
        // Tengo que seleccionar las figuras que pertenecen a la clase Planas para hacer funcionar la siguiente funcion
        // Lo que hace es sumar todas las areas de todas las figuras planas

        /*
        public double CalculateTotalArea()
        {
            double result = 0;
            for(int i = 0; i < _figureList.Count; i++)
            {                
                result += CalculateArea(_figureList[i]);
            }
            return result;
        }
        */
    }
}
