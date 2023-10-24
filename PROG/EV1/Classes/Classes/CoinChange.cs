namespace Classes
{
    public enum Moneda
    {
        COIN_50000,
        COIN_20000,
        COIN_10000,
        COIN_5000,
        COIN_2000,
        COIN_1000,
        COIN_500,
        COIN_200,
        COIN_100,
        COIN_50,
        COIN_20,
        COIN_10,
        COIN_5,
        COIN_2,
        COIN_1
    }

    public class CoinChange
    {
        public static int ToNumber(Moneda moneda)
        {
            if (moneda == Moneda.COIN_50000)
                return 50000;
            else
                return 1;
        }

        public static Moneda ToMoneda(int centimos)
        {
            if (centimos == 50000)
                return Moneda.COIN_5000;
            else
                return Moneda.COIN_1;
        }

        public static List<Moneda> GetCoins(int money)
        {
            List<Moneda> listResult = new List<Moneda>();
            int centims = money;
            

            while (money >= 1)
            {
                if (centims > 50000)
                {
                    ExchangeMoney500(money);
                }

                if (centims > 20000)
                {
                    rest = centims / 20000;
                    centims = money % 20000;
                    for (int i = 0; i < rest; i++)
                        listResult.Add(Moneda.COIN_5000);
                }
            }

            return listResult;
        }

        public static int ExchangeMoney500(int money)
        {
            List<Moneda> listResult = new List<Moneda>();
            int rest = 0;
            int centims = money;

            rest = centims / 50000;
            centims = money % 50000;
            for (int i = 0; i < rest; i++)
                listResult.Add(Moneda.COIN_5000);
        }
    }
}
