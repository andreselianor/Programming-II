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
            int result = 0;
            switch (moneda)
            {
                case Moneda.COIN_10000:
                    result = 10000;
                    break;
                case Moneda.COIN_1000:
                    result = 1000;
                    break;
                case Moneda.COIN_100:
                    result = 100;
                    break;
                case Moneda.COIN_10:
                    result = 10;
                    break;
                case Moneda.COIN_1:
                    result = 1;
                    break;
                default:
                    result = -1;
                    break;
            }

            return result;
        }

        public static Moneda ToMoneda(int centims)
        {
            Moneda result = Moneda.COIN_50000;
            switch (centims)
            {
                case 10000:
                    result = Moneda.COIN_10000;
                    break;
                case 1000:
                    result = Moneda.COIN_1000;
                    break;
                case 100:
                    result = Moneda.COIN_100;
                    break;
                case 10:
                    result = Moneda.COIN_10;
                    break;
                case 1:
                    result = Moneda.COIN_1;
                    break;
            }

            return result;
        }

        public static List<Moneda> GetMonedaChange(int money)
        {
            List<Moneda> listResult = new List<Moneda>();
            int centimsResult = money;

            while (centimsResult > 0)
            {
                listResult = AddMonedaToList(centimsResult);
                centimsResult = GetChangeRemaining(centimsResult);
            }

            return listResult;
        }

        public static List<Moneda> AddMonedaToList(int centims)
        {
            List<Moneda> listResult = new List<Moneda>();
            Moneda moneda = new Moneda();
            int BillsCount = 0;

            switch (centims)
            {
                case > 10000:
                    BillsCount = centims / 10000;
                    moneda = Moneda.COIN_10000;
                    break;
                case > 1000:
                    BillsCount = centims / 1000;
                    moneda = Moneda.COIN_1000;
                    break;
                case > 100:
                    BillsCount = centims / 100;
                    moneda = Moneda.COIN_100;
                    break;
                case > 10:
                    BillsCount = centims / 10;
                    moneda = Moneda.COIN_10;
                    break;
                case > 1:
                    BillsCount = centims / 1;
                    moneda = Moneda.COIN_1;
                    break;
            }

            for (int i = 0; i < BillsCount; i++)
            {
                listResult.Add(moneda);
            }
            return listResult;
        }

        // Javi: esto funciona !?!??!?!?!?!? O_O
        public static int GetChangeRemaining(int centims)
        {
            switch (centims)
            {
                case > 10000:
                    return centims % 10000;
                case > 1000:
                    return centims % 1000;
                case > 100:
                    return centims % 100;
                case > 10:
                    return centims % 10;
                case > 1:
                    return centims % 1;
            }

            return 0;
        }
    }
}
