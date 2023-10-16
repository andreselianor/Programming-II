using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11Torneo
{
    public class Utils
    {
        //TODO Funciones Random

        public static Random random = new Random();
        public double GetRandomO(double min, double max)
        {
            return min + random.NextDouble() * max;
        }

        public static double GetRandom(double min, double max)
        {
            return min + random.NextDouble() * max;
        }
    }
}
