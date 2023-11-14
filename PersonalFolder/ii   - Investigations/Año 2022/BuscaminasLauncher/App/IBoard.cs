namespace Buscaminas
{
    public interface IBoard
    {
        void CreateBoard(int width, int height);
        void Init(int x, int y, int numberBomb);
        bool IsBombAt(int x, int y);
        int GetBombAt(int x, int y);
        void GetBombProximity(int x, int y);
        int GetCell(int x, int y);
        bool IsFlagAt(int x, int y);
        void PutFlagAt(int x, int y);
        void DeleteFlagAt(int x, int y);
        bool IsOpen(int x, int y);
        void OpenCell(int x, int y);
        void RecursiveOpenCell(int x, int y);
        public bool HasWin();
    }
}
