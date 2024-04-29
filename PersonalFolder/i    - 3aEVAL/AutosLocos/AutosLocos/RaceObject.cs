namespace AutosLocos
{
    public enum ObjectType
    {
        ROCK,
        PUDDLE,
        BOMB,
        GLAMOURCAR,
        TROGLODYTECAR,
        WOODCAR,
        PIERRECAR
    }
    public abstract class RaceObject
    {
        protected string _name;
        protected double _position;
        protected int _disabledTurns;
        protected bool _alive;
        protected ObjectType _type;

        public bool Alive 
        {
            get => _alive;
            set => _alive = value;
        }        
        public ObjectType Type => _type;
        public string Name => _name;
        public double Position => _position;
        public void SetPosition(double value)
        {
            _position = value;
        }

        public RaceObject()
        {

        }

        public RaceObject(ObjectType objectType)
        {
            _type = objectType;
            _alive = true;
            _disabledTurns = 0;
        }

        public abstract void Simulate(IRace race);

        public void SetDisabledTurns(int turns)
        {
            _disabledTurns = turns;
        }

        #region · DOCUMENTACION
        /*  
        DOCUMENTACION PARA LA CLASE RACE · CONTROLADOR DE LA SIMULACION            

        ~ LaunchGame() : void
        Crea una instancia de IRace y llama a la funcion que inicia la carrera.

        + PlayGame(IRace) : void
        Ejecuta la simulacion de la carrera. Se compone de varias funciones, 
        funciones para crear los pilotos, un bucle while que ejecuta la simulacion hasta que existe un ganador,
        y funciones para visualizar los ganadores.

        + Init(distance) : void
        Crea la distancia de la carrera.

        + SimulateStep(IRace race) : void
        Recorre todos los objetos de la carrera y realiza la funcion que simula un turno de cada participante.

        + AddObject(RaceObject) : void
        Añade un objeto en la carrera.

        + GetObjectCount() : int
        Devuelve el numero de objetos 'vivos' en la carrera.

        + GetRaceDistance() : double
        Devuelve la distancia hasta la meta de la carrera.

        + GetObjectAt(index) : RaceObject?
        Devuelve el objeto que ocupa la posicion del indice en la lista.

        + VisitObstacles(DelegateObstacle) : void 
        Recorre todos los objetos de clase 'Obstacles' de la lista de objetos.
        
        + VisitCar(DelegateCar) : void 
        Recorre todos los objetos de clase 'Car' de la lista de objetos.

        - AddPlayer() : void
        Crea los coches y los obstaculos del juego en las posiciones que le indicamos por el constructor.

        - SetWinner(): void
        Establece el ganador o los ganadores de la carrera.

        - SetInitialPosition(): double
        Devuelve un doble con una posicion aleatoria dentro de la carrera.

        - RemoveDeadObstacles() : void
        Elimina de la lista de objetos de la carrera los obstaculos que no existen.        
       
        + SetDisabledTurns(turns) : void
        Establece el numero de turnos que el coche se encuentra averiado sin avanzar.
         */
        #endregion
    }
}