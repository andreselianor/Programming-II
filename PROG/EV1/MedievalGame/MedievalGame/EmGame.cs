namespace MedievalGame
{
    public class EmGame
    {
        private Warzone _warzone;
        private int _teamWinner;
        private int _widthScenary = 100;
        private int _heightScenary = 100;

        public void Load()
        {
            CreateScenary(_widthScenary, _heightScenary);

            while (AreTeamsFighting())
            {
                public void ExecuteTurn()
                {
                    
                }
            }

            WinnerPlayer(_teamWinner);
        }

        public void CreateScenary(int widthScenary, int heightScenary)
        {
            _warzone = new Warzone(widthScenary, heightScenary);
        }

        public void ExecuteTurn()
        {
            for (int i = 0; i < _warriorList.Count; i++)
                _warriorList[i].ExecuteRound(_warzone);
        }
        public bool AreTeamsFighting()
        {
            
            return (_warzone.PlayerDefeated() == 0);
        }

        public string WinnerPlayer(int teamNumber)
        {
            return $"El ganador es el jugador {teamNumber}";
        }
    }
}
