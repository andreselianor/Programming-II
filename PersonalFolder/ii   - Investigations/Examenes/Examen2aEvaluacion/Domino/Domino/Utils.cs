using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public class Utils
    {
        public static int GetRandom(int number)
        {
            Random r1 = new Random();
            return r1.Next(number);
        }
    }
}
