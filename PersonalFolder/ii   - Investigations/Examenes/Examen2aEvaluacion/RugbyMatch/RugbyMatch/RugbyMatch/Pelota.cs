using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugbyMatch
{
    public class Pelota
    {
        private int _x;
        private int _y;

        public int PelotaX
        {
            get { return _x; }
            set { _x = value; }
        }
        public int PelotaY
        {
            get { return _y; }
            set { _y = value; }
        }

        public Pelota(int x, int y)
        {
            _x = x;
            _y = y;
        }

    }
}
