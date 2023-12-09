namespace CrazyCars
{
    public interface IRace
    {
        void Init(double distance);
        List<RaceObject> Simulate(IRace race);
        void PrintRacers();
        int GetObjectsCount();
        RaceObject GetRaceObjectAt(int index);
    }
}
