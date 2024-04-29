namespace ExamenRugby
{
    public interface IMatch
    {
        Position BallPosition { get; }

        void SetBall(int x, int y);
        void Init();
        void ExecuteRound(IMatch match);

        Team Winner();
        bool PlayerHasball(Player player);


        (Player, Player) GetBestPositionedPlayer();
        bool IsEmptyPosition(Position position);
    }
}