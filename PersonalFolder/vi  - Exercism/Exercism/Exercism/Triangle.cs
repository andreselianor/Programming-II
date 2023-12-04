using System;

namespace Exercism
{
    public static class Triangle
    {
        public static bool IsScalene(double side1, double side2, double side3)
        {
            double a = side1, b = side2, c = side3;
            if (a + b < c || a + c < b || b + c < a)
                return false;
            if (a == b || a == c || b == c)
                return false;
            return true;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (side1 == side2 && side1 != side3 && side3 < side1)
                return true;
            if (side2 == side3 && side2 != side1 && side1 < side2)
                return true;
            if (side1 == side3 && side1 != side2 && side2 < side1)
                return true;
            if (IsEquilateral(side1, side2, side3))
                return true;
            return false;
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            return (side1 == side2 && side2 == side3 && side1 != 0);
        }

    }
}
