namespace Carrera
{
    public enum Team
    {
        TEAMA,
        TEAMB,
        TEAMC
    }
    public class Runner
    {
        private string _name = "";
        private double _velocity;
        private double _position;
        private Team _team;
        private int _id;


        public Runner()
        {
            _velocity = Utils.GetRandom(0, 10);
        }

        public Runner(string name, double position, Team team, int id)
        {
            _name = name;
            _position = position;
            _team = team;
            _id = id;
        }

        public double Position => _position;
        public string Name => _name;
        public Team Team => _team;

        public void Move()
        {
            double runnerDistance = _velocity * Utils.GetRandom();
            _position += runnerDistance;
        }


    }
}
