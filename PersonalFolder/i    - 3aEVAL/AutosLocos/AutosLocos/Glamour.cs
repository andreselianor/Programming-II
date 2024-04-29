namespace AutosLocos
{
    public class Glamour : Car
    {
        public Glamour() { }
        public Glamour(string name, ObjectType type) : base(name, type)
        {
            
        }

        public override void Simulate(IRace race)
        {
            if (_disabledTurns < 1)
            {
                _position += 20.0 + FineTunning;
            }

            if (_disabledTurns > 0)
                _disabledTurns -= 1;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE GLAMOUR · PILOTO DE CARRERA

        + Simulate(IRace) : void
        Simula un turno de la carrera para el coche glamour.

        */
        #endregion
    }
}
