namespace AutosLocos
{
    public class Animal : Driver
    {
        public override double GetVelocityExtra()
        {
            return Utils.GetRandom() * 4 - 1;
        }
    }
}