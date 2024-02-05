using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismIII
{
    public class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        if(AreConsecutives(i,j,k) && AreTriplets(i,j,k) && TripletsWithSum(i,j,k,sum))
                            yield return (i, j, k);
                    }
                }
            }
        }

        public static bool AreConsecutives(int a, int b, int c)
        {
            return (a < b && b < c);
        }

        public static bool AreTriplets(int a, int b, int c)
        {
            return (a * a) + (b * b) == (c * c);
        }

        public static bool TripletsWithSum(int a, int b, int c, int sum)
        {            
            return a + b + c == sum;
        }
    }
}
