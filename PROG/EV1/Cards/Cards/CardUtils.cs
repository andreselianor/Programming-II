namespace Cards
{
    public class CardUtils
    {
        public static int GetBlackJackValue(List<Card> listCards)
        {
            int result = 0;

            foreach(Card card in listCards)
            {
                result += CalculateValueCard(card);
            }

            return result;
        }

        public static int CalculateValueCard(Card card)
        {
            if (card.GetFigureType() == TypeCard.AS)
                return 1;
            if (card.GetFigureType() == TypeCard.JACK ||
                card.GetFigureType() == TypeCard.QUEEN ||
                card.GetFigureType() == TypeCard.KING)
                return 10;
            else
                return card.GetNumber();
        }
    }
}
