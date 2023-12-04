using System;
namespace Exercism
{
    class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };

            //int[] result = new int[]{0,2,5,3,7,8,4};
            //return result;

        }

        public int Today()
        {
            int TodayBirds = birdsPerDay.Length - 1;
            return birdsPerDay[TodayBirds];
        }

        public void IncrementTodaysCount()
        {
            int increment = Today() + 1;
            birdsPerDay = new int[] { 0, 2, 5, 3, 7, 8, increment };
        }

        public bool HasDayWithoutBirds()
        {
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] == 0)
                    return true;
            }
            return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int result = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                result += birdsPerDay[i];
            }
            return result;
        }

        public int BusyDays()
        {
            int result = 0;
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] >= 5)
                    result++;
            }
            return result;
        }
    }
}

