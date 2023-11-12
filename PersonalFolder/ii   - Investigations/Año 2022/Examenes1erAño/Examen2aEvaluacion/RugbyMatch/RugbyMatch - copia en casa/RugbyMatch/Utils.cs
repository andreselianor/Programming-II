using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Utils
    {
        public static int GetRandom(int min, int max)
        {
            Random R1 = new Random();
            return R1.Next(min, max);
        }
    }
}
