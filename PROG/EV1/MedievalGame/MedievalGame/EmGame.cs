namespace MedievalGame
{
    public class EmGame
    {
        private Warzone _scenary;
        private bool _teamWinner;

        public void CreateScenary()
        {
            _scenary = new Warzone();
        }

        public void Play()
        {
            while (TeamsFighting())
            {
                _scenary.Team1Fight();
                _scenary.Team2Fight();
                _scenary.TeamHealer();
                _scenary.TeamMorale();
            }
        }

        public bool TeamsFighting()
        {
            return true;
        }
    }
}
