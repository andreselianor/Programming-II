using System;

namespace Exercism
{


    public static class ResistorColor
    {
        public static int ColorCode(string color)
        {
            string[] colorMatrix = CreateMatrix();
            for (int i = 0; i < colorMatrix.Length; i++)
            {
                if (color == colorMatrix[i])
                    return i;
            }
            return -1;
        }

        public static string[] Colors()
        {
            return CreateMatrix();
        }

        public static string[] CreateMatrix()
        {
            string[] colorMatrix;

            colorMatrix = new string[]
            {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
            };

            return colorMatrix;
        }
    }
}
