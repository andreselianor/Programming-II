namespace AutosLocos
{
    public abstract class Car : RaceObject
    {
        protected double _fineTunning;

        public double FineTunning => _fineTunning;

        public Car() { }
        public Car(string name, ObjectType type) : base(type)
        {
            _fineTunning = SetFineTunning();
            _position = 0.0;
            _name = name;
        }

        public double SetFineTunning()
        {
            return Utils.GetRandom() * 2 + 1; 
        }


        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE CAR · OBJETO MOVIL DE LA CARRERA            
        Clase abstracta de la que heredan los distintos pilotos de la carrera.

        |#| Car() {}
        |#| Car(name, type) : base(name, type) {}

        + SetFineTunning() : double
        Devuelve un numero aleatorio entre 1 y 3. Este numero se añade a la posicion recorrida cada turno.
        
        */
        #endregion
    }
}