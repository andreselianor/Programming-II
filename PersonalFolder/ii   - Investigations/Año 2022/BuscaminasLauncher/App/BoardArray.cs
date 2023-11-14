namespace Buscaminas
{
    public class BoardArray : IBoard
    {
        #region InnerClass
        public class Cell
        {
            private int _x;
            private int _y;
            private bool _state;
            private bool _bomb;
            private bool _flag;
            private int _bombProximity;

            public int X
            {
                get { return _x; }
                set { _x = value; }
            }

            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public bool State
            {
                get { return _state; }
                set { _state = value; }
            }

            public bool Bomb
            {
                get { return _bomb; }
                set { _bomb = value; }
            }

            public bool Flag
            {
                get { return _flag; }
                set { _flag = value; }
            }
            public int BombProximity
            {
                get { return _bombProximity; }
                set { _bombProximity = value; }
            }

            public Cell()
            {

            }

            public Cell(int x, int y)
            {
                _x = x;
                _y = y;
                _bomb = false;
                _flag = false;
                _state = false;
            }
        }
        #endregion

        #region Atributos
        private Cell[] _arrayCell;
        private int _width;
        private int _height;
        #endregion

        #region Metodos
        public void CreateBoard(int width, int height)
        {
            _width = width;
            _height = height;

            int celda;
            int celdaNumber = (width * height);
            _arrayCell = new Cell[celdaNumber];
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    celda = CalculateCellPosition(i,j);
                    _arrayCell[celda] = new Cell(i, j);
                }
            }
        }

        public void Init(int x, int y, int numberBomb)
        {
            _arrayCell = new Cell[x * y];
            int arrayLength = (x * y);

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    _arrayCell[i] = new Cell(i, j);
                }

            }
            while (numberBomb > 0)
            {
                //int bombCell = Utils.GetRandom(0, _arrayCell.Length);

                int bombCell = 4;       // Hardcode para comprobar el funcionamiento del programa

                if (_arrayCell[bombCell].Bomb == false)
                {
                    _arrayCell[bombCell].Bomb = true;
                    numberBomb--;
                }
            }
        }

        public int CalculateCellPosition(int x, int y)
        {
            return (_width * y) + x;
        }

        public bool IsBombAt(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            return _arrayCell[celda].Bomb == true;
        }

        public int GetBombAt(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            if (_arrayCell[celda].Bomb == true && _arrayCell[celda].Flag == true)
                return 0;
            return 1;
        }

        public void GetBombProximity(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            int result = 0;
            if (x == 0)
            {
                if (y == 0)
                {
                    if (_arrayCell[celda + 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda + _width * y].Bomb == true)
                        result++;
                }
                if (y == _height - 1)
                {
                    if (_arrayCell[celda + 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - _width * y].Bomb == true)
                        result++;
                }

                // refactorizar

                if (y == 1)
                {
                    if (_arrayCell[celda + 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - _width * y].Bomb == true)
                        result++;
                    if (_arrayCell[celda + _width * y].Bomb == true)
                        result++;
                }
            }
            else if (y == 0)
            {

                if (x == _width - 1)
                {
                    if (_arrayCell[celda - 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda + _width * y].Bomb == true)
                        result++;
                }

                // refactorizar

                if (x == 1)
                {
                    if (_arrayCell[celda + 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda + _width * (y + 1)].Bomb == true)
                        result++;
                }
            }
            else if (x == _width - 1)
            {

                if (y == _height - 1)
                {
                    if (_arrayCell[celda - 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - _width * y].Bomb == true)
                        result++;
                }

                // refactorizar

                if (y == 1)
                {
                    if (_arrayCell[celda - 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - _width * y].Bomb == true)
                        result++;
                    if (_arrayCell[celda + _width * y].Bomb == true)
                        result++;
                }
            }
            else if (y == _height - 1)
            {

                if (x == 1)
                {
                    if (_arrayCell[celda + 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - 1].Bomb == true)
                        result++;
                    if (_arrayCell[celda - _width * (y - 1)].Bomb == true)
                        result++;
                }
            }

            _arrayCell[celda].BombProximity = result;
        }

        public int GetCell(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            return _arrayCell[celda].BombProximity;
        }

        public bool IsFlagAt(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            return _arrayCell[celda].Flag == true;
        }

        public void PutFlagAt(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            _arrayCell[celda].Flag = true;
        }

        public void DeleteFlagAt(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            _arrayCell[celda].Flag = false;
        }

        public bool IsOpen(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            return _arrayCell[celda].State == true;
        }

        public void OpenCell(int x, int y)
        {
            int celda = CalculateCellPosition(x, y);
            _arrayCell[celda].State = true;
            GetBombProximity(x, y);
        }

        public void RecursiveOpenCell(int x, int y)
        {
            OpenCell(x, y);
            int celda = CalculateCellPosition(x, y);

            if (_arrayCell[celda].BombProximity == 0)
            {
                if (x != _width - 1)
                {
                    OpenCell(x + 1, y);
                }

                if (x != 0)
                {
                    OpenCell(x - 1, y);
                }

                if (y != _height - 1)
                {
                    OpenCell(x, y + 1);
                }

                if (y != 0)
                {
                    OpenCell(x, y - 1);
                }
            }
        }

        public bool HasWin()
        {
            bool check = false;
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    if (IsOpen(i, j) == true || GetBombAt(i, j) == 0)
                    {
                        check = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return check;
        }
        #endregion
    }
}
