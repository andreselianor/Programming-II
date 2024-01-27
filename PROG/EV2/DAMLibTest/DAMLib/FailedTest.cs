using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMLib
{
    public class FailedTest
    {
        public int number;
        public override int GetHashCode()
        {
            return 10;
        }

        public int sum()
        {
            FailedTest f1 = new FailedTest();
            return f1.GetHashCode();
        }
    }
}
