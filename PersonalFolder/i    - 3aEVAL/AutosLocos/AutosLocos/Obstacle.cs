namespace AutosLocos
{
    public abstract class Obstacle : RaceObject
    {
        public Obstacle() { }
        public Obstacle(double position, ObjectType objectType) : base(objectType)
        {
            _position = position;
        }


        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE OBSTACLE · OBJETO TRAMPA DE LA CARRERA            

        (P) bool IsEmpty;

        |#| Set() {}

        + SetPosition() : void
        Funcion que añade un objeto trampa en una posicion aleatoria de la carrera.

        */
        #endregion
    }
}