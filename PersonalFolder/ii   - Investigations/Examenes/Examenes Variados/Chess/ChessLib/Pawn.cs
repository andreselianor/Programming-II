using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Pawn : Figure
    {
        public Pawn(int x, int y, FigureType figure, Color color)
        {
            PositionX = x;
            PositionY = y;
            Color = color;
            FigureType FigureType = GetFigureType(figure);
        }

        public static List<(int x, int y)> AvailableMovePawn(int turn, int x, int y)
        {
            List<(int x, int y)> movement = new List<(int, int)>();

            (int, int) result = (0, 0);
            (int, int) result2 = (0, 0);

            if (turn == 1)
            {
                result = (x, y + 2);
                movement.Add(result);
            }
            else if (turn == 1)
            {
                result2 = (x, y + 2);
                movement.Add(result2);
            }
            else
            {
                result = (x, y + 1);
                movement.Add(result);
            }            
            return movement;
        }        
    }
}
