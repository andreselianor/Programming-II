namespace Domino
{
    public interface IGame
    {
        void InitPlay();
        void InitPlayers();
        void MoveStack(int number);
        void GiveChips();
        void Execute();
        List<Ficha> ActualStack();
        Jugador Winner();
    }
}
