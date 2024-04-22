namespace ExamenRugby
{
    public class Match : IMatch
    {
        private Ball _ball = new Ball();
        private List<Character> _playersList = new List<Character>();
        private List<Team> _listTeams = new List<Team>();

        private int _widthBoard = 10;
        private int _heightBoard = 20;
        
        public void Init()
        {
            CreateTeams();
            CreateCharacters();
            SetBall(_widthBoard, _heightBoard);
        }

        public void ExecuteRound(IMatch match)
        {
            foreach(Character character in _playersList)
            {
                character.ExecuteTurn(match);
            }

            if (HasTeamScored())
                Init();
        }


        // Funciones privadas
        private void CreateTeams()
        {
            Team teamA = new Team("Equipo A");
            Team teamB = new Team("Equipo B");

            _listTeams.Add(teamA);
            _listTeams.Add(teamB);
        }

        private void CreateCharacters()
        {
            CreateCharactersMatch();
        }

        private void SetBall(int widthBoard, int heightBoard)
        {
            _ball.SetInitialPosition(widthBoard, heightBoard);
        }

        private void CreateCharactersMatch()
        {
            // Equipo A
            Team teamA = _listTeams[0];
            for(int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 2);
                Character delantero = new Delantero(teamA, position);
                _playersList.Add(delantero);
            }
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 1);
                Character delantero = new Defensa(teamA, position);
                _playersList.Add(delantero);
            }            
            {
                Position position = new Position(0, 2);
                Character defensaEspecial = new DefensaEspecial(teamA, position);
                _playersList.Add(defensaEspecial);
                position = new Position(0, 7);
                defensaEspecial = new DefensaEspecial(teamA, position);
                _playersList.Add(defensaEspecial);
            }

            // Equipo B
            Team teamB = _listTeams[1];
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 18);
                Character delantero = new Delantero(teamB, position);
                _playersList.Add(delantero);
            }
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 19);
                Character delantero = new Defensa(teamB, position);
                _playersList.Add(delantero);
            }
            {
                Position position = new Position(19, 2);
                Character defensaEspecial = new DefensaEspecial(teamA, position);
                _playersList.Add(defensaEspecial);
                position = new Position(19, 7);
                defensaEspecial = new DefensaEspecial(teamA, position);
                _playersList.Add(defensaEspecial);
            }

            // Dementores
            for(int i = 0; i < 4; i++)
            {
                int positionX = Utils.GetRandomInt(_widthBoard);
                int positionY = Utils.GetRandomInt(_heightBoard);
                Position position = new Position(positionX, positionY);
                Character dementor = new Dementor(position);
                _playersList.Add(dementor);
            }
        }

        public bool HasTeamScored()
        {
            return (_ball.Position.Y < 1 || _ball.Position.Y > 18);
        }
    }
}