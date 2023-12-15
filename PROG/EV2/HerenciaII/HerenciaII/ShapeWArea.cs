namespace HerenciaII
{
    public abstract class ShapeWArea : Shape
    {
        public override double GetArea()
        {
            return 0.0;
        }
        public override bool HasArea()
        {
            return true;
        }
    }
}
