namespace DominoPractice
{
    public class Impulsive : Player
    {
        /*
        private override void SimulateImpulsivo(IGame game)
        {
            List<Piece> playingPieces = game.GetPlayingPieceList();
            Piece piece1 = playingPieces[0];
            Piece piece2 = playingPieces[1];

            List<Piece> selectedPieces = SortImpulsive(_handPieces);

            for (int i = 0; i < selectedPieces.Count; i++)
            {
                if (selectedPieces[i].Up == piece1.Down)
                {
                    game.SetPlayingPiece(selectedPieces[i], piece1);
                    selectedPieces.RemoveAt(i--);
                }
                else if (selectedPieces[i].Down == piece2.Up)
                {
                    game.SetPlayingPiece(selectedPieces[i], piece2);
                    selectedPieces.RemoveAt(i--);
                }
            }
        }

        private List<Piece> SortImpulsive(List<Piece> hand)
        {
            List<Piece> result = new List<Piece>();
            for (int i = 0; i < hand.Count; i++)
            {
                if (hand[i].Doble)
                    result.Add(hand[i]);
            }
            for (int i = 0; i < hand.Count; i++)
            {
                result.Add(hand[i]);
            }
            return result;
        }
        */
    }
}
