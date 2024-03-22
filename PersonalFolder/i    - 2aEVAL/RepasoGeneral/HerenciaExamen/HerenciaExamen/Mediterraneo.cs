namespace HerenciaExamen
{
    public abstract class Mediterraneo : España
    {
        protected string _mediterraneanSea = "Mediterraneo";

        public override string GetSea()
        {
            return _mediterraneanSea;
        }
    }
}
