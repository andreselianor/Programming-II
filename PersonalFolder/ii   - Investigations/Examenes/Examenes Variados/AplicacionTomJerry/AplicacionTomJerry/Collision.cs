using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTomJerry
{
    internal class Collision
    {
        public static bool IsCollide(float xmin,float ymin, float xmax,float ymax, float x1min, float y1min, float x1max, float y1max)
        {
            if (x1min > xmax || x1max < xmin || y1min > ymax || y1max < ymin)
                return false;
            return true;
        }
    }
}
