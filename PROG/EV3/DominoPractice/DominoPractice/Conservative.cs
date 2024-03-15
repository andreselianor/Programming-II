namespace DominoPractice
{
    public class Conservative : Player
    {
        public Conservative() { }
        public Conservative(int number) : base(number) { }
        public override void Simulate(IGame game)
        {
            SimulateConservador(game);
        }

        public void SimulateConservador(IGame game)
        {
            List<Piece> playingPieces = game.GetPlayingPieceList();
            Piece piece1 = playingPieces[0];
            Piece piece2 = playingPieces[1];

            List<Piece> selectedPieces = SortConservative(_handPieces);

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

        public List<Piece> SortConservative(List<Piece> hand)
        {
            List<Piece> result = new List<Piece>();
            int valuePiece = 13;
            Piece aux;
            for (int i = 0; i < hand.Count; i++)
            {
                for (int j = i + 1; j < hand.Count - 1; j++)
                {
                    if (hand[j].Value < valuePiece)
                    {
                        aux = hand[j];
                        hand[j] = hand[j + 1];
                        hand[j + 1] = aux;
                    }
                }
            }
            return result;
        }
    }
}
