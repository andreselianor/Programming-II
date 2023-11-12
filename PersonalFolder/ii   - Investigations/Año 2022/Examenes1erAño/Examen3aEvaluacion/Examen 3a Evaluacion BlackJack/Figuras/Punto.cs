namespace Figuras
{
    public class Punto : Lineales
    {
        private double _coordX;
        private double _coordY;

        public Punto(string nombre, double coordenadaX, double coordenadaY) : base(nombre)
        {
            _coordX = coordenadaX;
            _coordY = coordenadaY;
        }
    }
}
