namespace MedievalGame
{
    public class EmGame
    {
        private Warzone _scenary;
        private int _teamWinner;
        private int _widthScenary = 100;
        private int _heightScenary = 100;

        public void Load()
        {
            CreateScenary(_widthScenary, _heightScenary);

            while (AreTeamsFighting())
            {
                _scenary.Team1Fight();
                _scenary.Team2Fight();
                _scenary.TeamHealer();
                _scenary.TeamMorale();

                _scenary.FinalPhase();                
            }

            WinnerPlayer(_teamWinner);
        }

        public void CreateScenary(int widthScenary, int heightScenary)
        {
            _scenary = new Warzone(widthScenary, heightScenary);
        }

        public bool AreTeamsFighting()
        {
            
            return (_scenary.PlayerDefeated() == 0);
        }

        public string WinnerPlayer(int teamNumber)
        {
            return $"El ganador es el jugador {teamNumber}";
        }
    }
}
