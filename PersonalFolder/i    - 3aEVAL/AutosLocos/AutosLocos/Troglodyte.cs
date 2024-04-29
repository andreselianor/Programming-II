namespace AutosLocos
{
    public class Troglodyte : Car
    {

        public Troglodyte() { }
        public Troglodyte(string name, ObjectType type) : base(name, type)
        {

        }
        public override void Simulate(IRace race)
        {
            if (_disabledTurns < 1)
            {
                _position += 10.0 + FineTunning;
                ExtraMovement();
            }

            if (_disabledTurns > 0)
                _disabledTurns -= 1;
        }

        private void ExtraMovement()
        {
            double chance = Utils.GetRandom();
            if (chance < 0.3)
            {
                if (chance < 0.4)
                    _position += 20;
                else if (0.4 < chance && chance < 0.6)
                    SetDisabledTurns(1);
            }
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE TROGLODYTE · PILOTO DE CARRERA

        + GetVelocityExtra : double
        Devuelve un valor entero random entre -1.0 y 3.0.

        */
        #endregion
    }
}