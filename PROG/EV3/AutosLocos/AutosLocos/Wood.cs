namespace AutosLocos
{
    public class Wood : Car
    {
        public Wood() { }
        public Wood(string name, ObjectType type) : base(name, type)
        {

        }
        public override void Simulate(IRace race)
        {
            if (_disabledTurns < 1)
            {
                _position += 15.0 + FineTunning;
            }
            else
            {
                ReactivateCar();
            }

            if (_disabledTurns > 0)
                _disabledTurns -= 1;
        }

        private void ReactivateCar()
        {
            double chance = Utils.GetRandom();
            if (chance < 0.6)
                _disabledTurns = 0;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE WOOD · PILOTO DE CARRERA

        + Simulate(IRace) : void
        Simula un turno de carrera.

        + ReactivateCar() : void
        Si una tirada random es menor que el valor indicado, el coche elimina su estado desactivado.
        */
        #endregion
    }
}
