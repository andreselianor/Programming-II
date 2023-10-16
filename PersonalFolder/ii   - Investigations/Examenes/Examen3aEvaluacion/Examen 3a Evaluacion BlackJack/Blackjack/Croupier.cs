using Blackjack;

namespace Blackjack
{
    public class Croupier
    {
        public void CreateNewDeck()
        {

        }

        public static int CalculateSumCards(List<Carta> listaCartas)
        {
            int result = 0;
            for(int i = 0; i< listaCartas.Count; i++)
            {
                result += listaCartas[i].Value;
            }

            return result;
        }
    }
}
