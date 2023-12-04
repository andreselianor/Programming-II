using System;

namespace Exercism
{
    static class SavingsAccount
    {
        public static float InterestRate(decimal balance)
        {
            if (balance < 0)
                return 3.213f;
            if (balance >= 0 && balance < 1000)
                return 0.5f;
            if (balance >= 100 && balance < 5000)
                return 1.621f;
            else
                return 2.475f;
        }

        public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;

        public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int result = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                result++;
            }
            return result;
        }
    }
}

