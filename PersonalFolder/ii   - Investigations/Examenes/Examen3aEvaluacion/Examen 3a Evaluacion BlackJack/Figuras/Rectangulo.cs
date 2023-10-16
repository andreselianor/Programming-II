namespace Figuras
{
    public class Rectangulo : Planas
    {
        private double _coord1X;
        private double _coord1Y;
        private double _coord2X;
        private double _coord2Y;
        

        public Rectangulo(string nombre, double Coordenada1X, double Coordenada1Y, double Coordenada2X, double Coordenada2Y) : base(nombre)
        {
            _coord1X = Coordenada1X;
            _coord1Y = Coordenada1Y;
            _coord2X = Coordenada2X;
            _coord2Y = Coordenada2Y;
        }

        public override void CalculateArea()
        {
            double ladoLargo = _coord2X - _coord1X;
            double ladoCorto = _coord2Y - _coord1Y;
            AreaFigure = ladoLargo * ladoCorto;
        }
    }
}
