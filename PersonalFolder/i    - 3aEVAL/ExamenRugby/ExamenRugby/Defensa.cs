namespace ExamenRugby
{
    public class Defensa : Player
    {        
        public Defensa() { }
        public Defensa(Team team, Position position) : base(team, position) { }
    

        public override void ExecuteTurn(IMatch match)
        {
            if (HasPlayerBall(match) == true)
                PlayWithBall(match);
            else
                PlayWithOutBall(match);
        }

        private bool HasPlayerBall(IMatch match)
        {
            return match.PlayerHasball(this);
        }


        // SI EL JUGADOR TIENE LA PELOTA

        private void PlayWithBall(IMatch match)
        {
            if (Utils.GetRandom() > 0.5)
                MoveToPuntuation(match);
            else
                Pass(match);
        }
        
        private void MoveToPuntuation(IMatch match)
        {
            if (_team.TeamLetter == 'A')
            {
                Position cell = new Position(_position.X, _position.Y--);
                if (match.IsEmptyPosition(cell))
                    _position = cell;
            }
            else
            {
                Position cell = new Position(_position.X, _position.Y++);
                if (match.IsEmptyPosition(cell))
                    _position = cell;
            }
        }
        private void Pass(IMatch match)
        {
            (Player bestPlayerA, Player bestPlayerB) = match.GetBestPositionedPlayer();
            int X, Y;

            if (Utils.GetRandom() < 0.6)    // ACIERTA EL PASE
            {
                if (Team.TeamLetter == 'A')
                {
                    X = bestPlayerA.Position.X;
                    Y = bestPlayerA.Position.Y;
                    match.SetBall(X, Y);
                }
                else
                {
                    X = bestPlayerB.Position.X;
                    Y = bestPlayerB.Position.Y;
                    match.SetBall(X, Y);
                }
            }

            else                            // FALLA EL PASE
            {
                int failPositionX = Utils.GetRandomInt(-2, 2);
                int failPositionY = Utils.GetRandomInt(-2, 2);
                if (Team.TeamLetter == 'A')
                {
                    X = bestPlayerA.Position.X + failPositionX;
                    Y = bestPlayerA.Position.Y + failPositionY;
                    match.SetBall(X, Y);
                }
                else
                {
                    X = bestPlayerB.Position.X + failPositionX;
                    Y = bestPlayerB.Position.Y + failPositionY;
                    match.SetBall(X, Y);
                }
            }
        }

        // SI EL JUGADOR NO TIENE LA PELOTA

        private void PlayWithOutBall(IMatch match)
        {
            if (IsBallNear(match))
                match.SetBall(_position);
            else if (IsOponentNear(match))
                TryStealingBall();
            else if (Utils.GetRandom() > 0.5)
                ChaseOponent(match);
            else
                MoveToBall(match);
        }

        private void MoveToBall(IMatch match)
        {
            // El jugador se mueve HACIA LA POSICION DE LA PELOTA
            // El QBool le indica si SU POSICION ES MAYOR O MENOR QUE LA POSICION DE LA PELOTA

            (bool XCoord, bool YCoord) ballPosition = (match.BallPosition.X > Position.X, match.BallPosition.Y > Position.Y);
            double verticalHorizontalMove = Utils.GetRandom();

            // Hace un random para avanzar en EL EJE X O EN EL EJE Y
            if (verticalHorizontalMove < 0.5)
            {
                if (ballPosition.XCoord)
                    Position.X++;
                else
                    Position.X--;
            }
            else
            {
                if (ballPosition.YCoord)
                    Position.Y++;
                else
                    Position.Y--;
            }
        }        
    }
}