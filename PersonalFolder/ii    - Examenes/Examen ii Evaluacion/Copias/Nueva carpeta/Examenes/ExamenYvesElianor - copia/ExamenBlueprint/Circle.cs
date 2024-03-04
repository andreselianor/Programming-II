using System.Drawing;

namespace ExamenBlueprint
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
    }
}
