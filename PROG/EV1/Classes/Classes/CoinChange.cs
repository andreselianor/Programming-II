using System.ComponentModel;

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
                return Moneda.COIN_50000;
            else
                return Moneda.COIN_1;
        }

        public static List<Moneda> GetCoins(int money)
        {
            List<Moneda> listResult = new List<Moneda>();
            int centimsResult = money;
            

            while (centimsResult > 0)
            {
                if (centimsResult > 50000)
                {
                    listResult = ExchangeListResult(centimsResult, listResult);
                    centimsResult = ExchangeResult(centimsResult);
                }
            }

            return listResult;
        }

        public static List<Moneda> ExchangeListResult(int money, List<Moneda> listExchange)
        {
            int numberBills = money / 500000;
            for (int i = 0; i < numberBills; i++)
            {
                listExchange.Add(Moneda.COIN_50000);
            }
            return listExchange;
        }

        public static int ExchangeResult(int money)
        {
            return money % 50000;
        }        
    }
}
