namespace AutosLocos
{
    public interface IRace
    {
        void Init(double distance);

        void SimulateStep(IRace race);
        void AddObject(RaceObject raceObject);

        int GetObjectCount();
        RaceObject? GetObjectAt(int index);

        void PlayGame(IRace race);

        List<Car> VisitCar(DelegateCar visitor);
        List<Obstacle> VisitObstacle(DelegateObstacle visitor);
    }
}