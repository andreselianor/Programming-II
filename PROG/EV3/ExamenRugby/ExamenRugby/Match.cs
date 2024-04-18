namespace ExamenRugby
{
    public class Match : IMatch
    {
        private Ball _ball = new Ball();
        private List<Player> _playersList = new List<Player>();
        private List<Team> _listTeams = new List<Team>();

        private int _widthBoard = 10;
        private int _heightBoard = 20;
        
        public void Init()
        {
            CreateTeams();
            CreatePlayers();
            SetBall(_widthBoard, _heightBoard);
        }

        public void ExecuteRound()
        {

        }


        // Funciones privadas
        private void CreateTeams()
        {
            Team teamA = new Team("Equipo A");
            Team teamB = new Team("Equipo B");

            _listTeams.Add(teamA);
            _listTeams.Add(teamB);
        }

        private void CreatePlayers()
        {
            CreatePlayersTeam();
        }

        private void SetBall(int widthBoard, int heightBoard)
        {
            _ball.SetInitialPosition(widthBoard, heightBoard);
        }

        private void CreatePlayersTeam()
        {
            // Equipo A
            Team teamA = _listTeams[0];
            for(int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 2);
                Player delantero = new Delantero(teamA, position);
                _playersList.Add(delantero);
            }
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 1);
                Player delantero = new Defensa(teamA, position);
                _playersList.Add(delantero);
            }

            // Equipo B
            Team teamB = _listTeams[1];
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 18);
                Player delantero = new Delantero(teamB, position);
                _playersList.Add(delantero);
            }
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 19);
                Player delantero = new Defensa(teamB, position);
                _playersList.Add(delantero);
            }
        }
    }
}