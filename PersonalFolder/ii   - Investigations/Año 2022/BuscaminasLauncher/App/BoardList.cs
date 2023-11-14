namespace Buscaminas
{
    public class BoardList : IBoard
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
        private List<Cell> _listCell = new List<Cell>();
        private int _width;
        private int _height;

        #endregion

        #region Metodos
        public void CreateBoard(int width, int height)
        {
            _width = width;
            _height = height;

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    Cell c1 = new Cell(i, j);
                    _listCell.Add(c1);
                }
            }
        }

        public void Init(int x, int y, int numberBomb)
        {
            while (numberBomb > 0)
            {
                //int bombSet = Utils.GetRandom(0, _listCell.Count);
                int bombCell = 4;       // Hardcode para comprobar el funcionamiento del programa

                if (_listCell[bombCell].Bomb == false)
                {
                    _listCell[bombCell].Bomb = true;
                    numberBomb--;
                }
            }
        }

        public int CalculatePositionList(int x, int y)
        {
            return (_width * y) + x;
        }

        public bool IsBombAt(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            return _listCell[celda].Bomb == true;
        }

        public int GetBombAt(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            if (_listCell[celda].Bomb == true && _listCell[celda].Flag == true)
                return 0;
            return 1;
        }

        public void GetBombProximity(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            int result = 0;
            if (x == 0)
            {
                if (y == 0)
                {
                    if (_listCell[celda + 1].Bomb == true)
                        result++;
                    if (_listCell[celda + _width * y].Bomb == true)
                        result++;
                }
                if (y == _height - 1)
                {
                    if (_listCell[celda + 1].Bomb == true)
                        result++;
                    if (_listCell[celda - _width * y].Bomb == true)
                        result++;
                }

                // refactorizar

                if (y == 1)
                {
                    if (_listCell[celda + 1].Bomb == true)
                        result++;
                    if (_listCell[celda - _width * y].Bomb == true)
                        result++;
                    if (_listCell[celda + _width * y].Bomb == true)
                        result++;
                }
            }
            else if (y == 0)
            {

                if (x == _width - 1)
                {
                    if (_listCell[celda - 1].Bomb == true)
                        result++;
                    if (_listCell[celda + _width * y].Bomb == true)
                        result++;
                }

                // refactorizar

                if (x == 1)
                {
                    if (_listCell[celda + 1].Bomb == true)
                        result++;
                    if (_listCell[celda - 1].Bomb == true)
                        result++;
                    if (_listCell[celda + _width * (y + 1)].Bomb == true)
                        result++;
                }
            }
            else if (x == _width - 1)
            {

                if (y == _height - 1)
                {
                    if (_listCell[celda - 1].Bomb == true)
                        result++;
                    if (_listCell[celda - _width * y].Bomb == true)
                        result++;
                }

                // refactorizar

                if (y == 1)
                {
                    if (_listCell[celda - 1].Bomb == true)
                        result++;
                    if (_listCell[celda - _width * y].Bomb == true)
                        result++;
                    if (_listCell[celda + _width * y].Bomb == true)
                        result++;
                }
            }
            else if (y == _height - 1)
            {

                if (x == 1)
                {
                    if (_listCell[celda + 1].Bomb == true)
                        result++;
                    if (_listCell[celda - 1].Bomb == true)
                        result++;
                    if (_listCell[celda - _width * (y - 1)].Bomb == true)
                        result++;
                }
            }

            _listCell[celda].BombProximity = result;
        }

        public int GetCell(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            return _listCell[celda].BombProximity;
        }
        public bool IsFlagAt(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            return _listCell[celda].Flag == true;
        }
        public void PutFlagAt(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            _listCell[celda].Flag = true;
        }
        public void DeleteFlagAt(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            _listCell[celda].Flag = false;
        }
        public bool IsOpen(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            return _listCell[celda].State == true;
        }
        public void OpenCell(int x, int y)
        {
            int celda = CalculatePositionList(x, y);
            _listCell[celda].State = true;
            GetBombProximity(x, y);
        }

        public void RecursiveOpenCell(int x, int y)
        {
            OpenCell(x, y);
            int celda = CalculatePositionList(x, y);

            if (_listCell[celda].BombProximity == 0)
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
            for (int j = 0; j < _width; j++)
            {
                for (int i = 0; i < _height; i++)
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
