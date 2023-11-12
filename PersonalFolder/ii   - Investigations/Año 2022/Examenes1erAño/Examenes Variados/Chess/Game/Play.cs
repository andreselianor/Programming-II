using ChessLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Play
    {

        public static void Launch()
        {

            Console.WriteLine("Bienvenid@ a Chess Game Experience");
            Console.WriteLine("==================================");


            List<Figure> figures = new List<Figure>();
            figures = Board.BoardGame();

            foreach (Figure f in figures)
            {
                Console.WriteLine("" + f.FigureType + f.Color + f.PositionX + f.PositionY + "\n");
            }

            int turn = 1;
            bool wincondition = false;

            while (wincondition == false)
            {
                Console.WriteLine($"Es el turno {turn} de las BLANCAS");
                Console.WriteLine("Escoge una pieza para mover...");
                string choice = Console.ReadLine();
            }


            /*
            List<Figure> figures = new List<Figure>();
            figures = ChessLib.Figure.GetFigure();

            foreach(Figure f in figures)
            {
                Console.WriteLine(f);
                Console.WriteLine(f.Color);
                Console.WriteLine(f.FigureType);
                Console.WriteLine(f.PositionX);
                Console.WriteLine(f.PositionY);
            }
                     
            bool Win = false;
            Win = Board.WinCondition(false);

            int turnNumber = 1;

            int inicioPX = 4;
            int MovimientoX = inicioPX;
            int inicioPY = 4;
            int MovimientoY = inicioPX;

            /*
            while (Win == false)
            {                
                Console.WriteLine("Este es el turno " + Figure.GetTurn(turnNumber));

                char CharConvert = Figure.TranslateRows(MovimientoY);
                Console.WriteLine("El peón está en: " + MovimientoX + ", " + CharConvert);
                Console.WriteLine("Escoge una posicion para el peon");

                p1.PositionX = MovimientoX;
                p1.PositionA = MovimientoY;

                Console.WriteLine("Posiciones posibles: " + Figure.PawnMove(MovimientoX, MovimientoY, turnNumber));

                string mX = Console.ReadLine();
                MovimientoX = int.Parse(mX);
                string mY = Console.ReadLine();
                MovimientoY = int.Parse(mY);

                Console.WriteLine("Mueves el peon a: " + MovimientoX + ", " + MovimientoY);
                Console.WriteLine("");

                string textPawn = Figure.PawnEvents(MovimientoY);
                Console.WriteLine(textPawn);

                turnNumber += 1;
            }
            */

        }
    }
}
