namespace HerenciaExamen
{
    public static class Core
    {
        public static void Launch(ICountry country)
        {
            Controlador controller = new Controlador();
            controller.Start(country);
        }
    }
}
