﻿namespace DominoPractice
{
    public interface IGame
    {
        void InitGame();
        bool ArePlayersPlaying();
        void InitRound(IGame game);
        Player WinnerPlayer();

        void SetPlayingPiece(Piece piece1, Piece piece2);
        List<Piece> GetPlayingPieceList();
    }
}