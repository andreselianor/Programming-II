namespace CrazyCars
{
    public class Obstacle : RaceObject
    {
        public Obstacle() : base()
        {
            double randomPosition = Utils.GetRandomDouble(0.0, 100.0);
            Position = randomPosition;
        }
    }
}
