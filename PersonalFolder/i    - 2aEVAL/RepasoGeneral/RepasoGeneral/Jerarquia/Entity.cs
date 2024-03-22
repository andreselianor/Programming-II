namespace RepasoGeneral.Jerarquia
{
    public abstract class Entidad
    {
        public int Number;

        public Entidad()
        {

        }
        public Entidad(int number)
        {
            Number = number;
        }

        public virtual int FunctionNumber1(int alterNumber)
        {
            return 1;
        }

        public abstract int FunctionNumber2(int alterNumber);
    }
}
