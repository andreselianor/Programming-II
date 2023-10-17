using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCrazyRace
{
    public class Utils
    {
        public static int GetRandomReal(int min, int max)
        {
            Random R1 = new Random();
            int result1 = R1.Next(min, max);
            return result1;
        }

        public static double GetRandomDouble(int min, int max)
        {
            Random R2 = new Random();
            double result2 = min + R2.NextDouble() * (max - min);
            return result2;
        }

    }
}
