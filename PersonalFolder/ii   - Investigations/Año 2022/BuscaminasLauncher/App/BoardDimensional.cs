namespace Buscaminas
{
    public class BoardDimensional : IBoard
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

            public Cell(int x, int y)
            {
                _x = x;
                _y = y;
                _state = false;
                _bomb = false;
                _flag = false;
            }
        }
        #endregion

        #region Atributos
        private int _width;
        private int _height;
        private Cell[,] _matrixCell;
        #endregion

        #region Properties
        public int Width => _width;
        public int Height => _height;

        //public int GetCell => _matrixCell[1,1].BombProximity;
        #endregion

        #region Metodos
        public void CreateBoard(int width, int height)
        {
            _width = width;
            _height = height;

            _matrixCell = new Cell[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    _matrixCell[i, j] = new Cell(i, j);
                }
            }
        }

        public void Init(int x, int y, int numberBomb)
        {
            while (numberBomb > 0)
            {
                /*
                int bombSetX = Utils.GetRandom(0, x);
                int bombSetY = Utils.GetRandom(0, y);
                */
                int bombSetX = 1;
                int bombSetY = 1;
                if (_matrixCell[bombSetX, bombSetY].Bomb == false)
                {
                    _matrixCell[bombSetX, bombSetY].Bomb = true;
                    numberBomb--;
                }
            }
        }
        public bool IsBombAt(int x, int y)
        {
            return _matrixCell[x, y].Bomb == true;
        }

        public int GetBombAt(int x, int y)
        {
            if (_matrixCell[x, y].Bomb == true && _matrixCell[x, y].Flag == true)
                return 0;
            return 1;
        }
        public void GetBombProximity(int x, int y)
        {
            int result = 0;
            if (x == 0)
            {
                if (y == 0)
                {
                    if (_matrixCell[x + 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y + 1].Bomb == true)
                        result++;
                }
                if (y == _height - 1)
                {
                    if (_matrixCell[x + 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y - 1].Bomb == true)
                        result++;
                }

                // refactorizar

                if (y == 1)
                {
                    if (_matrixCell[x + 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y - 1].Bomb == true)
                        result++;
                    if (_matrixCell[x, y + 1].Bomb == true)
                        result++;
                }
            }
            else if (y == 0)
            {

                if (x == _width - 1)
                {
                    if (_matrixCell[x - 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y + 1].Bomb == true)
                        result++;
                }

                // refactorizar

                if (x == 1)
                {
                    if (_matrixCell[x + 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x - 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y + 1].Bomb == true)
                        result++;
                }
            }
            else if (x == _width - 1)
            {

                if (y == _height)
                {
                    if (_matrixCell[x - 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y - 1].Bomb == true)
                        result++;
                }

                // refactorizar

                if (y == 1)
                {
                    if (_matrixCell[x - 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y - 1].Bomb == true)
                        result++;
                    if (_matrixCell[x, y + 1].Bomb == true)
                        result++;
                }
            }
            else if (y == _height - 1)
            {

                if (x == 1)
                {
                    if (_matrixCell[x - 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x + 1, y].Bomb == true)
                        result++;
                    if (_matrixCell[x, y - 1].Bomb == true)
                        result++;
                }
            }

            _matrixCell[x, y].BombProximity = result;
        }

        public int GetCell(int x, int y)
        {
            return _matrixCell[x, y].BombProximity;
        }


        public bool IsFlagAt(int x, int y)
        {
            return _matrixCell[x, y].Flag == true;
        }
        public void PutFlagAt(int x, int y)
        {
            _matrixCell[x, y].Flag = true;
        }
        public void DeleteFlagAt(int x, int y)
        {
            _matrixCell[x, y].Flag = false;
        }
        public bool IsOpen(int x, int y)
        {
            return _matrixCell[x, y].State == true;
        }
        public void RecursiveOpenCell(int x, int y)
        {
            OpenCell(x, y);
            if (_matrixCell[x, y].BombProximity == 0)
            {
                if(x != Width - 1)
                {
                    OpenCell(x + 1, y);
                }
                
                if(x != 0)
                {
                    OpenCell(x - 1, y);
                }
                
                if(y != Height - 1)
                {
                    OpenCell(x, y + 1);
                }
                
                if(y != 0)
                {
                    OpenCell(x, y - 1);
                }                
            }
        }
        public void OpenCell(int x, int y)
        {
            _matrixCell[x, y].State = true;
            GetBombProximity(x, y);
        }

        public bool HasWin()
        {
            bool check = false;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
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
