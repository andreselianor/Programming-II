namespace Carrera
{
    public class Utils
    {
        private static Random random = new Random();

        public static double GetRandom()
        {
            return random.NextDouble();
        }

        public static int GetRandom(int min, int max)
        {
            return random.Next(min, max);
        }
    }
    public class Race
    {
        private double _distance;
        List<Runner> _runnersList = new List<Runner>();

        public List<Runner> RunnersList => _runnersList;

        public void CreateRace(int numberRunners, double raceDistance)
        {
            for(int i = 0; i < numberRunners; i++)
            {
                Runner runner = new Runner();
                _runnersList.Add(runner);
            }
            _distance = raceDistance;
        }

        public void Simulate()
        {
            for(int i = 0; i < _runnersList.Count; i++)
            {
                _runnersList[i].Move();
            }
        }

        public int GetRunnersCount()
        {
            return _runnersList.Count;
        }

        public Runner GetRunnerAt(int index)
        {
            return _runnersList[index];
        }

        public void RemoveAt(int index)
        {
            _runnersList.RemoveAt(index);
        }

        public bool IsWinner()
        {
            for(int i = 0; i < _runnersList.Count; i++)
            {
                if (_runnersList[i].Position >= _distance)
                    return true;
            }
            return false;
        }

        public Runner GetWinner()
        {
            Runner winner = new Runner();
            if(IsWinner())
            {                
                for(int i = 0; i < _runnersList.Count; i++)
                {
                    if (_runnersList[i].Position >= _distance)
                    {
                        return _runnersList[i];
                    }
                }                
            }
            return winner;
        }

        public List<Runner> GetWinnerList()
        {
            List<Runner> listWinner = new List<Runner>();

            if (IsWinner())
            {
                for (int i = 0; i < _runnersList.Count; i++)
                {
                    if (_runnersList[i].Position >= _distance)
                    {
                        listWinner.Add(_runnersList[i]);
                    }
                }                
            }
            return listWinner;
        }

        public Runner? GetRunnerWithName(string name)
        {
            for(int i = 0; i < _runnersList.Count; i++)
            {
                if (_runnersList[i].Name == name)
                {
                    return _runnersList[i];
                }
            }
            return null;
        }

        public Team GetWinnerTeam()
        {
            Runner winner = new Runner();
            winner = GetWinner();
            return winner.Team;
        }

        public static int GetTeamCount(Team team, List<Runner> listRunner)
        {
            int count = 0;
            for(int i = 0; i < listRunner.Count; i++)
            {
                if (listRunner[i].Team == team)
                    count++;
            }
            return count;
        }

        public static double GetAverageDistance(Team team, List<Runner> listRunner)
        {
            int count = 0;
            for(int i = 0; i < listRunner.Count; i++)
            {
                if (listRunner[i].Team == team)
                {
                    count++;
                }
            }

            return count / GetTeamCount(team, listRunner);

        }
    }
}