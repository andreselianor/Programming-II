namespace ExamenYvesElianor
{
    public class Color
    {
        private double _R;
        private double _G;
        private double _B;
        private double _A;

        public double R => _R;
        public double G => _G;
        public double B => _B;
        public double A => _A;
        
        public Color() { }
        public Color(double r, double g, double b, double a)
        {
            _R = r;
            _G = g;
            _B = b;
            _A = a;
        }
    }
}