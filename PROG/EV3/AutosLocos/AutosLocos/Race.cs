﻿namespace AutosLocos
{
    public delegate bool DelegateObstacle(Obstacle obstacle);
    public delegate bool DelegateCar(Car car);
    public delegate bool DelegateRaceObject(RaceObject raceObjects);
    public class Race : IRace
    {
        private double _raceDistance;
        private List<RaceObject> _listObjects = new List<RaceObject>();

        private List<Car>? _winnersList = new List<Car>();
        private bool _IsWinner;

        #region FUNCIONES PUBLICAS
        public static void LaunchGame()
        {
            IRace race = new Race();
            race.PlayGame(race);
        }

        public void PlayGame(IRace race)
        {
            Init();
            AddPlayers();
            while (!_IsWinner)
            {
                SimulateStep(race);
                RemoveDeadObstacles();
                SetWinner();
            }
            UI.DisplayWinner(_winnersList);
        }

        public void Init(double distance = 1000)
        {
            _raceDistance = distance;
        }

        public void SimulateStep(IRace race)
        {
            for (int i = 0; i < _listObjects.Count; i++)
            {
                _listObjects[i].Simulate(race);
            }
        }

        public void AddObject(RaceObject raceObject)
        {
            if (raceObject == null)
                return;

            _listObjects.Add(raceObject);
        }

        public int GetObjectCount()
        {
            return _listObjects.Count;
        }

        public double GetRaceDistance()
        {
            return _raceDistance;
        }

        public RaceObject? GetObjectAt(int index)
        {
            if (index < 0 || index > _listObjects.Count)
                return null;

            return _listObjects[index];
        }

        public List<Obstacle> VisitObstacle(DelegateObstacle visitor)
        {
            if (visitor == null)
                return null;

            List<Obstacle> listResult = new List<Obstacle>();
            foreach (RaceObject obj in _listObjects)
            {
                if (obj is not Obstacle)
                    continue;
                if (visitor((Obstacle)obj))
                    listResult.Add((Obstacle)obj);
            }
            return listResult;
        }

        public List<Car> VisitCar(DelegateCar visitor)
        {
            if (visitor == null)
                return null;

            List<Car> listResult = new List<Car>();
            foreach (RaceObject obj in _listObjects)
            {
                if (obj is not Car)
                    continue;
                if (visitor((Car)obj))
                    listResult.Add((Car)obj);
            }
            return listResult;
        }
        #endregion

        #region FUNCIONES PRIVADAS
        private void AddPlayers()
        {
            Glamour glamourCar = new Glamour("Felicity", ObjectType.GLAMOURCAR);
            Troglodyte troglodyteCar = new Troglodyte("Grunt", ObjectType.TROGLODYTECAR);
            Wood woodCar = new Wood("Glam", ObjectType.WOODCAR);
            Pierre pierreCar = new Pierre("LeRot", ObjectType.PIERRECAR);

            Rock rockObject = new Rock(SetInitialPosition(), ObjectType.ROCK);
            Puddle puddleObject = new Puddle(SetInitialPosition(), ObjectType.PUDDLE);
            Bomb bombObject = new Bomb(SetInitialPosition(), ObjectType.BOMB);

            _listObjects.Add(glamourCar);
            _listObjects.Add(troglodyteCar);
            _listObjects.Add(woodCar);
            _listObjects.Add(pierreCar);
            _listObjects.Add(rockObject);
            _listObjects.Add(puddleObject);
            _listObjects.Add(bombObject);
        }

        private void SetWinner()
        {
            DelegateCar del = new DelegateCar((car) => car.Position > _raceDistance);
            List<Car> list = VisitCar(del);

            for (int i = 0; i < list.Count; i++)
            {
                _winnersList.Add(list[i]);
                _IsWinner = true;
            }
        }

        private double SetInitialPosition()
        {
            return Utils.GetRandom() * _raceDistance;
        }

        private void RemoveDeadObstacles()
        {
            for (int i = 0; i < _listObjects.Count; i++)
            {
                if (!_listObjects[i].IsAlive)
                {
                    _listObjects.RemoveAt(i--);
                }
            }
        }
        #endregion


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
        */
        #endregion
    }
}