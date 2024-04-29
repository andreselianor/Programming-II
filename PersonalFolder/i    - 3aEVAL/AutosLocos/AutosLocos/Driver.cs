namespace AutosLocos
{
    public abstract class Driver
    {
        public abstract double GetVelocityExtra();
    }

    #region · DOCUMENTACION
    /*  
    DOCUMENTACION PARA LA CLASE DRIVER · MODIFICADORES PROPIOS DE LOS COPILOTOS       
    Dependiendo del copiloto que tenga el coche, se devuelve un valor entero extra al avance de cada coche.

    + GetVelocityExtra : double
    Devuelve un valor entero random entre -1.0 y 3.0.

    */
    #endregion
}
