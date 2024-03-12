namespace DominoPractice
{
    public interface IGame
    {
        void SetPlayingPiece(Piece piece1, Piece piece2);
        List<Piece> GetPlayingPieceList();
    }
}
