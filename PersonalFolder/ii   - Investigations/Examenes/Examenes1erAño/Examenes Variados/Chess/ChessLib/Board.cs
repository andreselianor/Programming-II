using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib

{
    public class Board
    {
        public static List<Figure> BoardGame()
        {
            List<Figure> Figures = new List<Figure>();
            Figure P1W = new Pawn(1, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P1W);
            Figure P2W = new Pawn(2, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P2W);
            Figure P3W = new Pawn(3, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P3W);
            Figure P4W = new Pawn(4, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P4W);
            Figure P5W = new Pawn(5, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P5W);
            Figure P6W = new Pawn(6, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P6W);
            Figure P7W = new Pawn(7, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P7W);
            Figure P8W = new Pawn(8, 2, FigureType.PAWN, Color.WHITE);
            Figures.Add(P8W);

            return Figures;

        }
    }
}
