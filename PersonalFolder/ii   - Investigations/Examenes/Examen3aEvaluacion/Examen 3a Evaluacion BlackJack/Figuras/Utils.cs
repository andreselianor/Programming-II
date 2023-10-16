using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public class Utils
    {
        public static double GetDistance(double point1X, double point1Y, double point2X, double point2Y)
        {
            double result = 0;
            double coordX = point2X - point1X;
            double coordY = point2Y - point1Y;
            result = Math.Sqrt(coordX * coordX + coordY * coordY);
            return result;
        }

        public static double GetPerimeterSquare(double lado)
        {
            return lado * 4;
        }

        public static double GetPerimeterTriangle(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3;
        }

        public static double GetPerimeterCircle(double radius)
        {
            return 2 * 3.14 * radius;
        }

        public static double GetAreaSquare(double lado)
        {
            return lado * lado;
        }

        public static double GetAreaTriangle(double basetriangle, double altura)
        {
            return (basetriangle * altura ) / 2;
        }

        public static double GetAreaCircle(double radius)
        {
            return 3.14 * radius * radius;
        }
    }
}
