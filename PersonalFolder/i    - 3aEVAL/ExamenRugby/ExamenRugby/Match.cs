namespace ExamenRugby
{
    public delegate void DelegateVisit(Character character);
    public class Match : IMatch
    {
        private Ball _ball = new Ball();
        private List<Player> _playersList = new List<Player>();
        private List<Character> _dementoresList = new List<Character>();
        private List<Team> _listTeams = new List<Team>();
        private int _puntuationA;
        private int _puntuationB;

        private int _widthBoard = 10;
        private int _heightBoard = 20;

        Position BallPosition => _ball.Position;

        public void Init()
        {
            CreateTeams();
            CreateCharacters();
            SetBallInitial(_widthBoard, _heightBoard);
        }

        public void ExecuteRound(IMatch match)
        {
            foreach (Character character in _playersList)
            {
                character.ExecuteTurn(match);
            }

            if (HasTeamScored())
            {
                Init();
            }            
        }


        // Funciones privadas
        private void CreateTeams()
        {
            Team teamA = new Team('A');
            Team teamB = new Team('B');

            _listTeams.Add(teamA);
            _listTeams.Add(teamB);
        }

        private void CreateCharacters()
        {
            CreateCharactersMatch();
        }

        private void SetBallInitial(int widthBoard, int heightBoard)
        {
            _ball.SetInitialPosition(widthBoard, heightBoard);
        }

        #region Creacion de Personajes
        private void CreateCharactersMatch()
        {
            // Equipo A
            Team teamA = _listTeams[0];
            for (int i = 3; i < 7; i++)
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
            {
                Position position = new Position(0, 2);
                Player defensaEspecial = new DefensaEspecial(teamA, position);
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
                Player delantero = new Delantero(teamB, position);
                _playersList.Add(delantero);
            }
            for (int i = 3; i < 7; i++)
            {
                Position position = new Position(i, 19);
                Player delantero = new Defensa(teamB, position);
                _playersList.Add(delantero);
            }
            {
                Position position = new Position(19, 2);
                Player defensaEspecial = new DefensaEspecial(teamA, position);
                _playersList.Add(defensaEspecial);
                position = new Position(19, 7);
                defensaEspecial = new DefensaEspecial(teamA, position);
                _playersList.Add(defensaEspecial);
            }

            // Dementores
            for (int i = 0; i < 4; i++)
            {
                int positionX = Utils.GetRandomInt(_widthBoard);
                int positionY = Utils.GetRandomInt(_heightBoard);
                Position position = new Position(positionX, positionY);
                Character dementor = new Dementor(position);
                _dementoresList.Add(dementor);
            }
        }
        #endregion

        private Player? PlayerHasBall()
        {
            for (int i = 0; i < _playersList.Count; i++)
            {
                if (_playersList[i].Position == _ball.Position)
                    return _playersList[i];
            }
            return null;
        }

        private bool PlayerHasball(Player player)
        {
            return (player.Position.X == _ball.Position.X && player.Position.Y == _ball.Position.Y);
        }

        private bool HasTeamScored()
        {
            for (int i = 0; i < _playersList.Count; i++)
            {
                if (_playersList[i] == PlayerHasBall() && GoalPosition())
                {
                    int puntuacion = 0;

                    if (_playersList[i] is Defensa)
                        puntuacion = 3;
                    else if (_playersList[i] is Delantero)
                        puntuacion = 10;
                    else
                        puntuacion = 1;

                    if (_playersList[i].Team == _listTeams[0])
                        _puntuationA += puntuacion;
                    else
                        _puntuationB += puntuacion;
                    return true;
                }
            }
            return false;
        }

        private bool GoalPosition()
        {
            return (_ball.Position.Y < 1 || _ball.Position.Y > 19);
        }

        public Team Winner()
        {
            return _puntuationA > _puntuationB ? _listTeams[0] : _listTeams[1];
        }

        public (Player, Player) GetBestPositionedPlayer()
        {
            (Player playerTeamA, Player playerTeamB) result = (_playersList[0], _playersList[1]);

            for(int i = 0; i < _playersList.Count; i++)
            {
                if (_playersList[i].Team == _listTeams[0])
                {
                    if (_playersList[i].Position.Y > result.playerTeamA.Position.Y)
                        result.playerTeamA = _playersList[i];
                }
                else
                {
                    if (_playersList[i].Position.Y < result.playerTeamB.Position.Y)
                        result.playerTeamA = _playersList[i];
                }
            }
            return result;
        }

        public void SetBall(int x, int y)
        {
            _ball.SetBallToPosition(x,y);
        }


        public void Visit(DelegateVisit visitor)
        {
            for(int i = 0; i < _playersList.Count;i++)
            {
                visitor(_playersList[i]);
            }
        }

        public bool IsEmptyPosition(Position position)
        {
            return GetPlayerWithPosition(position) != null;
        }

        public Player GetPlayerWithPosition(Position position)
        {
            for(int i = 0; i < _playersList.Count;i++)
            {
                if (_playersList[i].Position == position)
                    return _playersList[i];
            }
            return null;
        }

        public int GetIndexOf(Player player)
        {
            for(int i = 0; i < _playersList.Count;i++)
            {
                if (player == _playersList[i])
                    return i;
            }
            return -1;
        }
        public Player GetPlayerAt(int index)
        {
            return _playersList[index];
        }

        public bool Contains(Player player)
        {
            return GetIndexOf(player) != -1;
        }
    }
}