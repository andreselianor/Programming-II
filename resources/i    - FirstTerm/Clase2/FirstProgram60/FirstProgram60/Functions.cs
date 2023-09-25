using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram60
{
    public class Functions
    {
        public static int SumNumbers(int a, int b)
        {
            return a + b;
        }

        public static int GetMajor(int valueA, int valueB)
        {
            if (valueA > valueB)
            {
                return valueA;
            }
            else
            {
                return valueB;
            }
        }
    }
}
