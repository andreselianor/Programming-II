namespace Figuras
{
    public class Circulo : Planas
    {
        private double _coord1X;
        private double _coord1Y;
        private double _coord2X;
        private double _coord2Y;

        public Circulo(string nombre, double Coordenada1X, double Coordenada1Y, double Coordenada2X, double Coordenada2Y) : base(nombre)
        {
            _coord1X = Coordenada1X;
            _coord1Y = Coordenada1Y;
            _coord2X = Coordenada2X;
            _coord2Y = Coordenada2Y;
        }

        public override void CalculateArea()
        {

        }
    }
}
