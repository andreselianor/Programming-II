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

        void VisitCar(DelegateCar visitor);
        void VisitObstacle(DelegateObstacle visitor);

        List<Car> Sort();
    }
}