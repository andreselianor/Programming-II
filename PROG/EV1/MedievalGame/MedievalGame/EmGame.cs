namespace MedievalGame
{
    public class EmGame
    {
        private Warzone _warzone;

        private int _widthWarzone = 100;
        private int _heightWarzone = 100;

        private bool _areWarriorsAlive;
        private string _winner;

        public void Load()
        {
            CreateWarzone(_widthWarzone, _heightWarzone);

            while (_areWarriorsAlive)
            {
                ExecuteTurn(_warzone);
                ExecuteFinalPhase();
            }

            WinnerPlayer(_winner);
        }

        public void CreateWarzone(int widthScenary, int heightScenary)
        {
            _warzone = new Warzone(widthScenary, heightScenary);
        }

        public void ExecuteTurn(Warzone warzone)
        {
            List<Warrior> warriorsList;
            warriorsList = _warzone.GetWarriorList();
            for (int i = 0; i < warriorsList.Count; i++)
            {
                warriorsList[i].ExecuteWarrior(_warzone);
            }
        }

        public void ExecuteFinalPhase()
        {
            if (_warzone.GetWarriorListCount() == 1)
                _winner = "El ganador es: ";
        }

        public string WinnerPlayer(string Team)
        {
            return $"El ganador es el equipo {Team}";
        }
    }
}
