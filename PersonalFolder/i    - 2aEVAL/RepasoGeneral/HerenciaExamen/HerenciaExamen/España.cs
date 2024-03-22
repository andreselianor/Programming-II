namespace HerenciaExamen
{
    public abstract class España : IEuropa
    {
        protected double _population = 500;
        public double _PIB;
        public double Population => _population;
        public double PIB => _PIB;

        public abstract string GetName();

        public abstract double GetPIB();
        public abstract string GetSea();
    }
}

