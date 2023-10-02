using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    public class Functions
    {
        public static int GetGreaterThanZero(List<double> list)
        {
            int result = 0;

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                    result++;
            }
            return result;
        }

        public static int GetGreaterThanZero(double[] list)
        {
            int result = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > 0)
                    result++;
            }
            return result;
        }
    }
}
