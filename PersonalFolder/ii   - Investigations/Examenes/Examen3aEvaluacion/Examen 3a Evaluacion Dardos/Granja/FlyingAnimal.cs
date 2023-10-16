namespace Granja
{
    public class FlyingAnimal : Animal, IFlying
    {
        protected bool _isFlying;
        protected DateTime _lastOviparation;

        public bool IsFlying()
        {
            return _isFlying;
        }
    }
}
