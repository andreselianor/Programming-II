using ChessLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public enum Color
    {
        WHITE,
        BLACK
    }

    public enum FigureType
    {
        PAWN,
        KING,
        QUEEN,
        BISHOP,
        KNIGHT,
        ROCK
    }

    abstract public class Figure
    {
        //ATRIBUTOS

        private Color _color;
        private int _positionX;
        private int _positionY;
        private FigureType _figureType;

        private int _exp;
        private int _level;

        //PROPERTIES
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }

        public int PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }

        public FigureType FigureType
        {
            get { return _figureType; }
        }

        public FigureType GetFigureType(FigureType value)
        {
            _figureType = value;
            return _figureType;
        }

        // CONSTRUCTORES
        public Figure ()
        {

        }

        public Figure (int x, int y, FigureType figuretype)
        {
            _positionX = x;
            _positionY = y;
            _figureType = figuretype;
        }

        public static List<(int, int)> AvailableMovementsPawn(int x, int y, int turn)
        {
            List<(int, int)> resultList = new List<(int, int)>();
            (int, int) result = (0, 0);

            if (turn == 1)
            {
                result = (x, y + 2);
            }
            else
            {
                result = (x, y + 1);
            }

            resultList.Add(result);
            return resultList;
        }

    }

    /*

        //METHODS

        public static int GetTurn(int turn)
        {
            int result = turn;
            return result;
        }

        public Figure GetPawn()
        {
            Figure namePawn = new Figure();
            return namePawn;

        }
        public Figure GetFigure2()
        {
            Figure f1 = new Figure();
            return f1;
        }
        public class AvailableMov1
        {
            List<string> AvailablePawn = new List<string>();

        }

        /*
        //PREGUNTA, COMO CREAR UNA LISTA DE TUPLAS
        public static List<Tuple<int,int>> AvailableMov(int x, int y)
        {
            List<Tuple<int,int>> result = new List<Tuple<int,int>>();
            Tuple.Create(PawnMove.Tuple(4, 2, 2), PawnMove.Tuple(4, 2, 2));
            result.Add(PawnMove.Tuple(4, 2,2));
            return result;
        }
        /*
         * INICIALIZAR UNA TUPLA
        var tupleList = new List<(int, string)>
            {
                (1, "value1"),
                (2, "value2"),
                (3, "value3")
            };
        * /

public static List<Position> AvailableMov1(int x, int y)
{
    List<int, int> result = new List<int, int>();
    result.Add(PawnMove1(x, y, 1), PawnMove2(x, y, 1));

    return result;
}

public static List<Tuple<int, int>> AvailableMov2(int x, int y)
{
    // List<Tuple<int, int>> tupleList = new List<Tuple<int, int>>();
    // tupleList = Tuple.Create(PawnMove1(x, y, 1), PawnMove2(x, y, 1));

    List<Tuple<int, int>> result = new List<Tuple<int, int>>();
    result.Add(Tuple.Create(PawnMove1(x, y, 1), PawnMove2(x, y, 1)));

    return result;
}
public static (int, int) PawnMove(int x, int y, int turnNumber)
{
    (int, int) result = (0, 0);
    int turn = turnNumber;
    if (turn == 1)
    {
        result = (x, y + 2);
    }
    else
    {
        result = (x, y + 1);
    }

    return result;
}

public static int PawnMove1(int x, int y, int turnNumber)
{
    int result = 0;
    int turn = turnNumber;
    if (turn == 1)
    {
        result = (x);
    }
    else
    {
        result = (x);
    }

    return result;
}

public static int PawnMove2(int x, int y, int turnNumber)
{
    int result = 0;
    int turn = turnNumber;
    if (turn == 1)
    {
        result = (y + 2);
    }
    else
    {
        result = (y + 1);
    }

    return result;
}

public static (int, int) RockMove(int x, int y)
{
    (int, int) result = (0, 0);
    int result1 = 0;
    int result2 = 0;
    for (int i = -7; i <= 8; i++)
    {
        for (int j = -7; i <= 8; j++)
        {
            result1 += (i + x);
            result2 += (j + y);
        }
    }
    result = (result1, result2);
    return result;
}

public static (int, int) KnightMove(int x, int y)
{
    (int, int) result = (0, 0);

    return result;
}

public static (int, int) BishopMove(int x, int y)
{
    (int, int) result = (0, 0);
    int result1 = 0;
    int result2 = 0;
    for (int i = -7, j = -7; i <= 8 || j <= 8; i++, j++)
    {
        result1 += (i + x);
        result2 += (j + y);
    }
    result = (result1, result2);
    return result;
}

public static (int, int) QueenMove(int x, int y)
{
    (int, int) result = (0, 0);
    int result1 = 0;
    int result2 = 0;
    for (int i = -7; i <= 8; i++)
    {
        for (int j = -7; i <= 8; i++)
        {
            result1 += (i + x);
            result2 += (j + y);
        }
    }
    result = (result1, result2);
    return result;
}

public static (int, int) KingMove(int x, int y)
{
    (int, int) result = (0, 0);
    int result1 = 0;
    int result2 = 0;
    for (int i = -1; i <= 1; i++)
    {
        for (int j = -1; j <= 1; j++)
        {
            result1 += (i + x);
            result2 += (j + y);
        }
    }
    result = (result1, result2);
    return result;
}

public static char TranslateRows(int x)
{
    char result = ' ';

    switch (x)
    {
        case 1:
            result = 'a';
            break;
        case 2:
            result = 'b';
            break;
        case 3:
            result = 'c';
            break;
        case 4:
            result = 'd';
            break;
        case 5:
            result = 'e';
            break;
        case 6:
            result = 'f';
            break;
        case 7:
            result = 'g';
            break;
        case 8:
            result = 'h';
            break;
    }
    return result;
}

public static string PawnEvents(int y)
{
    string answer = "";
    if (y == 8)
        answer = "El peon se transforma en Dama \n Whites' Advantage!";
    return answer;
}
*/
}








