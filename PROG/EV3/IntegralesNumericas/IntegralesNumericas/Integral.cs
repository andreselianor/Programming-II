namespace IntegralesNumericas
{
    public delegate double DelegateIntegral(double x);
    public static class Integral
    {
        public static double GetAreaWithIntegral(DelegateIntegral delegado, double x0, double x1, double dx)
        {
            double result = 0.0;
            while(x0 <= x1)
            {
                result += dx * delegado(x0);
                x0 += dx;
            }
            return result;
        }
    }
}
