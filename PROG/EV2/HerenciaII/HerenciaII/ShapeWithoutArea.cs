namespace HerenciaII
{
    public class ShapeWithoutArea : Shape
    {
        public override double GetArea()
        {
            return 0.0;
        }

        public override bool HasArea()
        {
            return false;
        }
    }
}
